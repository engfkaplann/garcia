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
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class WebApiAppSettingsTemplate : BaseTemplate
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n{\r\n  \"Logging\": {\r\n    \"LogLevel\": {\r\n      \"Default\": \"Information\",\r\n      \"M" +
                    "icrosoft\": \"Warning\",\r\n      \"Microsoft.Hosting.Lifetime\": \"Information\"\r\n    }\r" +
                    "\n  },\r\n  \"AllowedHosts\": \"*\",\r\n  \"JwtIssuerOptions\": {\r\n    \"Issuer\": \"");
            
            #line 13 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write("\",\r\n    \"Audience\": \"http://");
            
            #line 14 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorRepository.Solution.Name));
            
            #line default
            #line hidden
            this.Write("-app.com/\",\r\n    \"SecretKey\": \"8b95c3c301a54b39b7b9b4c612bc6844\",\r\n    \"ValidFor\"" +
                    ": 10000\r\n  },\r\n");
            
            #line 18 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"

    if (GeneratorRepository.ContainsIntegration(IntegrationType.AmazonS3FileUpload))
    {

            
            #line default
            #line hidden
            this.Write("  \"AmazonS3Settings\": {\r\n    \"AccessKeyId\": \"AKIAXP5ELXGKN2VGXQUD\",\r\n    \"SecretA" +
                    "ccessKey\": \"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\",\r\n    \"BucketName\": \"farmi" +
                    "assetstest\",\r\n    \"BucketUrl\": \"https://farmiassetstest.s3.eu-central-1.amazonaw" +
                    "s.com\"\r\n  },\r\n");
            
            #line 28 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.LocalFileUpload))
    {

            
            #line default
            #line hidden
            this.Write("  \"FileUploadSettings\": {\r\n    \"FileUploadPath\": \"\",\r\n    \"BaseUrl\": \"\"\r\n  },\r\n");
            
            #line 38 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MandrillEmail))
    {

            
            #line default
            #line hidden
            this.Write("  \"MandrillEmailSettings\": {\r\n    \"ApiKey\": \"\",\r\n    \"SenderEmailAddress\": \"\",\r\n " +
                    "   \"Bcc\": \"\"\r\n  },\r\n");
            
            #line 49 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.MailChimpMarketing))
    {

            
            #line default
            #line hidden
            this.Write("  \"MailChimpMarketingSettings\": {\r\n    \"ApiKey\": \"\",\r\n    \"AudienceListId\": \"\"\r\n " +
                    " },\r\n");
            
            #line 59 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.FirebasePushNotification))
    {

            
            #line default
            #line hidden
            this.Write("  \"FirebasePushNotificationSettings\": {\r\n    \"AccessToken\": \"\"\r\n  },\r\n");
            
            #line 68 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.SQLServer))
    {

            
            #line default
            #line hidden
            this.Write("  \"ConnectionStrings\": {\r\n    \"SqlServer\": \"server=dev.forfarming.co;user id=forf" +
                    "arming;password=Ff756638;initial catalog=Farmi;Min Pool Size=100;Max Pool Size=5" +
                    "00\"\r\n  },\r\n");
            
            #line 77 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"

    }

    if (GeneratorRepository.ContainsIntegration(IntegrationType.LocalImageResize))
    {

            
            #line default
            #line hidden
            this.Write("  \"ImageResizeSettings\": {\r\n    \"MaximumHeight\": 400,\r\n    \"DefaultHeight\": 200\r\n" +
                    "  }\r\n");
            
            #line 87 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 93 "C:\Users\vehbi\source\repos\projects\garciacore\src\GarciaCore.CodeGenerator\WebApiAppSettingsTemplate.tt"

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
