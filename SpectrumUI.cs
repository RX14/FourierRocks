using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace FourierRocks
{

    public partial class SpectrumUI : UserControl
    {
        private float[] _data;

        public float[] FFTData
        {
            get { return _data; }
            set { _data = value; Refresh(); }
        }
        public float ForceYPeak = 0;
        public float LastPeak = 0;
        public bool OnlyPositive = true;
        /*
        private WaveFile _file=null;
        private UInt32 _offset = 0;

        public UInt32 Offset
        {
            get { return _offset; }
            set { _offset = value; }
        }

        public WaveFile WaveFile
        {
            get { return _file; }
            set { _file = value; }
        }*/

        public SpectrumUI()
        {
            InitializeComponent();
        }

        private void SpectrumUI_Paint(object sender, PaintEventArgs e)
        {
            if (_data== null) return;
            float peak = MathLib.FindAbsPeak(_data);
            if (ForceYPeak > 0) peak = ForceYPeak;
            else
                LastPeak = peak;
            long bufSize = _data.Length;
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
        
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;


            if(OnlyPositive)
                g.TranslateTransform(0, Height - 8);
            else
                g.TranslateTransform(0, Height/2 - 8);
            g.ScaleTransform((float)Width / bufSize, -Height / peak );
            
            PointF[] arr = new PointF[bufSize+2];
            for (int i = 0; i < bufSize; i++)
            {
                arr[i+1]=new PointF(i, _data[i]);
            }
            arr[0] = new PointF(0, 0);
            arr[bufSize + 1] = new PointF(bufSize, 0);
            //e.Graphics.DrawCurve(Pens.Blue, arr);
            System.Drawing.Drawing2D.LinearGradientBrush b = new System.Drawing.Drawing2D.LinearGradientBrush(new PointF(0, 0) ,new PointF(0, MathLib.FindAbsPeak(_data)) ,Color.Orange, Color.Yellow);
            g.DrawLines(Pens.Red, arr);
            g.FillPolygon(b, arr);
            
            g.ResetTransform();

        }
    }
}
