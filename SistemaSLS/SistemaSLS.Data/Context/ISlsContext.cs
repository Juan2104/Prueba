﻿using SistemaSLS.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace SistemaSLS.Data.Context
{
    public interface ISlsContext
    {

        DbSet<TipoPersona> TipoPersona { get; set; }

       

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();

        Task<int> SaveChangesAsync();

        void Dispose();


    }
}
