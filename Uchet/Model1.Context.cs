﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uchet
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UchetEntities : DbContext
    {
        private static UchetEntities context;
        public UchetEntities()
            : base("name=UchetEntities")
        {
        }

        public static UchetEntities GetContext()
        {
            if (context == null)
                context = new UchetEntities();
            return context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ConnectionPoint> ConnectionPoint { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentAtThePoint> EquipmentAtThePoint { get; set; }
        public virtual DbSet<HardwarePorts> HardwarePorts { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}


//Data Source=.\SQLEXPRESS; Initial Catalog=Uchet.Ses2; Integrated Security=True;