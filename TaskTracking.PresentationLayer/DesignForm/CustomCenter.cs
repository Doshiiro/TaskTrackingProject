using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracking.PresentationLayer.DesignForm
{
    public class CustomCenter
    {
        public void CenterToolLeft(Control includingControl, Control centeredControl)
        {
            centeredControl.Left = (includingControl.Width - centeredControl.Width) / 2;
        }
        public void CenterToolAll(Control includingControl, Control centeredControl)
        {
            centeredControl.Left = (includingControl.Width - centeredControl.Width) / 2;
            centeredControl.Top = (includingControl.Height - centeredControl.Height) / 2;
        }
    }
}