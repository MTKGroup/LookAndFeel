using LookAndFeel.Components;
using LookAndFeel.Controls;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Controls
{
    public abstract class Label : MetroFramework.Controls.MetroLabel, IControl
    {
        protected List<ClickHandler> clickHandlers;

        public Label() {
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
        public String getType() {
            return "Label";
        }

        /**
         * @return
         */
        public abstract IComponent clone(ComponentInfo info);

        /**
         * @param f 
         * @return
         */
        public IComponent convert(ComponentFactory f) {
            var info = new ComponentInfo();
            return f.create(this.getType(), info);    
        }
    }
}
