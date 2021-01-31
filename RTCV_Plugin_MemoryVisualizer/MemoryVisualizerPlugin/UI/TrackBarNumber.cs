using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryVizualizer.UI
{
    public partial class TrackBarNumber : UserControl
    {
        //public bool FirstLoadDone = false;

        //private long _Minimum = 0;
        //[Description("Minimum value of the control"), Category("Data")]
        //public long Minimum
        //{
        //    get => _Minimum;
        //    set
        //    {
        //        _Minimum = value;
        //        nmControlValue.Minimum = value;
        //        tbControlValue.Minimum = Convert.ToInt32(value);
        //        if (FirstLoadDone)
        //        {
        //            tbControlValue_ValueChanged(null, null);
        //        }
        //    }
        //}
        //private long _Maximum = 65535;
        //[Description("Maximum value of the control"), Category("Data")]
        //public long Maximum
        //{
        //    get => _Maximum;
        //    set
        //    {
        //        _Maximum = value;
        //        if (FirstLoadDone)
        //        {
        //            tbControlValue_ValueChanged(null, null);
        //        }
        //    }
        //}

        //private string name = "Name";
        //[Description("Displayed label of the control"), Category("Data")]
        //public string Label
        //{
        //    get => name;
        //    set
        //    {
        //        name = value;
        //        lbControlName.Text = value;
        //    }
        //}

        public TrackBarNumber()
        {
            InitializeComponent();
        }

        private void TrackBarNumber_Load(object sender, EventArgs e)
        {
            //FirstLoadDone = true;
        }
    }
}
