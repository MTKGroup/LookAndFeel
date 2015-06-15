
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
            this.backColor = Color.FromArgb(255, 34, 49, 63);
            this.foreColor = Color.FromArgb(189, 195, 199);
            this.lineColor = Color.FromArgb(89, 171, 227);
            
        }

        public DarkForm(ComponentInfo info)
            : base(info)
        {
            this.backColor = Color.FromArgb(255, 34, 49, 63);
            this.foreColor = Color.FromArgb(189, 195, 199);
            this.lineColor = Color.FromArgb(89, 171, 227);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            //cheat window button
            //List<System.Windows.Forms.Button> btns = new List<System.Windows.Forms.Button>();
            
        }     

        /**
         * @return
         */
        public override IComponent clone(ComponentInfo info)
        {
            return new DarkForm(info);
        }

    }
}

