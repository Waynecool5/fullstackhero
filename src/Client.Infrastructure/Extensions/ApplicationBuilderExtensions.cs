﻿namespace FSH.BlazorWebAssembly.Client.Infrastructure.Extensions;
public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app, IConfiguration config)
    {
        return app;
    }
}