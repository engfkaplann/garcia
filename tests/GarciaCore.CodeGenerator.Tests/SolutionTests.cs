using Shouldly;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace GarciaCore.CodeGenerator.Tests
{
    public class SolutionTests
    {
        private ISolutionService _solutionService;
        private readonly ITestOutputHelper _output;

        public SolutionTests(ITestOutputHelper output)
        {
            _solutionService = new SolutionService();
            _output = output;
        }

        [Fact]
        public async Task CreateSolutionAsync()
        {
            var json = await _solutionService.GetSampleJsonAsync();
            var result = await _solutionService.CreateSolutionAsync(json);
            result.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetSolutionJsonAsync()
        {
            var solution = await _solutionService.CreateSampleSolutionAsync();
            var result = await _solutionService.GetSolutionJsonAsync(solution);
            result.ShouldNotBeNullOrEmpty();
            _output.WriteLine(result);
        }

        [Fact]
        public async Task GetSampleJsonAsync()
        {
            var result = await _solutionService.GetSampleJsonAsync();
            result.ShouldNotBeNullOrEmpty();
            _output.WriteLine(result);
        }

        [Fact]
        public async Task CreateSampleSolutionAsync()
        {
            var result = await _solutionService.CreateSampleSolutionAsync();
            result.ShouldNotBeNull();
        }

        [Fact]
        public async Task GenerateItemsAsync()
        {
            var items = new List<Item>()
            {
                new Item()
                {
                    Name = "User",
                    IdType = IdType.Guid,
                    Properties = new List<ItemProperty>()
                    {
                        new ItemProperty() { Name = "Name", Type = ItemPropertyType.String, MappingType = ItemPropertyMappingType.Property },
                        new ItemProperty() { Name = "Surname", Type = ItemPropertyType.String, MappingType = ItemPropertyMappingType.Property },
                        new ItemProperty() { Name = "HomeAddress", Type = ItemPropertyType.Class, MappingType = ItemPropertyMappingType.Property, InnerType = new Item() { Name = "Address" } },
                        new ItemProperty() { Name = "WorkAddress", Type = ItemPropertyType.Class, MappingType = ItemPropertyMappingType.Property, InnerType = new Item() { Name = "Address" } }
                    }
                },
                new Item()
                {
                    Name = "Address",
                    IdType = IdType.Int,
                    Properties = new List<ItemProperty>()
                    {
                        new ItemProperty() { Name = "Addressline", Type = ItemPropertyType.String, MappingType = ItemPropertyMappingType.Property },
                    }
                }
            };

            //Console.WriteLine(JsonConvert.SerializeObject(items, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }));
            _output.WriteLine(JsonSerializer.Serialize(items));
            var solution = await _solutionService.CreateSampleSolutionAsync();
            var result = await solution.Generate(items);
            result.ShouldNotBeNull();
            result.ShouldNotBeEmpty();

            foreach (var item in result)
            {
                item.Folder.ShouldNotBeNullOrEmpty();
                item.Generator.ShouldNotBeNull();
                item.Code.ShouldNotBeNullOrEmpty();
                _output.WriteLine($"// Folder: {item.Folder}, Generator: {item.Generator.GetType().Name}");
                _output.WriteLine(item.Code);
            }

            foreach (var item in result)
            {
                var allMessages = item.AllMessages;

                if (!string.IsNullOrEmpty(allMessages))
                    _output.WriteLine($"// Messages: {allMessages}");
            }
        }
    }
}
