
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
        protected List<ClickHandler> clickHandlers;
        /**
         * 
         */
        public Panel() {
            this.clickHandlers = new List<ClickHandler>();
        }

        public event ClickHandler ClickListener
        {
            add
            {
                this.clickHandlers.Add(value);
            }
            remove
            {
                this.clickHandlers.Remove(value);
            }
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
