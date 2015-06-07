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
            b.Top = 50;


            DarkCheckBox checkbox = (DarkCheckBox)fac.create("CheckBox", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            checkbox.Text = "nam";
            checkbox.Top = 80;

            DarkTextBox textbox = (DarkTextBox)fac.create("TextBox", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            textbox.Text = "vu nam";
            textbox.Top = 130;

            DarkComboBox combobox = (DarkComboBox)fac.create("ComboBox", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            combobox.Text = "nam vu";
            combobox.Top = 180;
            combobox.Items.Add("Vietnam");
            combobox.Items.Add("Japan");
            combobox.Items.Add("USA");


            form.addControl(b);
            form.addControl(checkbox);
            form.addControl(textbox);
            form.addControl(combobox);


            //form = (LookAndFeel.Forms.Form)form.convert(new LightComponentFactory());

            Application.Run(form);

        }
    }
}
