using LookAndFeel.Components;
using LookAndFeel.Controls;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndFeel.Controls
{
<<<<<<< HEAD
    public class DarkComboBox : ComboBox
    {
        private ComponentInfo info;

        public DarkComboBox()
        {
        }

        public DarkComboBox(ComponentInfo info)
        {
            // TODO: Complete member initialization
            this.info.x = info.x;
            this.info.y = info.y;
            this.info.width = info.width;
            this.info.height = info.height;
=======
    public class DarkComboBox : ComboBox, IControl
    {
        public DarkComboBox()
        {
            this.ForeColor = Color.DarkGray;
>>>>>>> origin/nhhoang_new
        }

        public override IComponent clone(ComponentInfo info)
        {
<<<<<<< HEAD
            var newControl = new DarkComboBox(info);
=======
            var newControl = new DarkComboBox();
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

<<<<<<< HEAD
            Pen pen = new Pen(Color.DarkGray, 4);

            e.Graphics.DrawRectangle(pen, 0, 0, this.Width, this.Height);
=======
            e.Graphics.DrawRectangle(Pens.DarkGray, 0, 0, this.Width, this.Height);
>>>>>>> origin/nhhoang_new
        }
    }
}
