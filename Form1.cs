/*
FourierRocks. Copyright (C) 2007 - Primiano Tucci
This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later version. 

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details. 

You should have received a copy of the GNU General Public License along with this program; if not, write to the Free Software Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA. 

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FourierRocks
{
    public partial class Form1 : Form
    {
        WaveFile file1 = null;
        WaveFile file2 = null;


        public Form1()
        {
            InitializeComponent();

            //dft = f.CalculateDFT(32768);
        }

        private void btBrowse1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "Wav File | *.wav";
                fd.CheckFileExists = true;
                if (fd.ShowDialog() != DialogResult.OK) return;
                file1 = new WaveFile(fd.FileName);
                lbFTitle1.Text = fd.FileName;
                w1.WaveFile = file1;
                w1.Refresh();
                lbInfo1.Text = file1.NSamples + " samples - " + file1.SampleRate + " Hz - " + file1.NChannels +
                               " channels";
                cbChan1.Items.Clear();
                for (int i = 0; i < file1.NChannels; i++)
                    cbChan1.Items.Add(i.ToString());
                cbChan1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file1 = null;
            }

            CheckAnalyzeCanStart();
        }

        private void btBrowse2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "Wav File | *.wav";
                fd.CheckFileExists = true;
                if (fd.ShowDialog() != DialogResult.OK) return;
                file2 = new WaveFile(fd.FileName);
                lbFTitle2.Text = fd.FileName;
                w2.WaveFile = file2;
                w2.Refresh();
                lbInfo2.Text = file2.NSamples + " samples - " + file2.SampleRate + " Hz - " + file2.NChannels +
                               " channels";
                cbChan2.Items.Clear();
                for (int i = 0; i < file2.NChannels; i++)
                    cbChan2.Items.Add(i.ToString());
                cbChan2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file2 = null;
            }

            CheckAnalyzeCanStart();
        }

        void CheckAnalyzeCanStart()
        {
            panAnalyse.Enabled = false;
            if (file1 == null || file2 == null) return;
            panAnalyse.Enabled = true;
        }


        public void DetectBestOverlap(int iInterval, WorkProgress iWP)
        {
            float CrossCorr = 0, BestCrossCorr = 0;
            int bestI = 0;
            lbCurStep.Text = "Detecting best overlap interval";
            float[] data1 = file1.GetData()[cbChan1.SelectedIndex];
            float[] data2 = file2.GetData()[cbChan2.SelectedIndex];
            for (int i = -iInterval; i < iInterval; i++)
            {
                CrossCorr = MathLib.CrossCorrelation(data1, data2, i);
                if (CrossCorr > BestCrossCorr)
                {
                    BestCrossCorr = CrossCorr;
                    bestI = i;
                    lbBestOverlap.Text = i.ToString();
                    lbBestOverlap.Refresh();
                }

                iWP.UpdateProgress(100 * (i + iInterval) / 2 / iInterval);
            }

            if (bestI == 0) return;

            if (bestI > 0)
                file2.SkipFirstSamples((uint) bestI);
            else
                file1.SkipFirstSamples((uint) Math.Abs(bestI));
            lbInfo1.Text = file1.NSamples.ToString() + " samples";
            lbInfo2.Text = file2.NSamples.ToString() + " samples";
            w1.Refresh();
            w2.Refresh();
        }

        public void TrimWaves(int iThr)
        {
            UInt32 m1a, m1b, m2a, m2b;
            lbCurStep.Text = "Trimming Waveforms";
            file1.Trim(iThr * file1.MaxAllowableValue / 100, false, out m1a, out m1b);
            file2.Trim(iThr * file2.MaxAllowableValue / 100, false, out m2a, out m2b);
            lbInfo1.Text = file1.NSamples.ToString() + " samples";
            lbInfo2.Text = file2.NSamples.ToString() + " samples";
            w1.Refresh();
            w2.Refresh();
        }

        public void NormalizeWaves(int iMethod)
        {
            float Peak1, Peak2;
            float ratio1 = 1, ratio2 = 1;
            lbCurStep.Text = "Normalizing Waveforms";
            Peak1 = file1.GetPeakModule();
            Peak2 = file2.GetPeakModule();

            if (Peak1 == Peak2) return;

            if (iMethod == 0) //Raise to highest
            {
                if (Peak1 < Peak2)
                    ratio1 = Peak2 / Peak1;
                else
                    ratio2 = Peak1 / Peak2;
            }
            else if (iMethod == 1)
            {
                //Attenuate to lowest
                if (Peak1 > Peak2)
                    ratio1 = Peak2 / Peak1;
                else
                    ratio2 = Peak1 / Peak2;
            }

            file1.Normalize(ratio1);
            file2.Normalize(ratio2);
            w1.Refresh();
            w2.Refresh();
        }

        public void AnalyzeTime(WorkProgress iWP)
        {
            lbCurStep.Text = "Time Domain Analysis";
            float[] difArr;
            float[] data1 = file1.GetData()[cbChan1.SelectedIndex];
            float[] data2 = file2.GetData()[cbChan2.SelectedIndex];
            iWP.UpdateProgress(0);

            UInt32 len = Math.Min(file1.NSamples, file2.NSamples);

            uint skip = 100;
            UInt32 c = 0;
            difArr = new float[len / skip + 1];
            spTimeDiff.ForceYPeak = 100;


            for (UInt32 i = 0; i < len; i += skip, c++)
            {
                float avg = 0;
                for (UInt32 n = 0; n < skip && i + n < len; n++)
                    avg += Math.Abs(data1[i + n] - data2[i + n]);
                avg /= skip;

                difArr[c] = avg * 100 / file1.MaxAllowableValue;
                if (c % 10 == 0)
                {
                    iWP.UpdateProgress((int) (i * 100 / len));
                    spTimeDiff.FFTData = difArr;
                    spTimeDiff.Refresh();
                }
            }

            spTimeDiff.FFTData = difArr;
            spTimeDiff.Refresh();
            lbAvgErr.Text = Math.Round(MathLib.ArrayAverage(difArr, difArr.Length), 5).ToString();
        }


        public bool AnalyzeBitwise(WorkProgress iWP)
        {
            lbCurStep.Text = "Bitwise Analysis";
            iWP.UpdateProgress(0);
            bool identical = true;
            UInt32 len = Math.Min(file1.NSamples, file2.NSamples);
            float[] data1 = file1.GetData()[cbChan1.SelectedIndex];
            float[] data2 = file2.GetData()[cbChan2.SelectedIndex];


            for (UInt32 i = 0; i < len; i++)
            {
                if (data1[i] != data2[i])
                {
                    identical = false;
                    break;
                    ;
                }
            }

            iWP.UpdateProgress(100);
            return identical;
        }

        public void AnalyzeSpectrum(WorkProgress iWP)
        {
            lbCurStep.Text = "Frequency Domain Analysis";
            iWP.UpdateProgress(0);
            float[] data1 = file1.GetData()[cbChan1.SelectedIndex];
            float[] data2 = file2.GetData()[cbChan2.SelectedIndex];
            float[] globDiffArr = new float[MathLib.FFT_Samples];

            UInt32 pos, steps;

            UInt32 len = Math.Min(file1.NSamples, file2.NSamples);
            UInt32 SkipSum;

            switch (cbFFTQual.SelectedIndex)
            {
                case 0:
                    MathLib.SetQuality(MathLib.FFT_Quality.Low);
                    break;
                case 1:
                    MathLib.SetQuality(MathLib.FFT_Quality.Average);
                    break;
                case 2:
                    MathLib.SetQuality(MathLib.FFT_Quality.Good);
                    break;
                case 3:
                    MathLib.SetQuality(MathLib.FFT_Quality.Best);
                    ;
                    break;
                default:
                    MathLib.SetQuality(MathLib.FFT_Quality.Average);
                    break;
            }


            switch (cbFFTPrecision.SelectedIndex)
            {
                case 0:
                    SkipSum = 1000;
                    break;
                case 1:
                    SkipSum = 500;
                    break;
                case 2:
                    SkipSum = 100;
                    break;
                case 3:
                    SkipSum = 50;
                    break;
                default:
                    SkipSum = 100;
                    break;
            }

            spDiff.OnlyPositive = false;
            spDiff.ForceYPeak = 200;
            spErr.ForceYPeak = 100;
            float[] ErrorArr = new float[(long) Math.Ceiling((decimal) len / SkipSum)];
            for (pos = 0, steps = 0; pos < len - MathLib.FFT_Samples - 1; pos += SkipSum, steps++)
            {
                float[] ft1 = MathLib.FFT(data1, pos);
                float[] ft2 = MathLib.FFT(data2, pos);
                sp1.FFTData = ft1;
                sp2.FFTData = ft2;
                float[] difArr = MathLib.SpectrumAttenuation_dB(ft1, ft2);
                MathLib.ArraySum(ref globDiffArr, difArr);

                float AbsErr = 0;
                for (UInt32 i = 0; i < difArr.Length; i++)
                    AbsErr += Math.Abs(difArr[i]);
                AbsErr /= difArr.Length;
                ErrorArr[steps] = AbsErr;

                spErr.FFTData = ErrorArr;
                spErr.Refresh();

                spDiff.FFTData = difArr;
                spDiff.Refresh();
                if (steps % 10 == 0)
                {
                    iWP.UpdateProgress((int) (pos * 100 / len));
                }
            }

            MathLib.ArrayRatio(ref globDiffArr, steps - 1);
            spDiff.FFTData = globDiffArr;
            spDiff.Refresh();

            lbFreqAvgErr.Text = MathLib.ArrayAverage(ErrorArr, ErrorArr.Length).ToString();
        }


        private void ckTrim_CheckedChanged(object sender, EventArgs e)
        {
            tbTrimThres.Enabled = ckTrim.Checked;
        }

        private void ckNormalize_CheckedChanged(object sender, EventArgs e)
        {
            cbNormType.Enabled = ckNormalize.Checked;
        }

        private void ckOverlap_CheckedChanged(object sender, EventArgs e)
        {
            tbOverlapSamples.Enabled = ckOverlap.Checked;
        }

        private void btAnalyse_Click(object sender, EventArgs e)
        {
            WorkProgress wp = new WorkProgress();
            wp.PBar = pbProg;
            if (ckTrim.Checked)
                TrimWaves((int) tbTrimThres.Value);
            if (ckNormalize.Checked && cbNormType.SelectedIndex >= 0)
                NormalizeWaves(cbNormType.SelectedIndex);
            if (ckOverlap.Checked)
                DetectBestOverlap((int) tbOverlapSamples.Value, wp);
/*            if (AnalyzeBitwise(wp))
            {
                MessageBox.Show("Compared samples are BITWISE IDENTICAL\nNo more analysis needed", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/
            AnalyzeTime(wp);
            AnalyzeSpectrum(wp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbNormType.SelectedIndex = 0;
            cbFFTQual.SelectedIndex = 2;
            cbFFTPrecision.SelectedIndex = 2;
        }
    }
}
