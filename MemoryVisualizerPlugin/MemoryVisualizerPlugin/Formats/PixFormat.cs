namespace MemoryVisualizerPlugin.Formats
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MemoryVisualizerPlugin.UI;

    public abstract class PixFormat
    {
        public readonly int BytesWide;
        public readonly int Pixels;
        public readonly bool CustomParsing;
        protected PixFormat(int w, int pixels)
        {
            BytesWide = w;
            Pixels = pixels;
            CustomParsing = false;
        }

        protected PixFormat(int w, int pixels, bool customParsing)
        {
            BytesWide = w;
            Pixels = pixels;
            CustomParsing = customParsing;
        }

        public abstract Color Parse(byte[] bytes, int offset);

        public virtual void CustomParse(FastBitmap bitmap, byte[] bts) { }
    }

    public abstract class CustomPixFormat : PixFormat
    {
        protected CustomPixFormat(int w, int pixels = 1) : base(w, pixels, true)
        {
        }
    }

}
