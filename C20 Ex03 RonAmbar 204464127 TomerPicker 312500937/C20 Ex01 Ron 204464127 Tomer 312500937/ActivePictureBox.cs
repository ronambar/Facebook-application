using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ControlShaker;

namespace C20_Ex01_Ron_204464127_Tomer_312500937
{
    class ActivePictureBox : PictureBox
    {
        private ControlShaker.ControlShaker m_ControlShaker = new ControlShaker.ControlShaker();

        public void Shake()
        {
            m_ControlShaker.Shake(this);
        }
    }
}
