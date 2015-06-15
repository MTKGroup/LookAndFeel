using ClientApp.Properties;
using LookAndFeel.Controls;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
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
        static LookAndFeel.Forms.Form form;
        static LookAndFeel.Controls.TextBox textbox1, textbox2;
        static LookAndFeel.Controls.Label labNotification;
        private static LookAndFeel.Controls.CheckBox checkbox;

        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var assembly = AppDomain.CurrentDomain.GetAssemblies().First(a => a.FullName.IndexOf("LookAndFeelLibrary") >= 0);
            var type = assembly.GetTypes().First(t => t.Name.Equals(Settings.Default.Factory));
            var obj = Activator.CreateInstance(type);
            ComponentFactory factory = (ComponentFactory)obj;
            ComponentInfo info;

            //Form
            info = new ComponentInfo(0, 0, 350, 550, "Demo");
            form = (LookAndFeel.Forms.Form)factory.create("Form", info);
            form.FormClosing += (sender, e) =>
                                    {
                                        if (!Settings.Default.Remember) return;
                                        Settings.Default.Username = textbox1.Text;
                                        Settings.Default.Password = textbox2.Text;
                                        Settings.Default.Save();
                                    };


            //Label username
            info = new ComponentInfo(20, 50, 0, 0, "Username");
            var lab1 = (LookAndFeel.Controls.IControl)factory.create("Label", info);

            //Textbox username
            info = new ComponentInfo(20, 75, 150, 25, "");
            textbox1 = (LookAndFeel.Controls.TextBox)factory.create("TextBox", info);
            

            //Label password
            info = new ComponentInfo(20, 120, 0, 0, "Password");
            var lab2 = (LookAndFeel.Controls.IControl)factory.create("Label", info);

            //Textbox password
            info = new ComponentInfo(20, 145, 150, 25, "");
            textbox2 = (LookAndFeel.Controls.TextBox)factory.create("TextBox", info);


            //Checkbox remember
            info = new ComponentInfo(20, 190, 0, 0, "Remember");
            checkbox = (LookAndFeel.Controls.CheckBox)factory.create("CheckBox", info);
            checkbox.ClickListener += (sender) =>
                                        {
                                            var cbo = sender as LookAndFeel.Controls.CheckBox;
                                            Settings.Default.Remember = cbo.Checked;
                                            Settings.Default.Save();
                                        };

            //Button login
            info = new ComponentInfo(20, 240, 100, 0, "Login");
            var btn = (LookAndFeel.Controls.Button)factory.create("Button", info);
            btn.ClickListener += event_ButtonClick;

            //Label notification
            info = new ComponentInfo(20, 280, 250, 0, "");
            labNotification = (LookAndFeel.Controls.Label)factory.create("Label", info);
           
            
            //Combobox
            info = new ComponentInfo(20, 450, 200, 20, "CboChangeTheme");
            var combobox = (LookAndFeel.Controls.ComboBox)factory.create("ComboBox", info);
            loadComboboxItems(combobox);
            selectDefaultOption(combobox);
            combobox.SelectionChangeCommitted += (sender, e) => 
                                                { 
                                                    var cbo = sender as LookAndFeel.Controls.ComboBox;
                                                    var pair = (KeyValuePair<String, String>)cbo.SelectedItem ;
                                                    if (!pair.Value.Equals(Settings.Default.Factory))
                                                    {
                                                        Settings.Default.Factory = pair.Value;
                                                        Settings.Default.Save();
                                                        form.Close();
                                                        Process.Start(Application.ExecutablePath);
                                                    }
                                                };
            //Group box 
            info = new ComponentInfo(20, 80, 300, 330, "Login");
            var group1 = (LookAndFeel.Controls.GroupBox)factory.create("GroupBox", info);

            group1.addControl(lab1);
            group1.addControl(lab2);
            group1.addControl(labNotification);
            group1.addControl(textbox1);
            group1.addControl(textbox2);
            group1.addControl(btn);
            group1.addControl(checkbox);

            form.addControl(group1);
            form.addControl(combobox);

            form.Text = "Demo";

            //Load textbox
            loadTextboxData();


            //form = (LookAndFeel.Forms.Form)form.convert(new LightComponentFactory());
            //form = (LookAndFeel.Forms.Form)form.convert(new DarkComponentFactory());
            Application.Run(form);

           

        }

        private static void loadTextboxData()
        {
            if (Settings.Default.Remember)
            {
                textbox1.Text = Settings.Default.Username;
                textbox2.Text = Settings.Default.Password;
                checkbox.Checked = true;
            }
        }

        static void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Change");
        }

        private static void selectDefaultOption(LookAndFeel.Controls.ComboBox combobox)
        {
            var pivot = Settings.Default.Factory;
            foreach (var item in combobox.Items)
            {
                var pair = (KeyValuePair<string, string>)item ;
                if (pair.Value.Equals(pivot))
                    combobox.SelectedItem = item;
                
            }
        }

        private static void loadComboboxItems(LookAndFeel.Controls.ComboBox combobox)
        {
            //extract pairs of key/value from Settings
            foreach (var line in Settings.Default.FactoryList)
            {
                string[] pair = line.Split(new char[]{':'});
                KeyValuePair<String, String> p = new KeyValuePair<string,string>(pair[0], pair[1]);
                combobox.Items.Add(p);
                combobox.DisplayMember = "Key";
            }
        }

        private static void event_ButtonClick(object sender)
        {
            if (textbox1.Text.Length == 0 ||
                textbox2.Text.Length == 0)
                labNotification.Text = "Chưa nhập username và password!";
            else
                labNotification.Text = "Hệ thống đang bảo trì!";
        }

        
    }
}
