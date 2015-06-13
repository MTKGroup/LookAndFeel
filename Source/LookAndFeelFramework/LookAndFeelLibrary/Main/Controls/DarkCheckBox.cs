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
    public class DarkCheckBox : CheckBox
    {
        private ComponentInfo info;

=======
    public class DarkCheckBox : CheckBox, IControl
    {
>>>>>>> origin/nhhoang_new

        public DarkCheckBox()
        {
            
        }

<<<<<<< HEAD
        public DarkCheckBox(ComponentInfo info)
        {
            // TODO: Complete member initialization
            this.info.x = info.x;
            this.info.y = info.y;
            this.info.width = info.width;
            this.info.height = info.height;
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkCheckBox(info);
=======
        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkCheckBox();
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

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);
            e.Graphics.FillRectangle(Brushes.White, 0, 0, this.Width, this.Height);
            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point( 18, (int)(this.Height/2 - textSize.Height/2)), Color.DarkGray);

            e.Graphics.DrawRectangle(Pens.Black, 0, this.Height/4, this.Height/2, this.Height/2);
            if (this.Checked)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray,
                                            (int)(this.Height / 4 * 0.4),
                                            (int)(this.Height / 4 *1.4),
                                            (int)(this.Height / 2 * 0.8),
                                            (int)(this.Height / 2 * 0.8));
            }
=======
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(Brushes.White, 19, 0, this.Width - 19, this.Height);
            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point( 18, 7), Color.DarkGray);
>>>>>>> origin/nhhoang_new
        }
    }
}
