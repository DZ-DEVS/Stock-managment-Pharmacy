using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharma_Libarary.Data;
using Pharma_Libarary.Model;
namespace User_Interface
{
    public partial class LOGINFrame : Form
    {
        public LOGINFrame()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            sql_connection.add_newClass_phatmacologique("hello");
            sql_connection.add_newClass_therapeutique("hello");
            sql_connection.add_newClass_DCI("hello");
            Laboratoire lab = new Laboratoire("vvd", "youcef", "alger 16", "dzd");
            sql_connection.add_Lab(lab);

        }
    }
}
