using Castle.DynamicProxy;
using DynamicProxy.BusinessLogic.Objects.Services;
using DynamicProxy.Experiments.DependencyInjectionExtension;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;
using System.Data.SqlClient;
using System.Security.Authentication.ExtendedProtection;

namespace DynamicProxy.Experiments
{
    internal class Program
    {
        private readonly static ProxyGenerator s_proxyGenerator = new ProxyGenerator();

        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTranactable<IBlogService, BlogService>();
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var blogService = scope.ServiceProvider.GetRequiredService<IBlogService>();

                blogService.PublishPost(123, new BusinessLogic.Objects.Models.Post
                {
                    Id = 1,
                    PublicationDate = DateTime.Now,
                    Text = "Test",
                    Title = "Test",
                });

            }
        }
    }
}