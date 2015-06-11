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
            
            ComponentFactory fac = new DarkComponentFactory();

            var form = (LookAndFeel.Forms.Form)fac.create("Form", new ComponentInfo());
            
            DarkTextBox textbox = (DarkTextBox)fac.create("TextBox", new ComponentInfo());
            textbox.Text = "vu nam";
            textbox.Top = 20;
            textbox.Left = 20;

            DarkGroupBox groupBox = (DarkGroupBox)fac.create("GroupBox", new ComponentInfo());
            groupBox.Text = "Nam Vu";
            groupBox.Top = 80;

            //form.addControl(textbox);
            groupBox.addControl(textbox);
            form.addControl(groupBox);


            //form = (LookAndFeel.Forms.Form)form.convert(new LightComponentFactory());

            Application.Run(form);

        }

        
    }
}
