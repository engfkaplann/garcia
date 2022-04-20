﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarciaCore.CodeGenerator
{
    public class Solution
    {
        public Solution(string name, string folder, List<string> integrations, string defaultDatabaseServer, bool overwriteItemCode, bool overwriteNonItemCode)
        {
            Name = name;
            Folder = folder;
            Integrations = integrations;
            DefaultDatabaseServer = defaultDatabaseServer;
            OverwriteItemCode = overwriteItemCode;
            OverwriteNonItemCode = overwriteNonItemCode;
        }

        public string Name { get; set; }
        public string Folder { get; set; }
        public List<string> Integrations { get; }
        public string DefaultDatabaseServer { get; }
        public bool OverwriteItemCode { get; }
        public bool OverwriteNonItemCode { get; }
        public List<Project> Projects { get; set; } = new List<Project>();

        //protected virtual async Task<List<GenerationResult>> Generate(Item item)
        //{
        //    var generationResults = new List<GenerationResult>();

        //    foreach (var project in Projects)
        //    {
        //        var generationResult = await project.Generate(item);
        //        generationResults.AddRange(generationResult);
        //    }

        //    return generationResults;
        //}

        public virtual async Task<GenerationResultContainer> Generate(List<Item> items)
        {
            GeneratorRepository.Solution = this;
            var generationResults = new GenerationResultContainer();
            var validItems = new List<Item>();
            int index = 0;

            foreach (var item in items)
            {
                if (!item.Properties.Select(x => x.Name).Contains("CreatedOn"))
                {
                    item.Properties.Add(new ItemProperty("CreatedOn", ItemPropertyType.DateTimeOffset, ItemPropertyMappingType.Property, null, false));
                }

                if (item.Properties.Count(x => string.IsNullOrEmpty(x.Name)) > 0)
                {
                    generationResults.Messages.Add(new GenerationResultMessage(GenerationResultMessageType.Error, $"Item {item.Name} contains a null property name at index {index}, cannot generate code for item {item.Name}."));
                }
                else
                {
                    var propertyNames = new List<string>();
                    var isValid = true;

                    foreach (var property in item.Properties)
                    {
                        if (propertyNames.Contains(property.Name.ToLowerInvariant()))
                        {
                            isValid = false;
                            generationResults.Messages.Add(new GenerationResultMessage(GenerationResultMessageType.Error, $"Item {item.Name} already contains property {property.Name}, cannot generate code for item {item.Name}."));
                            break;
                        }
                        else
                        {
                            propertyNames.Add(property.Name.ToLowerInvariant());
                        }
                    }

                    if (isValid)
                    {
                        validItems.Add(item);
                    }
                }

                index++;
            }

            foreach (var item in validItems)
            {
                GeneratorRepository.AddItem(item);
            }

            foreach (var item in validItems)
            {
                foreach (var project in Projects)
                {
                    var generationResult = await project.Generate(item);
                    generationResults.GenerationResults.AddRange(generationResult);
                }

                foreach (var property in item.Properties.Where(x => x.InnerType != null))
                {
                    if (items.Count(x => x.Name.ToLowerInvariant() == property.InnerType.Name.ToLowerInvariant()) == 0)
                    {
                        generationResults.GenerationResults.ForEach(x => x.Messages.Add(new GenerationResultMessage(GenerationResultMessageType.Warning, $"Item {property.InnerType.Name} does not exist in item collection, possible build error.")));
                    }
                }
            }

            foreach (var project in Projects)
            {
                var generationResult = await project.Generate();
                generationResults.GenerationResults.AddRange(generationResult);
            }

            return generationResults;
        }
    }

    public class GenerationResultContainer
    {
        public List<GenerationResult> GenerationResults { get; set; } = new List<GenerationResult>();
        public List<GenerationResultMessage> Messages { get; set; } = new List<GenerationResultMessage>();
        public string AllMessages { get { return string.Join('\n', Messages.OrderByDescending(x => x.Type).Select(x => $"{x.Type.ToString()}: {x.Message}")); } }
    }
}