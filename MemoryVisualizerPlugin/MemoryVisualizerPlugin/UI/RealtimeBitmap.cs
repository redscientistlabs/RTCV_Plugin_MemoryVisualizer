namespace MemoryVisualizerPlugin.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.Design.Serialization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Forms;
    using System.Drawing;
    using MemoryVisualizerPlugin.Formats;
    public partial class RealtimeBitmap : UserControl
    {
        public FastBitmap bitmap = null;
        public PixFormat curFormat = null;
        public int W = 256;
        public int H = 256;

        public RealtimeBitmap()
        {
            InitializeComponent();
            bitmap = new FastBitmap(W, H);
            disp.Image = bitmap.Bitmap;
        }

        public void SetSize(int w, int h)
        {
            var oldBmp = bitmap;
            bitmap = new FastBitmap(w, h);
            disp.Image = bitmap.Bitmap;
            W = w;
            H = h;
            oldBmp.Dispose();
        }

        public void SetBytes(byte[] bytes)
        {
            //disp.Visible = false;
            SetPixels(bytes);
            //disp.Visible = true;
        }

        //protected override di

        //Does not refresh
        private void SetPixels(byte[] bts)
        {
            int pw = curFormat.BytesWide;
            int mx = bts.Length;
            int curOffset = 0;

            if (!curFormat.CustomParsing)
            {
                for (int y = 0; y < H; y++)
                {
                    for (int x = 0; x < W; x++)
                    {
                        if (curOffset + pw > mx)
                        {
                            //Missing textures yay
                            if ((y / 4) % 2 == 0)
                            {
                                if ((x / 4) % 2 == 0) bitmap.SetPixel(x, y, Color.Magenta);
                                else bitmap.SetPixel(x, y, Color.Black);
                            }
                            else
                            {
                                if ((x / 4) % 2 == 0) bitmap.SetPixel(x, y, Color.Black);
                                else bitmap.SetPixel(x, y, Color.Magenta);
                            }
                            //return;
                        }
                        else
                        {
                            bitmap.SetPixel(x, y, curFormat.Parse(bts, curOffset));
                            curOffset += pw;
                        }
                    }
                }
            }
            else
            {


                if (W % curFormat.Pixels != 0) return;
                curFormat.CustomParse(bitmap, bts);

                //for (int y = 0; y < bitmap.Height; y++)
                //{
                //    for (int x = 0; x < bitmap.Width;)
                //    {
                //        if (curOffset + pw > mx)
                //        {
                //            if ((y / 4) % 2 == 0)
                //            {
                //                if ((x / 4) % 2 == 0) bitmap.SetPixel(x, y, Color.Magenta);
                //                else bitmap.SetPixel(x, y, Color.Black);
                //            }
                //            else
                //            {
                //                if ((x / 4) % 2 == 0) bitmap.SetPixel(x, y, Color.Black);
                //                else bitmap.SetPixel(x, y, Color.Magenta);
                //            }
                //            x++;
                //        }
                //        else
                //        {
                //            var px = curFormat.ParseMultiple(bts, curOffset);

                //            for (int j = 0; j < curFormat.Pixels; j++)
                //            {
                //                bitmap.SetPixel(x + j, y, px[j]);
                //            }
                //            curOffset += pw * curFormat.Pixels;
                //            x += curFormat.Pixels;
                //        }
                //    }
                //}
            }
        }
    }
}
