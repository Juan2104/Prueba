﻿
namespace SistemaSLS.Data.Context
{
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using System.Data.SqlClient;
    using System.Configuration;
    using Domain.Entities;
    public partial class SlsContext : DbContext, ISlsContext
    {
        private static int _contador = 0; 
        public virtual DbSet<TipoPersona> TipoPersona { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TipoPersona>()
        //        .Property(e => e.id);
                
        //}
        public SlsContext() : base("name=SlsContext")
        {
            _contador++;

            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public SlsContext(bool lazyload) : base("name=SlsContext")
        {
            _contador++;

            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }

        protected override void Dispose(bool lazyLoad)
        {
            _contador--;
            Configuration.LazyLoadingEnabled = false;
            base.Dispose(lazyLoad);
        }


    }
}
