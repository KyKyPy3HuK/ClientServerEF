using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Model
{
    internal class ТипПроживающего
    {
        [Key]
        public int Id { get; set; }
        public string Название { get; set; }
        public string Описание { get; set; }
        public int Тариф { get; set; }
    }
}
