namespace MemoryVizualizer.Formats
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;
    using MemoryVizualizer.UI;

    internal static class PixFormats
    {
        static Dictionary<string, PixFormat> Formats = new Dictionary<string, PixFormat>();
        static PixFormats()
        {
            AddNew("I8", new PixI8());
            AddNew("IA16", new PixIA16());
            AddNew("AI16", new PixAI16());

            AddNew("RGBA5551 (N64 Textures)", new PixRGBA5551());
            AddNew("BGRA5551", new PixBGRA5551());
            AddNew("ARGB1555", new PixARGB1555());
            AddNew("ABGR1555", new PixABGR1555());
            AddNew("RGBA4444", new PixRGBA4444());
            AddNew("ARGB4444", new PixARGB4444());

            AddNew("YCbYCr (GameCube XFB)", new PixYCbYCr());
            AddNew("RGBA32", new PixRGBA32());
            AddNew("Flat RGBA32", new PixFlatRGBA32());
            AddNew("ARGB32", new PixARGB32());
            AddNew("Flat ARGB32", new PixFlatARGB32());
            //Lesser known
            AddNew("RGB565", new PixRGB565());
            AddNew("RGB5A3", new PixRGB5A3());
            AddNew("RGB24", new PixRGB24());
            AddNew("BGR24", new PixBGR24());
            AddNew("RGB101010", new PixRGB101010());
            AddNew("BGR101010", new PixBGR101010());
        }

        static void AddNew(string Name, PixFormat px)
        {
            Formats[Name] = px;
        }


        public static PixFormat Get(string format)
        {
            return Formats[format];
        }

        public static string[] GetNames()
        {
            List<string> keyList = new List<string>(Formats.Keys);
            return keyList.ToArray();
        }
    }

    public class PixI8 : PixFormat
    {
        public PixI8() : base(1, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            var bc = bytes[offset];
            return Color.FromArgb(255, bc, bc, bc);
        }
    }

    public class PixIA16 : PixFormat
    {
        public PixIA16() : base(2, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            var ba = bytes[offset + 1];
            var bc = bytes[offset];
            return Color.FromArgb(ba, bc, bc, bc);
        }
    }

    public class PixAI16 : PixFormat
    {
        public PixAI16() : base(2, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            var ba = bytes[offset];
            var bc = bytes[offset + 1];
            return Color.FromArgb(ba, bc, bc, bc);
        }
    }

    public class PixARGB1555 : PixFormat
    {
        public PixARGB1555() : base(2, 1) { }
        const int c5 = 0x8;

        const int am = 0b1000000000000000;
        const int rm = 0b0111110000000000;
        const int gm = 0b0000001111100000;
        const int bm = 0b0000000000011111;

        const int rs = 10;
        const int gs = 5;
        //const int rs = 11;

        public override Color Parse(byte[] bytes, int offset)
        {
            int dat = (int)BitConverter.ToUInt16(bytes, offset);
            int r = ((dat & rm) >> rs) * c5;
            int g = ((dat & gm) >> gs) * c5;
            int b = (dat & bm) * c5;

            return Color.FromArgb((((dat & am) > 0) ? 255 : 0), r, g, b);
        }
    }

    public class PixABGR1555 : PixFormat
    {
        public PixABGR1555() : base(2, 1) { }
        const int c5 = 0x8;

        const int am = 0b1000000000000000;
        const int rm = 0b0000000000011111;
        const int gm = 0b0000001111100000;
        const int bm = 0b0111110000000000;

        const int bs = 10;
        const int gs = 5;
        //const int rs = 11;

        public override Color Parse(byte[] bytes, int offset)
        {
            int dat = (int)BitConverter.ToUInt16(bytes, offset);
            int r = (dat & rm) * c5;
            int g = ((dat & gm) >> gs) * c5;
            int b = ((dat & bm) >> bs) * c5;

            return Color.FromArgb((((dat & am) > 0) ? 255 : 0), r, g, b);
        }
    }

    public class PixRGBA5551 : PixFormat
    {
        public PixRGBA5551() : base(2, 1) { }
        const int c5 = 0x8;

        const int am = 0b0000000000000001;
        const int rm = 0b1111100000000000;
        const int gm = 0b0000011111000000;
        const int bm = 0b0000000000111110;

        const int rs = 11;
        const int gs = 6;
        const int bs = 1;
        //const int rs = 11;

        public override Color Parse(byte[] bytes, int offset)
        {
            int dat = (int)BitConverter.ToUInt16(bytes, offset);
            int r = ((dat & rm) >> rs) * c5;
            int g = ((dat & gm) >> gs) * c5;
            int b = ((dat & bm) >> bs) * c5;
            return Color.FromArgb((((dat & am) > 0) ? 255 : 0), r, g, b);
        }
    }

    public class PixBGRA5551 : PixFormat
    {
        public PixBGRA5551() : base(2, 1) { }
        const int c5 = 0x8;

        const int am = 0b0000000000000001;
        const int bm = 0b1111100000000000;
        const int gm = 0b0000011111000000;
        const int rm = 0b0000000000111110;

        const int bs = 11;
        const int gs = 6;
        const int rs = 1;
        //const int rs = 11;

        public override Color Parse(byte[] bytes, int offset)
        {
            int dat = (int)BitConverter.ToUInt16(bytes, offset);
            int r = ((dat & rm) >> rs) * c5;
            int g = ((dat & gm) >> gs) * c5;
            int b = ((dat & bm) >> bs) * c5;
            return Color.FromArgb((((dat & am) > 0) ? 255 : 0), r, g, b);
        }
    }


    public class PixARGB4444 : PixFormat
    {
        public PixARGB4444() : base(2, 1) { }
        const int c4 = 0x11;

        const int am = 0b1111000000000000;
        const int rm = 0b0000111100000000;
        const int gm = 0b0000000011110000;
        const int bm = 0b0000000000001111;

        const int als = 12;
        const int rs = 8;
        const int gs = 4;
        //const int rs = 11;

        public override Color Parse(byte[] bytes, int offset)
        {
            int dat = (int)BitConverter.ToUInt16(bytes, offset);
            int a = ((dat & am) >> als) * c4;
            int r = ((dat & rm) >> rs) * c4;
            int g = ((dat & gm) >> gs) * c4;
            int b = (dat & bm) * c4;

            return Color.FromArgb(a, r, g, b);
        }
    }

    public class PixRGBA4444 : PixFormat
    {
        public PixRGBA4444() : base(2, 1) { }
        const int c4 = 0x11;

        const int rm = 0b1111000000000000;
        const int gm = 0b0000111100000000;
        const int bm = 0b0000000011110000;
        const int am = 0b0000000000001111;

        const int rs = 12;
        const int gs = 8;
        const int bs = 4;
        //const int rs = 11;

        public override Color Parse(byte[] bytes, int offset)
        {
            int dat = (int)BitConverter.ToUInt16(bytes, offset);
            int a = (dat & am) * c4;
            int r = ((dat & rm) >> rs) * c4;
            int g = ((dat & gm) >> gs) * c4;
            int b = ((dat & bm) >> bs) * c4;

            return Color.FromArgb(a, r, g, b);
        }
    }

    public class PixRGB24 : PixFormat
    {
        public PixRGB24() : base(3, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            return Color.FromArgb(255, bytes[offset], bytes[offset + 1], bytes[offset + 2]);
        }
    }

    public class PixBGR24 : PixFormat
    {
        public PixBGR24() : base(3, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            return Color.FromArgb(255, bytes[offset + 2], bytes[offset + 1], bytes[offset]);
        }
    }
    public class PixARGB32 : PixFormat
    {
        public PixARGB32() : base(4, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            return Color.FromArgb(bytes[offset], bytes[offset + 1], bytes[offset + 2], bytes[offset + 3]);
        }
    }
    public class PixFlatARGB32 : PixFormat
    {
        public PixFlatARGB32() : base(4, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            return Color.FromArgb(255, bytes[offset + 1], bytes[offset + 2], bytes[offset + 3]);
        }
    }


    public class PixRGBA32 : PixFormat
    {
        public PixRGBA32() : base(4, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            return Color.FromArgb(bytes[offset + 3], bytes[offset], bytes[offset + 1], bytes[offset + 2]);
        }
    }

    public class PixFlatRGBA32 : PixFormat
    {
        public PixFlatRGBA32() : base(4, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            return Color.FromArgb(255, bytes[offset], bytes[offset + 1], bytes[offset + 2]);
        }
    }

    public class PixRGB565 : PixFormat
    {
        public PixRGB565() : base(2, 1) { }
        const int c5 = 0x8;
        const int c6 = 0x4;

        const int rm = 0b1111100000000000;
        const int gm = 0b0000011111100000;
        const int bm = 0b0000000000011111;

        const int rs = 11;
        const int gs = 5;
        //const int rs = 11;

        public override Color Parse(byte[] bytes, int offset)
        {
            int dat = (int)BitConverter.ToUInt16(bytes, offset);
            int r = ((dat & rm) >> rs) * c5;
            int g = ((dat & gm) >> gs) * c6;
            int b = (dat & bm) * c5;

            return Color.FromArgb(0xFF, r, g, b);
        }
    }

    public class PixRGB5A3 : PixFormat
    {
        public PixRGB5A3() : base(2, 1) { }
        //coefficients
        const int cA = 0x20;
        const int cC0 = 0x11;
        const int cC1 = 0x8;

        const int mMsk = 0b1000000000000000;

        //Mode alpha
        const int am0 = 0b0111000000000000;
        const int rm0 = 0b0000111100000000;
        const int gm0 = 0b0000000011110000;
        const int bm0 = 0b0000000000001111;
        const int as0 = 12;
        const int rs0 = 8;
        const int gs0 = 4;

        //Mode no alpha
        const int rm1 = 0b0111110000000000;
        const int gm1 = 0b0000001111100000;
        const int bm1 = 0b0000000000011111;
        const int rs1 = 10;
        const int gs1 = 5;
        //const int rs = 11;

        public override Color Parse(byte[] bytes, int offset)
        {
            int dat = (int)BitConverter.ToUInt16(bytes, offset);
            if ((dat & mMsk) > 0)
            {
                //Alpha mode
                var a = ((dat & am0) >> as0) * cA;
                var r = ((dat & rm0) >> rs0) * cC0;
                var g = ((dat & gm0) >> gs0) * cC0;
                int b = (dat & bm0) * cC0;
                return Color.FromArgb(a, r, g, b);
            }
            else
            {
                //No alpha
                var r = ((dat & rm1) >> rs1) * cC1;
                var g = ((dat & gm1) >> gs1) * cC1;
                int b = (dat & bm1) * cC1;
                return Color.FromArgb(0xFF, r, g, b);
            }
        }
    }

    //Work from KSHDO, used with permission https://github.com/ksHDO
    public class PixYCbYCr : CustomPixFormat
    {
        public PixYCbYCr() : base(4, 2) { }

        public override Color Parse(byte[] bytes, int offset)
        {
            //Unused
            return Color.Magenta;
        }

        public override void CustomParse(FastBitmap bitmap, byte[] bts)
        {
            int width = bitmap.Width;

            int pw = BytesWide;
            var len = bts.Length;
            int curOffset = 0;

            for (int i = 0; i < bitmap.Height * width; i += 2)
            {
                if (curOffset + pw > len)
                {
                    return;
                }

                byte Y1 = bts[curOffset];
                byte cb = bts[curOffset + 1];
                byte Y2 = bts[curOffset + 2];
                byte cr = bts[curOffset + 3];

                var rp = 1.371 * (cr - 128.0);
                var gp = 0.698 * (cr - 128.0) - 0.336 * (cb - 128.0);
                var bp = 1.732 * (cb - 128.0);

                bitmap.SetPixel(i, new ColorARGB((byte)255, (byte)(Y1 + rp), (byte)(Y1 - gp), (byte)(Y1 + bp)));
                bitmap.SetPixel(i + 1, new ColorARGB((byte)255, (byte)(Y2 + rp), (byte)(Y2 - gp), (byte)(Y2 + bp)));

                curOffset += pw;
            }
        }
    }

    public class PixBGR101010 : PixFormat
    {
        public PixBGR101010() : base(4, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            var val = BitConverter.ToUInt32(bytes, offset);
            const int mask = 0b1111111111;

            return Color.FromArgb(255, (int)(((double)(val & mask) / 1023) * 255), (int)(((double)((val >> 10) & mask) / 1023) * 255), (int)(((double)((val >> 20) & mask) / 1023) * 255));
        }
    }

    public class PixRGB101010 : PixFormat
    {
        public PixRGB101010() : base(4, 1) { }
        public override Color Parse(byte[] bytes, int offset)
        {
            var val = BitConverter.ToUInt32(bytes, offset);
            const int mask = 0b1111111111;
            return Color.FromArgb(255, (int)(((double)((val >> 20) & mask) / 1023) * 255), (int)(((double)((val >> 10) & mask) / 1023) * 255), (int)(((double)(val & mask) / 1023) * 255));
        }
    }

}
