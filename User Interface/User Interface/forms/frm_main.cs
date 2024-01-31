using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface.forms
{
    public partial class frm_main : MaterialForm
    {
        public frm_main()
        {
            InitializeComponent();
            MaterialFormTheme.ApplyTheme(this);
        }



       
    }
}
