
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
    public abstract class GroupBox : System.Windows.Forms.GroupBox , IControl {
        protected HashSet<IControl> controls;
        protected List<ClickHandler> clickHandlers;
        /**
         * 
         */
        public GroupBox() {
            this.controls = new HashSet<IControl>();
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

        /**
         * @return
         */
        public String getType() {
            return "GroupBox";
        }

        public void addControl(IControl component)
        {
            this.controls.Add(component);
            this.Controls.Add((System.Windows.Forms.Control)component);
        }

    }
}
