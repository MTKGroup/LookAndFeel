using LookAndFeel.Controls;
using LookAndFeel.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            ComponentFactory fac = new DarkComponentFactory();

            var form = (LookAndFeel.Forms.Form)fac.create("Form", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            DarkButton b = (DarkButton)fac.create("Button", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            b.Text = "nhan";
            b.Top = 100;
        
            DarkCheckBox checkbox = (DarkCheckBox)fac.create("CheckBox", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            checkbox.Text = "nam";
            checkbox.Top = 130;

            form.addControl(b);
            form.addControl(checkbox);

            //form = (LookAndFeel.Forms.Form)form.convert(new LightComponentFactory());

            Application.Run(form);

        }
    }
}
