using System;
using System.Collections.Generic;
using System.Text;
using Dictionary.Domain.Core;
using Dictionary.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Dictionary.Infrastructure.Data
{
    public class GenericRepo<TEntity> { } //: IDictionaryRepo<TEntity> where TEntity : class
    //{


        //    private readonly Context db;

        //    //private DbSet<T>  dbSet => db.Set<T>();

        //    public GenericRepo(Context dbContext)
        //    {
        //        db = dbContext;
        //    }


        //    public IQueryable<TEntity> GetAll()
        //    {
        //        return db.Set<TEntity>().AsNoTracking();
        //    }


        //    public async Task Create(TEntity entity)
        //    {
        //        await db.Set<TEntity>().AddAsync(entity);
        //        await db.SaveChangesAsync();
        //    }

        //    public async Task Update(int id, TEntity entity)
        //    {


        //        db.Set<TEntity>().Update(entity);
        //        await db.SaveChangesAsync();

        //        // db.Entry(entity).State = EntityState.Modified;
        //    }

        //    public async Task Delete(int id)
        //    {
        //        var entity = await GetByID(id);
        //        db.Set<TEntity>().Remove(entity);
        //        await db.SaveChangesAsync();
        //    }

        //    public async Task<TEntity> GetByID(int id)
        //    {
        //        return await db.Set<TEntity>()
        //                    .AsNoTracking().
        //                    .FirstOrDefaultAsync(e => e.ID == id);
        //    }




        //    public void Save()
        //    {
        //        db.SaveChanges();
        //    }

        //    private bool disposed = false;

        //    public virtual void Dispose(bool disposing)
        //    {
        //        if (!this.disposed)
        //        {
        //            if (disposing)
        //            {
        //                db.Dispose();
        //            }
        //        }
        //        this.disposed = true;
        //    }

        //    public void Dispose()
        //    {
        //        Dispose(true);
        //        GC.SuppressFinalize(this);
        //    }


        //    }

        //    //public void Update(T item)
        //    //{
        //    //    db.Entry(item).State = EntityState.Modified;
        //    //}


        // }
}
