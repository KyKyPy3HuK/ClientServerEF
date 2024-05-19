using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Model
{
    internal class Работник
    {
        [Key]
        public int Id { get; set; }
        public string ФИО { get; set; }

        [ForeignKey("Должность")]
        public int КодДолжности { set; get; }
        public Должность Должность {  get; set; }
    }
}
