using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Model
{
    internal class Комната
    {
        [Key]
        public int Id { get; set; }
        public string Тип {  get; set; }
        public int Вместимость {  get; set; }

        [ForeignKey("Блок")]
        public int КодБлока {  get; set; }
        public Блок Блок {  get; set; }
    }
}
