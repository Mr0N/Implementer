using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace Implementer
{
    class Program
    {
        static void Config(ServiceCollection services)
        {
            services.AddScoped<Worker>(a => new Worker("Hi"));
        }
        static ServiceProvider CreateProvider()
        {
            var service = new ServiceCollection();
            Config(service);
            return service.BuildServiceProvider();
        }
       
        static void Main(string[] args)
        {

            using (provider)
            {
                Initialization();
            }
        }
        static void Initialization()
        {
           var res =  Worker.Current;
            res.Write();
            Console.ReadKey();
        }
        public static ServiceProvider provider { get; }
        static Program()
        {
            provider = CreateProvider();
        }
    }
}
