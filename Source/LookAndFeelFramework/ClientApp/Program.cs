using LookAndFeel.Controls;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
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
            b.Top = 50;


            LightCheckBox checkbox = (LightCheckBox)fac.create("CheckBox", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            checkbox.Text = "nam gay";
            checkbox.Top = 80;

            LightTextBox textbox = (LightTextBox)fac.create("TextBox", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            textbox.Text = "vu nam gay";
            textbox.Top = 130;

            LightComboBox combobox = (LightComboBox)fac.create("ComboBox", new LookAndFeelLibrary.Main.Components.ComponentInfo());
            combobox.Text = "nam vu gay";
            combobox.Top = 180;
            combobox.Items.Add("Vietnam");
            combobox.Items.Add("Japan");
            combobox.Items.Add("USA");


            form.addControl(b);
            form.addControl(checkbox);
            form.addControl(textbox);
            form.addControl(combobox);


            //form = (LookAndFeel.Forms.Form)form.convert(new LightComponentFactory());
            //form = (LookAndFeel.Forms.Form)form.convert(new DarkComponentFactory());
            Application.Run(form);

        }

        
    }
}
