using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace User_Interface{    using MaterialSkin;    using MaterialSkin.Controls;
    using System.Drawing;
    using System.Windows.Forms;

    public static class MaterialFormTheme    {        public static void ApplyTheme(MaterialForm form)        {            var materialSkinManager = MaterialSkinManager.Instance;            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue50, Primary.LightBlue700, Accent.LightBlue700, TextShade.WHITE);
            materialSkinManager.AddFormToManage(form);            materialSkinManager.ThemeChanged += (sender) => form.Invalidate();            form.Disposed += (sender, args) => materialSkinManager.RemoveFormToManage(form);        }        public static void ApplyMenuStripTheme(MenuStrip menuStrip)
        {


            // Apply the custom renderer to the MenuStrip
            menuStrip.RenderMode = ToolStripRenderMode.System;
            menuStrip.BackColor = Color.SteelBlue;
            menuStrip.ForeColor = Color.White;
            menuStrip.Font = new Font("poppins", 8, FontStyle.Bold);
            menuStrip.Dock = DockStyle.Top;
            menuStrip.Location = new Point(0, 0);


            // Set the TopMost property to true if needed

        }    }


}