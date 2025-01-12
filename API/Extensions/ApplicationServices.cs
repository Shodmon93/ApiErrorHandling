using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Erros;
using Microsoft.AspNetCore.Mvc;

namespace API.Extensions
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                {
                    var errors = actionContext.ModelState
                    .Where(e => e.Value.Errors.Count > 0)
                    .SelectMany(x => x.Value.Errors)
                    .Select(x => x.ErrorMessage).ToArray();

                    var errorResponse = new ApiValidationErrorResponnse
                    {
                        Errors = errors
                    };
                    return new BadRequestObjectResult(errorResponse);

                };
            });
            return services;
        }
    }
}