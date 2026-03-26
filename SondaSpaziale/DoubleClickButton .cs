using System;
using System.Collections.Generic;
using System.Text;

namespace SondaSpaziale
{
    public class DoubleClickButton : Button
    {
        public DoubleClickButton()
        {
            this.SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }
    }
}
