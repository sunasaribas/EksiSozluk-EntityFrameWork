using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EksiSozluk_EntityFrameWork
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EksiSozluk;uid=sa;pwd=123");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Gundem> Gundems { get; set; }
        public DbSet<Debe> Debes { get; set; }
        public DbSet<Sorunsallar> Sorunsallars { get; set; }
        public DbSet<Spor> Spors { get; set; }
        public DbSet<İliskiler> İliskilers { get; set; }
        public DbSet<Entry> Genders { get; set; }
    }
}
