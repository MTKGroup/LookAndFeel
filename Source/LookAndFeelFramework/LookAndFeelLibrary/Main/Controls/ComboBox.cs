using LookAndFeel.Components;
using LookAndFeel.Controls;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndFeel.Controls
{
    public abstract class ComboBox : MetroFramework.Controls.MetroComboBox, IControl
    {
        protected List<ClickHandler> clickHandlers;

        public ComboBox()
        {
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
            return "ComboBox";
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
