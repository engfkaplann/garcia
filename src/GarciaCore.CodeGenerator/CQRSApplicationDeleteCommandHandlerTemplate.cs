// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace GarciaCore.CodeGenerator
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using GarciaCore.CodeGenerator;
    using GarciaCore.Infrastructure;
    using GarciaCore.Application;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CQRSApplicationDeleteCommandHandlerTemplate : BaseTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("/*\r\n\tThis file was generated automatically by Garcia Framework. \r\n\tDo not edit ma" +
                    "nually. \r\n\tAdd a new partial class with the same name if you want to add extra f" +
                    "unctionality.\r\n*/");
            this.Write("\r\n");
            this.Write(@"using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using GarciaCore.Infrastructure;
using GarciaCore.Domain;
using GarciaCore.Persistence;
using System.Threading;
using System.Threading.Tasks;");
            this.Write("\r\n");
            
            #line 11 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"

    var repositoryString = $"I{Item.Name}Repository {Item.Name.ToCamelCase()}Repository";
    var properties = Item.Properties.Where(x => x.Type == ItemPropertyType.Class);
    var repositories = new List<string>();

    foreach (var property in properties)
    {
        if (!repositories.Contains(property.InnerType.Name))
        {
            repositories.Add(property.InnerType.Name);
        }
    }

    foreach (var repository in repositories)
    {
        repositoryString += $", I{repository}Repository {repository.ToCamelCase()}Repository";
    }

    repositoryString = repositoryString.Trim().TrimEnd(',');

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 32 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class Delete");
            
            #line 34 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("CommandHandler : IRequestHandler<Delete");
            
            #line 34 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command, int>\r\n    {\r\n        private I");
            
            #line 36 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Repository _");
            
            #line 36 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n");
            
            #line 37 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"

    foreach (var repository in repositories)
    {

            
            #line default
            #line hidden
            this.Write("        private I");
            
            #line 41 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repository));
            
            #line default
            #line hidden
            this.Write("Repository _");
            
            #line 41 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repository.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n");
            
            #line 42 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\n        public Delete");
            
            #line 46 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("CommandHandler(");
            
            #line 46 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repositoryString));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            _");
            
            #line 48 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository =  ");
            
            #line 48 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n        }\r\n\r\n        public async Task<int> Handle(Delete");
            
            #line 51 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command request, CancellationToken cancellationToken)\r\n        {\r\n            var" +
                    " item = await _");
            
            #line 53 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Repository.GetByIdAsync(request.Id);\r\n\r\n            if (item == null)\r\n          " +
                    "  {\r\n                throw new DomainNotFoundException($\"");
            
            #line 57 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write(" {request.Id} not found\");\r\n            }\r\n            \r\n            item.IsDelet" +
                    "ed = true;\r\n            var result = await _");
            
            #line 61 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Repository.SaveAsync(item);\r\n            return result;\r\n        }\r\n    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 67 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSApplicationDeleteCommandHandlerTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new CQRSApplicationDeleteCommandHandlerGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
