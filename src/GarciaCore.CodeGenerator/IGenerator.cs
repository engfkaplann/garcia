﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace GarciaCore.CodeGenerator
{
    public interface IGenerator
    {
        string DefaultBaseClass { get; }
        Task<string> Generate(Item item, string @namespace, string baseClass);
        List<IGenerator> Dependencies { get; set; }
        List<string> Usings { get; set; }
        public Task<string> GetFileName(Item item);
        bool IsApplicationGenerator();
    }

    public interface IGenerator<T> : IGenerator where T : BaseTemplate
    {
    }
}