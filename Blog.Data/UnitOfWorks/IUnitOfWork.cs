using Blog.Core.Entities;
using Blog.Data.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class,IEntityBase,new();//Generic olarak bütün repoları almış oluyor.

        Task<int> SaveAsync();
        int save();//asenkron kullanamayacağımız durumlar olursa diye fonk.
    }
}
