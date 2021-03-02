using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ControlShaker
{
    public class ControlShaker
    {
        private Point m_OriginalLocation;
        private Random rand = new Random(1337);
        private readonly int r_ShakeAmplitude = 10;

        public void Shake(Control i_ControlToStretch)
        {
            m_OriginalLocation = i_ControlToStretch.Location;

            for (int i = 0; i < 10; i++)
            {
                i_ControlToStretch.Location = new Point(m_OriginalLocation.X + rand.Next(-r_ShakeAmplitude, r_ShakeAmplitude), m_OriginalLocation.Y + rand.Next(-r_ShakeAmplitude, r_ShakeAmplitude));
                System.Threading.Thread.Sleep(20);
            }

            i_ControlToStretch.Location = m_OriginalLocation;
        }
    }
}
