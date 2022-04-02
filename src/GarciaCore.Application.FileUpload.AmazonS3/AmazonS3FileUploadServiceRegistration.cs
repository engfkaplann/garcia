﻿using GarciaCore.Application.Contracts.FileUpload;
using GarciaCore.Application.Contracts.Marketing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GarciaCore.Application.FileUpload.AmazonS3
{
    public static class AmazonS3FileUploadServiceRegistration
    {
        public static IServiceCollection RegisterAmazonS3FileUploadService(this IServiceCollection services, AmazonS3Settings settings)
        {
            services.Configure<AmazonS3Settings>(options =>
            {
                options.AccessKeyId = settings.AccessKeyId;
                options.BucketName = settings.BucketName;
                options.BucketUrl = settings.BucketUrl;
                options.SecretAccessKey = settings.SecretAccessKey;
            });

            services.AddScoped<IFileUploadService, AmazonS3FileUplaodService>();
            return services;
        }

        public static IServiceCollection RegisterAmazonS3FileUploadService(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AmazonS3Settings>(options =>
            {
                options.AccessKeyId = configuration[$"{nameof(AmazonS3Settings)}:{nameof(options.AccessKeyId)}"];
                options.BucketName = configuration[$"{nameof(AmazonS3Settings)}:{nameof(options.BucketName)}"];
                options.BucketUrl = configuration[$"{nameof(AmazonS3Settings)}:{nameof(options.BucketUrl)}"];
                options.SecretAccessKey = configuration[$"{nameof(AmazonS3Settings)}:{nameof(options.SecretAccessKey)}"];
            });

            services.AddScoped<IFileUploadService, AmazonS3FileUplaodService>();
            return services;
        }
    }
}
