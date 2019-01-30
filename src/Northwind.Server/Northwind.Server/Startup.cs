using System;
using System.Collections.Generic;
using System.Linq;
using GraphiQl;
using GraphQL;
using GraphQL.EntityFramework;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.DataLayer.Entities;

namespace Northwind.Server
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
            var connectionString = Configuration.GetConnectionString("NorthwindDatabase");
            services.AddDbContext<NorthwindContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            ConfigureGraphQLInfrastructure(services, connectionString);

            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        private void ConfigureGraphQLInfrastructure(IServiceCollection services, string connectionString)
        {
            using (var context = new NorthwindContext(connectionString))
            {
                EfGraphQLConventions.RegisterInContainer(services, context);
            }

            foreach (var t in GetGraphQlTypes())
            {
                services.AddSingleton(t);
            }

            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDependencyResolver>(provider => new FuncDependencyResolver(provider.GetRequiredService));
            services.AddSingleton<ISchema, Infrastructure.Schema>();
            services.AddSingleton(typeof(Infrastructure.Strategies.IMutationStrategy<>), typeof(Infrastructure.Strategies.MutationStrategy<>));
        }

        static IEnumerable<Type> GetGraphQlTypes()
        {
            return typeof(Startup).Assembly
                .GetTypes()
                .Where(x => !x.IsAbstract &&
                            (typeof(IObjectGraphType).IsAssignableFrom(x) ||
                             typeof(IInputObjectGraphType).IsAssignableFrom(x)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseGraphiQl("/graphiql", "/graphql");

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
