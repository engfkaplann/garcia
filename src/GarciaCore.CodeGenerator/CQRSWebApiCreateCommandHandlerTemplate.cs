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
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class CQRSWebApiCreateCommandHandlerTemplate : BaseTemplate
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
            
            #line 10 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"

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
            
            #line 31 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class Create");
            
            #line 33 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("CommandHandler : IRequestHandler<Create");
            
            #line 33 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command, int>\r\n    {\r\n        private I");
            
            #line 35 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Repository _");
            
            #line 35 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n");
            
            #line 36 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"

    foreach (var repository in repositories)
    {

            
            #line default
            #line hidden
            this.Write("        private I");
            
            #line 40 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repository));
            
            #line default
            #line hidden
            this.Write("Repository _");
            
            #line 40 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repository.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n");
            
            #line 41 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\n        public Create");
            
            #line 45 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("CommandHandler(");
            
            #line 45 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repositoryString));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n             _");
            
            #line 47 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository =  ");
            
            #line 47 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n");
            
            #line 48 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"

    foreach (var repository in repositories)
    {

            
            #line default
            #line hidden
            this.Write("            _");
            
            #line 52 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repository.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository =  ");
            
            #line 52 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(repository.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository;\r\n");
            
            #line 53 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        public async Task<int> Handle(Create");
            
            #line 58 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Command request, CancellationToken cancellationToken)\r\n        {\r\n            var" +
                    " item = new ");
            
            #line 60 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 61 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"

    foreach (var property in Item.Properties.Where(x => x.Type != ItemPropertyType.Class))
    {

            
            #line default
            #line hidden
            this.Write("            item.");
            
            #line 65 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write(" = request.");
            
            #line 65 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 66 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"

    }

            
            #line default
            #line hidden
            
            #line 69 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"

    foreach (var property in properties)
    {

            
            #line default
            #line hidden
            this.Write("            var ");
            
            #line 73 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write(" = await _");
            
            #line 73 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.InnerType.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Repository.GetByIdAsync(request.");
            
            #line 73 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("Id);\r\n\r\n            if (");
            
            #line 75 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write(" == null)\r\n            {\r\n                throw new DomainNotFoundException($\"");
            
            #line 77 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.InnerType.Name));
            
            #line default
            #line hidden
            this.Write(" {request.");
            
            #line 77 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("Id} not found\");\r\n            }\r\n\r\n            item.");
            
            #line 80 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 80 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 81 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\n            var result = await _");
            
            #line 85 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Item.Name));
            
            #line default
            #line hidden
            this.Write("Repository.SaveAsync(item);\r\n            return result;\r\n        }\r\n    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 91 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\CQRSWebApiCreateCommandHandlerTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new CQRSWebApiCreateCommandHandlerGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
