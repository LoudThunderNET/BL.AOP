using Castle.DynamicProxy;
using DynamicProxy.BusinessLogic.Objects.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy.Experiments.DependencyInjectionExtension
{
    public static class TransactableDepedencyExtension
    {
        private readonly static ProxyGenerator s_proxyGenerator = new ProxyGenerator();

        public static IServiceCollection AddTranactable<TService, TImplementation>(this IServiceCollection services)
            where TImplementation : class, TService
            where TService : class
        {
            services.AddScoped<TImplementation>();
            services.TryAddScoped<TransactionManager>();

            services.AddScoped<TService>((sp) => 
            {
                var target = sp.GetRequiredService<TImplementation>();
                var proxy = s_proxyGenerator.CreateInterfaceProxyWithTarget<TService>(target, new ProxyGenerationOptions
                {
                    Hook = new TransactionSelecor(),
                    
                },
                sp.GetRequiredService<TransactionManager>());

                return proxy;
            });


            return services;
        }
    }
}
