using LookAndFeel.Components;
using LookAndFeel.Controls;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LookAndFeel.Controls
{
<<<<<<< HEAD
    public class DarkLabel : Label
    {
        private ComponentInfo info;

=======
    public class DarkLabel : Label, IControl
    {
>>>>>>> origin/nhhoang_new
        public DarkLabel()
        {
            
        }

<<<<<<< HEAD
        public DarkLabel(ComponentInfo info)
        {
            // TODO: Complete member initialization
            this.info.x = info.x;
            this.info.y = info.y;
            this.info.width = info.width;
            this.info.height = info.height;
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkLabel(info);
=======
        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkLabel();
>>>>>>> origin/nhhoang_new

            //set info for newControl
            //....

            return newControl;
        }

<<<<<<< HEAD
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            foreach (var handler in this.clickHandlers)
            {
                handler(this);
            }
        }
=======
>>>>>>> origin/nhhoang_new
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            Font font = new System.Drawing.Font("Arial", 9);
            e.Graphics.Clear(Color.Transparent);
            e.Graphics.DrawString(this.Text, font, Brushes.DarkGray, 0, 0);
<<<<<<< HEAD
=======
            

>>>>>>> origin/nhhoang_new
        }
    }
}
