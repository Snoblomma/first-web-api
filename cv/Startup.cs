using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using cv.Models;
using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace cv
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<TodoContext>(opt =>
            //    opt.UseInMemoryDatabase("TodoList"));
            //var connection = @"dbname=d621snr5j1dqc4 host=ec2-54-247-125-137.eu-west-1.compute.amazonaws.com port=5432 user=ulspdpqvumwtgl password=120f3ec46cfe6f75411ce7898940813e032ff0df86ee397ddee9b0028c65b472 sslmode=require";
            //services.AddDbContext<TodoContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<TodoContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TodoContext")));
            services.AddMvc() 
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
