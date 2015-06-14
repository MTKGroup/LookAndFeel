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
    public abstract class CheckBox : MetroFramework.Controls.MetroCheckBox, IControl
    {
        protected List<ClickHandler> clickHandlers = new List<ClickHandler>();
        protected ComponentInfo info;
        protected bool isPressed;
        protected bool isHovered;

        public CheckBox()
        {
        }

        public CheckBox(ComponentInfo info)
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
            return "CheckBox";
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


        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isPressed = true;
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isPressed = false;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
        }
    }
}
