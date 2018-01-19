using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using Dictionary.BLL.DTO;
using Dictionary.BLL.Services;
using Dictionary.Infrastructure.Data.UnitOfWork;
using Dictionary.Domain.Interfaces;
using Dictionary.Domain.Core;
using Dictionary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //AutomapperConfiguration.Configure();

           //Mappings.RegisterMappings();
           

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //var con = @"Server=mail.vk.edu.ee\SQLEXPRESS;Database=db_Elonen; user id=t143264;password=t143264";

            //services.AddDbContext<Context>(options => options.UseSqlServer(con));

            services.AddDbContext<Context>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc();
            services.AddCors();
            services.AddSingleton<IEngEstService, EngEstService>();
            services.AddAutoMapper(typeof(Startup));
            services.AddSingleton<IUnitOfWork,UnitOfWork>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddTransient<IUnitOfWork,UnitOfWork>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutomapperConfiguration());
            });

            var mapper = config.CreateMapper();






            //services.AddSingleton<IGenericTranslateSerivce<EngEstService>, EngEstService>;
            //services.add
            //AutomapperConfiguration.Configure();

            //mapper, test

            //var config = new AutoMapper.MapperConfiguration(c =>
            //{ c.AddProfile(new AutomapperConfiguration()); });

            //var mapper = config.CreateMapper();
            //services.AddSingleton(mapper);

        }

        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseMvc();
        }
    }
}
