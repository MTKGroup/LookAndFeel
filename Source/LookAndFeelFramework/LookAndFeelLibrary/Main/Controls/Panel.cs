
using LookAndFeel.Components;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Controls{
    /**
     * 
     */
    public class Panel : MetroFramework.Controls.MetroPanel, IControl {

        /**
         * 
         */
        public Panel() {
        }


        /**
         * @return
         */
        public IComponent clone(ComponentInfo info)
        {
            // TODO implement here
            return null;
        }

        /**
         * @param f 
         * @return
         */
        public IComponent convert(ComponentFactory f) {
            // TODO implement here
            return null;
        }

        /**
         * @return
         */
        public String getType() {
            return "Panel";
        }

    }
}
