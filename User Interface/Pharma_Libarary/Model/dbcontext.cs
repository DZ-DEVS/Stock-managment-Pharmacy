﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Pharma_Libarary.Model
{
    public partial class dbcontext : DbContext
    {
        public dbcontext()
            : base("Data Source=DESKTOP-TPC2FMV;Initial Catalog=pharma;Integrated Security=True;Encrypt=False")
        {
        }

        public virtual DbSet<Classe_pharmacologique> Classe_pharmacologiques { get; set; }
        public virtual DbSet<Classe_thérapeutique> Classe_thérapeutique { get; set; }
        public virtual DbSet<DCI> DCIs { get; set; }
        public virtual DbSet<Générique> Générique { get; set; }
        public virtual DbSet<Laboratoire> Laboratoires { get; set; }
        public virtual DbSet<Medicament> Medicaments { get; set; }
        public virtual DbSet<Pay> Pays { get; set; }
        public virtual DbSet<Selle> Selles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSession> UserSessions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classe_pharmacologique>()
                .Property(e => e.nom_Cpharma)
                .IsFixedLength();

            modelBuilder.Entity<Classe_pharmacologique>()
                .HasMany(e => e.Medicaments)
                .WithRequired(e => e.Classe_pharmacologique)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Classe_thérapeutique>()
                .Property(e => e.code_Cthera)
                .IsFixedLength();

            modelBuilder.Entity<Classe_thérapeutique>()
                .HasMany(e => e.Medicaments)
                .WithRequired(e => e.Classe_thérapeutique)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DCI>()
                .Property(e => e.nom_DCI)
                .IsFixedLength();

            modelBuilder.Entity<DCI>()
                .HasMany(e => e.Medicaments)
                .WithRequired(e => e.DCI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Générique>()
                .Property(e => e.Ref_generique_origine)
                .IsFixedLength();

            modelBuilder.Entity<Générique>()
                .Property(e => e.ref_med_origine)
                .IsFixedLength();

            modelBuilder.Entity<Générique>()
                .Property(e => e.ref_med_generique)
                .IsFixedLength();

            modelBuilder.Entity<Laboratoire>()
                .Property(e => e.Lab_code)
                .IsFixedLength();

            modelBuilder.Entity<Laboratoire>()
                .Property(e => e.Lab_nom)
                .IsFixedLength();

            modelBuilder.Entity<Laboratoire>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<Laboratoire>()
                .Property(e => e.tel)
                .IsFixedLength();

            modelBuilder.Entity<Laboratoire>()
                .Property(e => e.web_adress)
                .IsUnicode(false);

            modelBuilder.Entity<Laboratoire>()
                .Property(e => e.pay_code)
                .IsFixedLength();

            modelBuilder.Entity<Laboratoire>()
                .HasOptional(e => e.Medicament)
                .WithRequired(e => e.Laboratoire);

            modelBuilder.Entity<Medicament>()
                .Property(e => e.Ref_med)
                .IsFixedLength();

            modelBuilder.Entity<Medicament>()
                .Property(e => e.nom_comrsl)
                .IsUnicode(false);

            modelBuilder.Entity<Medicament>()
                .Property(e => e.Form)
                .IsFixedLength();

            modelBuilder.Entity<Medicament>()
                .Property(e => e.Dossage)
                .IsFixedLength();

            modelBuilder.Entity<Medicament>()
                .Property(e => e.Conditionnement)
                .IsFixedLength();

            modelBuilder.Entity<Medicament>()
                .Property(e => e.Liste)
                .IsFixedLength();

            modelBuilder.Entity<Medicament>()
                .Property(e => e.Tarif)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Medicament>()
                .Property(e => e.PPA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Medicament>()
                .Property(e => e.edited_by)
                .IsFixedLength();

            modelBuilder.Entity<Medicament>()
                .Property(e => e.Lab_code)
                .IsFixedLength();

            modelBuilder.Entity<Medicament>()
                .Property(e => e.nom_Cpharma)
                .IsFixedLength();

            modelBuilder.Entity<Medicament>()
                .Property(e => e.code_Cthera)
                .IsFixedLength();

            modelBuilder.Entity<Medicament>()
                .Property(e => e.nom_DCI)
                .IsFixedLength();

            modelBuilder.Entity<Medicament>()
                .HasMany(e => e.Générique)
                .WithRequired(e => e.Medicament)
                .HasForeignKey(e => e.ref_med_origine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medicament>()
                .HasMany(e => e.Générique1)
                .WithRequired(e => e.Medicament1)
                .HasForeignKey(e => e.ref_med_generique)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medicament>()
                .HasMany(e => e.Selles)
                .WithRequired(e => e.Medicament)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pay>()
                .Property(e => e.Pays_code)
                .IsFixedLength();

            modelBuilder.Entity<Pay>()
                .Property(e => e.pay_nom)
                .IsFixedLength();

            modelBuilder.Entity<Pay>()
                .HasMany(e => e.Laboratoires)
                .WithRequired(e => e.Pay)
                .HasForeignKey(e => e.pay_code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Selle>()
                .Property(e => e.Ref_med)
                .IsFixedLength();

            modelBuilder.Entity<Selle>()
                .Property(e => e.sellerID)
                .IsFixedLength();

            modelBuilder.Entity<Selle>()
                .Property(e => e.userName)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.userName)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.nom)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.prenom)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Medicaments)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.edited_by)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Selles)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<User>()
    .HasMany(e => e.Sessions)
    .WithRequired(e => e.User)
    .HasForeignKey(e => e.UserId)
    .WillCascadeOnDelete(false);
        }
    }
}
