using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace User_Interface{    using MaterialSkin;    using MaterialSkin.Controls;
    using System.Drawing;
    using System.Windows.Forms;

    public static class MaterialFormTheme    {        public static void ApplyTheme(MaterialForm form)        {            var materialSkinManager = MaterialSkinManager.Instance;            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue300, Primary.Indigo100, Accent.DeepOrange700, TextShade.WHITE);
            materialSkinManager.AddFormToManage(form);            materialSkinManager.ThemeChanged += (sender) => form.Invalidate();            form.Disposed += (sender, args) => materialSkinManager.RemoveFormToManage(form);        }        public static void ApplyDarkTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }        public static void ApplyLightTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }        public static void ApplyMenuStripTheme(params MenuStrip[] menuStrips)
        {

            foreach (MenuStrip menuStrip in menuStrips) {





                menuStrip.RenderMode = ToolStripRenderMode.System;
                menuStrip.BackColor = Color.DodgerBlue;
                menuStrip.ForeColor = Color.White;
                menuStrip.Font = new Font("poppins", 8, FontStyle.Bold);
                menuStrip.Dock = DockStyle.Top;
                menuStrip.Location = new Point(0, 0);
                



            }

        }        public static void ApplyHeaderSkin(params Label[] labels)
        {

            foreach(Label label in labels)
            {

                label.Size = new System.Drawing.Size(1529, 58);
                label.BackColor = System.Drawing.Color.CornflowerBlue;
                label.ForeColor = Color.White;
                label.Font = new System.Drawing.Font("Poppins", 20F);


            }


        }    }


}