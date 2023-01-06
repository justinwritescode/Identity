/*
 * DI.cs
 *
 *   Created: 2022-12-20-12:36:48
 *   Modified: 2022-12-20-12:36:48
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Extensions.DependencyInjection;
using System.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using System.Net.Mail;

public static class DescribeDataTypesExtensions
{
    public static WebApplicationBuilder DescribeIdentityDataTypes(this WebApplicationBuilder builder)
    {
        builder.Services.DescribeIdentityDataTypes();
        return builder;
    }

    public static IServiceCollection DescribeIdentityDataTypes(this IServiceCollection services)
    {
        services.ConfigureSwaggerGen(c =>
        {
            c.MapType<EmailAddress>(() => new OpenApiSchema
            {
                Type = "string",
                Pattern = EmailAddress.RegexString,
                Format = nameof(EmailAddress),
                Description = "An email address",
                Example = new OpenApiString("justin@justinwritescode.com"),
                Default = new OpenApiString(null),
                ExternalDocs = new OpenApiExternalDocs
                {
                    Description = "Email Address",
                    Url = new Uri("https://en.wikipedia.org/wiki/Email_address")
                }
            });
            c.MapType<PhoneNumber>(() => new OpenApiSchema
            {
                Type = "string",
                Pattern = PhoneNumber.RegexString,
                Format = nameof(PhoneNumber),
                Description = "A phone number in E.164 format",
                Example = new OpenApiString("+19174099321"),
                Default = new OpenApiString(null),
                ExternalDocs = new OpenApiExternalDocs
                {
                    Description = "E.164",
                    Url = new Uri("https://en.wikipedia.org/wiki/E.164")
                }
            });
        });
        return services;
    }
}
