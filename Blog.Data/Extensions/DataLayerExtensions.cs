using Blog.Data.Context;
using Blog.Data.Repositories.Abstracts;
using Blog.Data.Repositories.Concretes;
using Blog.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));//IRepository'i çağırdığımızda Repository nesnesi döndürüyor(dependency injection)
                                                                            //typeof da generic yapılanma için kullanılıyor

            services.AddScoped<IUnitOfWork, UnitOfWork>();//dependency injection

            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));//Database bağlantısı

            return services;
        }
       
    }
}
