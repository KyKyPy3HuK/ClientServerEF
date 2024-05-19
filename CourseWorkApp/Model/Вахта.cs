using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Model
{
    internal class Вахта
    {
        [Key]
        public int Id { get; set; }
        public string Тип { get; set; }

        public DateTime ДатаЗахода { get; set; }

        [Column(TypeName = "date")]
        public DateTime Длительность { get; set; }

        public int Ставка { get; set; }

        [ForeignKey("Работник")]
        public int Вахтер {  get; set; }
        public Работник Работник { get; set; }
    }
}
