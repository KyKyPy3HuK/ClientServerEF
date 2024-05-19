using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Model
{
    internal class Заявка
    {
        [Key]
        public int Id {  get; set; }
        public string Тема { get; set; }
        public string Текст { get; set; }
        public string Статус { get; set; }

        [Column(TypeName = "date")]
        public DateTime ДатаСоздание {  get; set; }

        [ForeignKey("Проживающий")]
        public int Составаитель {  get; set; }
        public Проживающий Проживающий {  get; set; }

        [ForeignKey("Работник")]
        public int Ответственный {  get; set; }
        public Работник Работник { get; set; }
    }
}
