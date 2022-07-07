using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Models;
using SoapCore;

namespace SoapTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSoapCore();
            services.TryAddSingleton<ISampleService, SampleService>();
            services.AddMvc();
        }
        public void Configure(
            IApplicationBuilder app, 
            IHostEnvironment env,
            ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            /*
            app.UseSoapEndpoint<ISampleService>(
                "/Service.asmx", 
                new BasicHttpBinding(), 
                SoapSerializer.XmlSerializer
            );
            */
            app.UseRouting();
            app.UseEndpoints(endpoints => {
                endpoints.UseSoapEndpoint<ISampleService>(
                    "/Service.asmx",
                    new SoapEncoderOptions(),
                    SoapSerializer.DataContractSerializer
                );
            });
        }
    }
}