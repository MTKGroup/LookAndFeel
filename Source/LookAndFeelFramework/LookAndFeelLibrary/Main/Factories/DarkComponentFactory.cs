
using LookAndFeel.Controls;
using LookAndFeel.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Factories{
    /**
     * 
     */
    public class DarkComponentFactory : ComponentFactory {


        /**
         * You need add component  samples  in here
         */
        public DarkComponentFactory() {
            this.samples.Add(new DarkButton());
            this.samples.Add(new DarkForm());
        }

    }
}
