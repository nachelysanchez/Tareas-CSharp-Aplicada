﻿using Microsoft.EntityFrameworkCore;
using RolesControl.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolesControl.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\RolesControl.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 1,
                Nombre = "Permiso para estudios",
                Descripcion = "Permiso para que el trabajador pueda estudiar"
            });
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 2,
                Nombre = "Permiso por matrimonio",
                Descripcion = "Permiso para poder celebrar"
            });
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 3,
                Nombre = "Permiso por perdidas",
                Descripcion = "Permiso para poder darle el ultimo adios a su ser querido"
            });
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 4,
                Nombre = "Permiso por alumbramiento",
                Descripcion = "Permiso para poder disfrutar la criatura"
            });
        }
    }
}
