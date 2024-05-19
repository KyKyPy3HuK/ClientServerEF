using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Model
{
    internal class Инвентарь
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Комната")]
        public int НомерКомнаты {  get; set; }
        public Комната Комната { get; set; }

        public string Наименование { get; set; }
        public string Описание { get; set; }

        [Column(TypeName = "date")]
        public DateTime ДатаПоставки { get; set; }

        public int Стоимость {  get; set; }
    }
}
