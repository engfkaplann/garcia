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
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAuthenticationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class WebApiAuthenticationTemplate : BaseTemplate
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
            this.Write(@"
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using GarciaCore.Application.Contracts.Persistence;
using GarciaCore.Persistence.EntityFramework;
using GarciaCore.Application;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using GarciaCore.Application.Contracts.Identity;
using GarciaCore.Infrastructure.Identity;
using Microsoft.Extensions.Options;
");
            
            #line 22 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAuthenticationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetUsings()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nnamespace ");
            
            #line 24 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAuthenticationTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [ApiController]\r\n    [Route(\"[controller]\")]\r\n    public class Authentic" +
                    "ationController : ControllerBase\r\n    {\r\n        private readonly ILogger<Authen" +
                    "ticationController> _logger;\r\n        private readonly IAuthenticationService _a" +
                    "uthenticationService;\r\n        private readonly IJwtService _jwtService;\r\n      " +
                    "  private readonly JwtIssuerOptions _jwtOptions;\r\n\r\n        public Authenticatio" +
                    "nController(ILogger<AuthenticationController> logger, IAuthenticationService aut" +
                    "henticationService, IJwtService jwtService, IOptions<JwtIssuerOptions> jwtOption" +
                    "s)\r\n        {\r\n            _logger = logger;\r\n            _authenticationService" +
                    " = authenticationService;\r\n            _jwtService = jwtService;\r\n            _j" +
                    "wtOptions = jwtOptions.Value;\r\n        }\r\n\r\n        [HttpPost(\"token\")]\r\n       " +
                    " public virtual async Task<IActionResult> PostToken([FromBody] CredentialsModel " +
                    "credentials)\r\n        {\r\n            if (!ModelState.IsValid)\r\n            {\r\n  " +
                    "              return BadRequest(ModelState);\r\n            }\r\n\r\n            var i" +
                    "dentity = await _authenticationService.ValidateUser(credentials.UserName, creden" +
                    "tials.Password);\r\n\r\n            if (identity == null)\r\n            {\r\n          " +
                    "      return BadRequest(\"invalid_grant\");\r\n            }\r\n\r\n            var jwt " +
                    "= await _jwtService.GenerateJwt(identity.UserName, identity.Id, identity.Roles);" +
                    "\r\n            return new OkObjectResult(jwt);\r\n        }\r\n    }\r\n\r\n    public cl" +
                    "ass LoggedInUserService : ILoggedInUserService\r\n    {\r\n        public int UserId" +
                    " { get; set; }\r\n    }\r\n\r\n    public class AuthenticationService : IAuthenticatio" +
                    "nService\r\n    {\r\n        public async Task<IUser> ValidateUser(string userName, " +
                    "string password)\r\n        {\r\n            var model = new UserModel()\r\n          " +
                    "  {\r\n                UserName = userName,\r\n                Id = \"1\",\r\n          " +
                    "      Roles = new List<string>()\r\n                {\r\n                    \"User\"\r" +
                    "\n                }\r\n            };\r\n\r\n            return model;\r\n        }\r\n    " +
                    "}\r\n\r\n    public class UserModel : IUser\r\n    {\r\n        public string UserName {" +
                    " get; set; }\r\n        public string Id { get; set; }\r\n        public List<string" +
                    "> Roles { get; set; } = new List<string>();\r\n    }\r\n\r\n    public class Credentia" +
                    "lsModel\r\n    {\r\n        public string UserName { get; set; }\r\n        public str" +
                    "ing Password { get; set; }\r\n    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 100 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAuthenticationTemplate.tt"

    protected override Generator CreateGenerator()
	{
		return new ApplicationServiceRegistrationGenerator();
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
