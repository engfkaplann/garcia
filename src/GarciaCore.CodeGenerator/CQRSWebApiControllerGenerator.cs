﻿namespace GarciaCore.CodeGenerator
{
    public class CQRSWebApiControllerGenerator : Generator<CQRSWebApiControllerTemplate>
    {
        public override string DefaultBaseClass => "ApiController";
        protected override string FileNamePostfix => "Controller";
        public override GeneratorType GeneratorType => GeneratorType.Api;
    }
}