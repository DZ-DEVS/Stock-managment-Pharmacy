using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace User_Interface{    using MaterialSkin;    using MaterialSkin.Controls;
    using System.Drawing;
    using System.Windows.Forms;

    public static class MaterialFormTheme    {        public static void ApplyTheme(MaterialForm form)        {            var materialSkinManager = MaterialSkinManager.Instance;            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue300, Primary.Indigo100, Accent.DeepOrange700, TextShade.WHITE);
            materialSkinManager.AddFormToManage(form);            materialSkinManager.ThemeChanged += (sender) => form.Invalidate();            form.Disposed += (sender, args) => materialSkinManager.RemoveFormToManage(form);        }        public static void ApplyDarkTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }        public static void ApplyLightTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }




        public static void Changecolorsetting(string theme)
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            switch (theme)
            {
                case "blue":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue300, Primary.Indigo100, Accent.DeepOrange700, TextShade.WHITE);
                    break;
                case "green":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green300, Primary.LightGreen100, Accent.DeepOrange700, TextShade.WHITE);
                    break;
                case "red":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red300, Primary.Pink100, Accent.DeepOrange700, TextShade.WHITE);
                    break;
                case "yellow":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow600, Primary.Yellow300, Primary.Amber100, Accent.DeepOrange700, TextShade.WHITE);
                    break;
                case "orange":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange600, Primary.Orange300, Primary.DeepOrange100, Accent.DeepOrange700, TextShade.WHITE);
                    break;
                default:
                   
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue300, Primary.Indigo100, Accent.DeepOrange700, TextShade.WHITE);
                    break;
            }
        }
          }


}