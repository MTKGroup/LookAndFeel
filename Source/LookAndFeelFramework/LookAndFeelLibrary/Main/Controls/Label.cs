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
        protected List<ClickHandler> clickHandlers = new List<ClickHandler>();
        protected ComponentInfo info;

        public Label() {
        }

        public Label(ComponentInfo info)
        {
            this.info = info.clone();
            this.Top = info.Y;
            this.Left = info.X;
            this.Name = this.Text = info.Name;
            this.Width = info.Width != 0 ? info.Width : this.Width;
            this.Height = info.Height != 0 ? info.Height : this.Height;
            info.Width = info.Width != 0 ? info.Width : this.Width;
            info.Height = info.Height != 0 ? info.Height : this.Height;
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
