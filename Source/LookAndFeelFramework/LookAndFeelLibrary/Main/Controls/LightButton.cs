
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Controls{
    /**
     * 
     */
    public class LightButton : Button, IControl {

        /**
         * 
         */
        public LightButton() {
        }

        public override Components.IComponent clone(ComponentInfo info)
        {
            return new LightButton();
        }
    }
}
