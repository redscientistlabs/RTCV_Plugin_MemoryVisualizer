using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryVisualizerPlugin.UI
{
    public partial class MemVisAdvancedSettings : Form
    {
        public static int PixelsPerThread { get; private set; } = 256;
        public MemVisAdvancedSettings()
        {
            InitializeComponent();
            PixelsPerThread = (int)nPixPerThread.Value;
        }

        private void nPixPerThread_ValueChanged(object sender, EventArgs e)
        {
            PixelsPerThread = (int)nPixPerThread.Value;
        }
    }
}
