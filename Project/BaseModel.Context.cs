﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pro17Entities : DbContext
    {
        private static pro17Entities _context;
        public pro17Entities()
            : base("name=pro17Entities")
        {
        }

        public static pro17Entities GetContext()
        {
            if (_context == null)
                _context = new pro17Entities();
            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PRAuto> PRAuto { get; set; }
        public virtual DbSet<PRClient> PRClient { get; set; }
        public virtual DbSet<PRProcat> PRProcat { get; set; }
    }
}
