
using LookAndFeel.Components;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
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
            this.Style = MetroFramework.MetroColorStyle.Blue;
        }
        
        /**
         * @return
         */
        public override IComponent clone(ComponentInfo info)
        {
            return new LightForm();
        }

    }
}
