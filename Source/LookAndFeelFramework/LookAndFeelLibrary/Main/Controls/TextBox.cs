
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
    public class TextBox : MetroFramework.Controls.MetroTextBox, IControl {

        /**
         * 
         */
        public TextBox() {
        }

        /**
         * @return
         */
        public String getType() {
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
        public IComponent clone(ComponentInfo info)
        {
            // TODO implement here
            return null;
        }

    }
}
