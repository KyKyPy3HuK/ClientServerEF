using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Model
{
    internal class CWDBContext : DbContext
    {
        public CWDBContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            (
                @"Server = USERPC;
                Database = CourseWorkEF;
                Integrated Security=true;
                Encrypt = True;
                TrustServerCertificate = true;"
            );
        }

        public DbSet<Проживающий> Проживающие {  get; set; }
        public DbSet<ТипПроживающего> ТипыПроживающих { get; set; }
        public DbSet<Вахта> Вахты {  get; set; }
        public DbSet<Работник> Работники {  get; set; }
        public DbSet<Заявка> Заявки {  get; set; }
        public DbSet<Комната> Комнаты {  get; set; }
        public DbSet<Блок> Блоки { get; set; }
        public DbSet<ТипБлока> ТипыБлоков {  get; set; }
        public DbSet<Должность> Должности {  get; set; }
        public DbSet<Инвентарь> Инвентаризация { get; set; }
    }
}
