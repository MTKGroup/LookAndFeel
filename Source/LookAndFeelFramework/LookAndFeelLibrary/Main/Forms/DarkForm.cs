
using LookAndFeel.Components;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LookAndFeel.Forms{
    /**
     * 
     */
    public class DarkForm : Form {

        /**
         * 
         */
        public DarkForm() {
            this.Style = MetroFramework.MetroColorStyle.Black;

            
        }

   
   




        

        /**
         * @return
         */
        public override IComponent clone(ComponentInfo info)
        {
            return new DarkForm();
        }

    }
}

