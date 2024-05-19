using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Model
{
    internal class Проживающий
    {
        [Key]
        public int Id { get; set; }

        public string Фио { get; set; }

        public string Пол { get; set; }

        //[Column("Дата рождения")]
        [Column(TypeName = "date")]
        public DateTime ДатаРождения { get; set; }

        [ForeignKey("ТипПроживающего")]
        public int Тип { get; set; }
        public ТипПроживающего ТипПроживающего { get; set; }

        [ForeignKey("Комната")]
        //[Column("Номер комнаты")]
        public int НомерКомнаты {  get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Комната Комната {  get; set; }

        //[Column("Кол-во занимаемых мест")]
        [DefaultValue(1)]
        public int КолвоМест {  get; set; }

        [DefaultValue(0)]
        public int Задолженность {  get; set; }
    }
}
