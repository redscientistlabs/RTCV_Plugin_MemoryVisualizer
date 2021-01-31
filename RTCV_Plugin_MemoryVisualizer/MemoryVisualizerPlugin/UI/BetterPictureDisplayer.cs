using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MemoryVizualizer.UI
{
    internal class BetterPictureDisplayer : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            base.OnPaint(pe);
        }
    }
}
