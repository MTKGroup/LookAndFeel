
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
    public abstract class TextBox : MetroFramework.Controls.MetroTextBox, IControl {

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
            return "TextBox";
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
        public abstract IComponent clone(ComponentInfo info);

    }
}
