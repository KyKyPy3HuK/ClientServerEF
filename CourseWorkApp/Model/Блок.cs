using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Model
{
    internal class Блок
    {
        [Key]
        public int Id { get; set; }
        public int Этаж { get; set; }
        public int Крыло { get; set; }

        [ForeignKey("ТипБлока")]
        public int Тип { get; set; }
        public ТипБлока ТипБлока { get; set; }

        [ForeignKey("Работник")]
        public int КодДежурного { get; set; }
        public Работник Работник { get; set; }
    }
}
