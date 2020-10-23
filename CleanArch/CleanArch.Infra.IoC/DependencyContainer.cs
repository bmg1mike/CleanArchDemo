using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Infra.Data.Repository;
using Core.Models.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
