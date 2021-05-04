﻿namespace QuizSystem.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {

        public Repository(ApplicationDbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
            this.DbSet = this.Context.Set<TEntity>();
        }

        protected DbSet<TEntity> DbSet { get; set; }

        protected ApplicationDbContext Context { get; set; }


        public virtual Task AddAsync(TEntity entity) => this.DbSet.AddAsync(entity).AsTask();


        public virtual IQueryable<TEntity> All() => this.DbSet;


        public virtual IQueryable<TEntity> AllAsNoTracking() => this.DbSet.AsNoTracking();


        public virtual void Delete(TEntity entity) => this.DbSet.Remove(entity);

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Task<int> SaveChangesAsync() => this.Context.SaveChangesAsync();

        public virtual void Update(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}
