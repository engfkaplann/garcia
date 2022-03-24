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
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class EntityFrameworkDbContextTemplate : BaseTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("/*\r\n\tThis file was generated automatically by Garcia Framework.\r\n*/");
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
            this.Write("\r\nusing System.Reflection;\r\nusing Microsoft.Extensions.DependencyInjection;\r\nusin" +
                    "g MediatR;\r\nusing GarciaCore.Persistence.EntityFramework;\r\nusing Microsoft.Entit" +
                    "yFrameworkCore;\r\nusing GarciaCore.Application;\r\n");
            
            #line 17 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 18 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"

    var className = $"{GeneratorRepository.Solution.Name}DbContext";

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 22 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 24 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write(" : BaseContext\r\n    {\r\n        public ");
            
            #line 26 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("(DbContextOptions<");
            
            #line 26 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("> options, ILoggedInUserService loggedInUserService)\r\n            : base(options," +
                    " loggedInUserService)\r\n        {\r\n        }\r\n");
            
            #line 30 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"

        foreach (var item in GeneratorRepository.Items)
        {

            
            #line default
            #line hidden
            this.Write("        public DbSet<");
            
            #line 34 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 34 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("s { get; set; }\r\n");
            
            #line 35 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 41 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\EntityFrameworkDbContextTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new EntityFrameworkDbContextGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
