using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Model
{
    internal class ТипБлока
    {
        [Key]
        public int Id { get; set; }
        public int Название { get; set; }
        public int Описание { get; set; }
    }
}
