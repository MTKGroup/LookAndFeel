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

            ComponentFactory fac = new LightComponentFactory();

            var form = (LookAndFeel.Forms.Form)fac.create("Form", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            LightButton b = (LightButton)fac.create("Button", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            b.Text = "nhan";
            b.Top = 100;
            form.addControl(b);

            LightTextBox textbox = (LightTextBox)fac.create("TextBox", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            textbox.Text = "text";
            textbox.Top = 200;
            form.addControl(textbox);

            LightLabel label = (LightLabel)fac.create("Label", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            label.Text = "testlabel1";
            label.Width = 60;
            label.Height = 20;
            label.Top = 150;
            form.addControl(label);

            //form = (LookAndFeel.Forms.Form)form.convert(new LightComponentFactory());

            Application.Run(form);

        }
    }
}
