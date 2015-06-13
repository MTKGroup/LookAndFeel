
using LookAndFeel.Components;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LookAndFeel.Forms{
    /**
     * 
     */
    public class DarkForm : Form {

        /**
         * 
         */
        public DarkForm() {
            this.Style = MetroFramework.MetroColorStyle.Black;

            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //cheat window button
            //List<System.Windows.Forms.Button> btns = new List<System.Windows.Forms.Button>();
            
        }

        void b_Invalidated(object sender, System.Windows.Forms.InvalidateEventArgs e)
        {
            var g = ((System.Windows.Forms.Control)sender).CreateGraphics();
            g.Clear(Color.Transparent);
            
        }



        

        /**
         * @return
         */
        public override IComponent clone(ComponentInfo info)
        {
            return new DarkForm();
        }

    }
}

