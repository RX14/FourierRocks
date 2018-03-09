using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace FourierRocks
{
    public partial class WaveUI : UserControl
    {
        private WaveFile _file=null;
        private const int ChanMargin = 10;
        private const int XCompr = 6;

        public UInt32 XMark1 = 0;
        public UInt32 XMark2 = 0;

        public float YMark1 = 0;
        public float YMark2 = 0;

        public UInt32 HighlihtX = 0;

        public WaveFile WaveFile
        {
            get { return _file; }
            set { _file = value; }
        }

        public WaveUI()
        {
            InitializeComponent();
        }

        private void WaveUI_Paint(object sender, PaintEventArgs e)
        {
            if (_file == null) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            g.Clear(BackColor);
            int c=0;
            int x=0;
            UInt32 pos;
            float[][] data = _file.GetData();
            uint xRatio = (uint)(_file.NSamples / Width) / XCompr;

            float yRatio = (Height /_file.NChannels - ChanMargin ) / _file.MaxAllowableValue;
            
            for (c = 0; c < _file.NChannels; c++)
            { //Foreach channel
                g.TranslateTransform(0, Height / _file.NChannels * c + (Height / _file.NChannels /2)+ ChanMargin / 2);
                g.ScaleTransform((float)Width / _file.NSamples, yRatio);
                PointF[] pArr = new PointF[_file.NSamples / xRatio+1];
                for (pos = 0, x=0; pos < _file.NSamples; pos += xRatio, x++)
                {
                    pArr[x] = new PointF(pos , data[c][pos]);
                }

                g.DrawCurve(Pens.Green, pArr);
                if (XMark1>0)
                {
                    g.DrawLine(Pens.Red, XMark1, -_file.MaxAllowableValue, XMark1, _file.MaxAllowableValue);
                }
                if (XMark2 > 0)
                {
                    g.DrawLine(Pens.Red, XMark2, -_file.MaxAllowableValue, XMark2, _file.MaxAllowableValue);
                }
                if (YMark1 > 0)
                {
                    g.DrawLine(Pens.Red, 0, YMark1, _file.NSamples, YMark1);
                }
                if (YMark2 > 0)
                {
                    g.DrawLine(Pens.Red, 0, YMark2, _file.NSamples, YMark2);
                }
                if (HighlihtX > 0)
                {
                    g.FillRectangle(Brushes.Green, HighlihtX, -_file.MaxAllowableValue, 100, _file.MaxAllowableValue * 2);
                }


                
                g.ResetTransform();
            }
        }
    }
}
