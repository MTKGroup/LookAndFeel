
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
    public class LightForm : Form {

        /**
         * 
         */
        public LightForm() {
            this.backColor = Color.FromArgb(34, 49, 63);
            this.foreColor = Color.FromArgb(189, 195, 199);
            this.lineColor = Color.FromArgb(89, 171, 227);
        }

        public LightForm(ComponentInfo info) : base(info)
        {
            this.backColor = Color.White;
            this.foreColor = Color.FromArgb(150, 40, 27);
            this.lineColor = Color.FromArgb(217, 30, 24);
        }
        /**
         * @return
         */
        public override IComponent clone(ComponentInfo info)
        {
            return new LightForm(info);
        }

    }
}
