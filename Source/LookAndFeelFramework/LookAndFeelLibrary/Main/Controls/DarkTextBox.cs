﻿using LookAndFeel.Components;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndFeel.Controls
{
    public class DarkTextBox : TextBox
    {
        public DarkTextBox()
        {
            this.Width = 100;
            this.ForeColor = Color.DarkGray;
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkTextBox();

            //set info for newControl
            //....

            return newControl;
        }

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

            

            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point( 18, 7), Color.Blue);
            Pen pen = new Pen(Color.DarkGray, 4);
            e.Graphics.DrawRectangle(pen, 0, 0, this.Width, this.Height);
        }


        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            //this.ForeColor = Color.DarkGray;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            this.ForeColor = Color.DarkGray;
        }
    }
}
