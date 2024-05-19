using CourseWorkApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkApp
{
    public partial class MainForm : Form
    {
        CWDBContext context = new CWDBContext();
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
