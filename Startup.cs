using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SoapCore;
// services
using Services;


namespace SoapTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSoapCore();
            services.TryAddSingleton<Services.PersonService.IPersonService, Services.PersonService.PersonService>();
            services.TryAddSingleton<Services.Arithmetic.IArithmeticService, Services.Arithmetic.ArithmeticService>();
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
            app.UseRouting();
            app.UseEndpoints(endpoints => {
                endpoints.UseSoapEndpoint<Services.PersonService.IPersonService>(
                    "/PersonService.asmx",
                    new SoapEncoderOptions(),
                    SoapSerializer.DataContractSerializer
                );

                endpoints.UseSoapEndpoint<Services.Arithmetic.IArithmeticService>(
                    "/ArithmeticService.asmx",
                    new SoapEncoderOptions(),
                    SoapSerializer.DataContractSerializer
                );
            });
        }
    }
}