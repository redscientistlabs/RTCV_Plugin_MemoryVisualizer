using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace MemoryVisualizerPlugin.UI
{
    //Made by KSHDO, used with permission https://github.com/ksHDO
    public class FastBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        public Int32[] Bits;
        public int Width { get; private set; }
        public int Height { get; private set; }

        private GCHandle BitHandle;
        public bool Disposed { get; private set; } = false;

        public FastBitmap(int width, int height)
        {
            Width = width;
            Height = height;

            Bits = new int[width * height];
            BitHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppArgb, BitHandle.AddrOfPinnedObject());
        }

        public void SetPixel(int index, Color color)
        {
            Bits[index] = color.ToArgb();
        }

        public void SetPixel(int index, int color)
        {
            Bits[index] = color;
        }

        public void SetPixel(int index, ColorARGB color)
        {
            Bits[index] = color;
        }

        public void SetPixel(int x, int y, ColorARGB color)
        {
            int i = x + (y * Width);
            Bits[i] = color;
        }

        public void SetPixel(int x, int y, Color color)
        {
            int i = x + (y * Width);
            Bits[i] = color.ToArgb();
        }

        public void SetPixel(int x, int y, int color)
        {
            int i = x + (y * Width);
            Bits[i] = color;
        }

        public Color GetPixel(int x, int y)
        {
            int i = x + (y * Width);
            return Color.FromArgb(Bits[i]);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dispose)
        {
            if (Disposed)
                return;

            if (dispose)
            {
                Bitmap.Dispose();
                BitHandle.Free();
            }

            Disposed = true;
        }
    }

    //From KSHDO, used with permission https://github.com/ksHDO
    public struct ColorARGB
    {
        private int Value;

        public ColorARGB(int argb)
        {
            Value = argb;
        }

        public ColorARGB(byte alpha, byte red, byte green, byte blue)
        {
            Value = (alpha << 24) | (red << 16) | (green << 8) | (blue);
        }

        public ColorARGB(int alpha, int red, int green, int blue) : this((byte)alpha, (byte)red, (byte)green, (byte)blue)
        {

        }

        public static implicit operator int(ColorARGB color)
        {
            return color.Value;
        }
    }

}
