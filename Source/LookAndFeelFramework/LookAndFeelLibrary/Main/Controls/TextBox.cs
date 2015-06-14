
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
        private const int WM_PAINT = 15;
        private const int OCM_COMMAND = 0x2111;

        protected List<ClickHandler> clickHandlers = new List<ClickHandler>();
        private ComponentInfo info;

        /**
         * 
         */
        public TextBox() {
            this.Width = 100;
        }

        public TextBox(ComponentInfo info)
        {
            this.info = info.clone();
            this.Top = info.Y;
            this.Left = info.X;
            this.Name = this.Text = info.Name;
            this.Width = info.Width != 0 ? info.Width : this.Width;
            this.Height = info.Height != 0 ? info.Height : this.Height;
            info.Width = info.Width != 0 ? info.Width : this.Width;
            info.Height = info.Height != 0 ? info.Height : this.Height;

            this.Width = info.Width = this.Width == 0 ? 100 : this.Width;
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

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            Invalidate();
        }
    }
}
