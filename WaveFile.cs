
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace FourierRocks
{
    public class WaveFile 
    {
        
        String _path;
        int _nChannels = 0;
        int _sampleRate = 0;
        int _bps = 0;
        UInt32 _nSamples = 0;
        float _duration = 0;
        int _ChanBlock = 0;
        BinaryReader bI;
        
        float[][] _data;
        UInt32 _startMarker;
        UInt32 _endMarker;

        public readonly decimal T;

        public float MaxAllowableValue
        {
            get { return Int16.MaxValue; }
        }

        public float[][]  GetData()
        {
            float[][] outArr = new float[_nChannels][];


            for (int c = 0; c < _nChannels; c++)
            {
                outArr[c] = new float[NSamples];
                for (UInt32 pos = _startMarker; pos < _endMarker; pos++)
                    outArr[c][pos - _startMarker] = _data[c][pos];
            }
            return outArr;
        }

        public float Duration
        {
            get { return _duration; }
        }

        public int NChannels
        {
            get { return _nChannels; }
        }

        public int SampleRate
        {
            get { return _sampleRate; }
        }

        public int BPS
        {
            get { return _bps; }
        }

        public UInt32 NSamples
        {
            get { return _endMarker-_startMarker; }
        }

        public long FilePos
        {
            get
            {
                return bI.BaseStream.Position;
            }
        }

        public void SkipFirstSamples(UInt32 iNSamples)
        {
            if ((_startMarker+ iNSamples) >= _nSamples)
                throw new ArgumentOutOfRangeException();
            _startMarker += iNSamples;
        }

        public WaveFile(String iFile)
        {
            _path = iFile;
            bI = new BinaryReader(new FileStream(iFile, FileMode.Open));
            char[] introChars = bI.ReadChars(4);


            
            if (new String(introChars)!="RIFF")
                throw new ArgumentException("Invalid wave file");
            UInt32 ChunkSize = bI.ReadUInt32();
            introChars = bI.ReadChars(4);
            if (new String(introChars) != "WAVE")
                throw new ArgumentException("Invalid wave file");
            bI.BaseStream.Seek(8, SeekOrigin.Current);
            if(bI.ReadInt16()!=1)
                throw new ArgumentException("Invalid wave file (not PCM format)");
            _nChannels = bI.ReadInt16();
            _sampleRate = bI.ReadInt32();
            bI.BaseStream.Seek(4, SeekOrigin.Current);
            _ChanBlock = bI.ReadUInt16()/ _nChannels;
            _bps = bI.ReadInt16();
            if(_bps!=16)
                throw new ArgumentException("Invalid wave file (Only 16bit PCM supported)");
             introChars = bI.ReadChars(4);
            if (new String(introChars) != "data")
                throw new ArgumentException("Invalid wave file (can't find data section)");
            UInt32 S2Size = bI.ReadUInt32();
            
            _nSamples = (UInt32) (S2Size * 8 / _nChannels / _bps );
            _startMarker = 0;
            _endMarker = _nSamples;
            _duration = (float)_nSamples / _sampleRate;
            T = (decimal)(Math.PI * 2 / _nSamples);
            
            _data=new float[_nChannels][];
            for(int i=0;i<_nChannels;i++)
                _data[i] = new float[_nSamples];
            
            Int16 l,r;
            for (UInt32 i = 0; i < _nSamples; i++)
            {
                for (int c = 0; c < _nChannels; c++)
                    _data[c][i] = bI.ReadInt16();
/*
                ReadSample16(out l, out r);

                if(_nChannels==1)

                _data[0][i]=l;
                _data[1][i]=r;*/
            }
            bI.Close();
        }

        /*
        void ReadSample16(out Int16 oC1, out Int16 oC2)
        {
            oC1 = bI.ReadInt16();
            oC2 = bI.ReadInt16();
        }

        void ReadSample16Mono(out Int16 oC1)
        {
            oC1 = bI.ReadInt16();
        }


        void ReadSample32(out Int32 oC1, out Int32 oC2)
        {
            oC1 = bI.ReadInt32();
            oC2 = bI.ReadInt32();
        }

        void ReadSample32Mono(out Int32 oC1)
        {
            oC1 = bI.ReadInt32();
        }
        */
        
        void ResetPosition()
        {
            bI.BaseStream.Seek(44, SeekOrigin.Begin);
        }

        public void Trim(float iMaxVal, bool iPreview,out UInt32 oStartMarker, out UInt32 oEndMarker)
        {
            UInt32 pos = 0;
            bool mFound = false;
            for (pos = 0; pos < _nSamples && !mFound; pos++)
            {
                for (int c = 0; c < _nChannels; c++)
                    if (_data[c][pos] > iMaxVal) mFound=true ;
            }
            oStartMarker = pos;

            mFound = false;
            for (pos = _nSamples-1; pos >0 && !mFound; pos--)
            {
                for (int c = 0; c < _nChannels; c++)
                    if (_data[c][pos] > iMaxVal) mFound = true;
            }
            oEndMarker = pos;

            if (iPreview) return;
            _startMarker = oStartMarker;
            _endMarker = oEndMarker;

        }

        public float GetPeakModule()
        {
            UInt32 pos;
            float maxPeak = 0;
            for (pos = _startMarker; pos < _endMarker; pos++)
            {
                for (int c = 0; c < _nChannels; c++)
                    if (Math.Abs(_data[c][pos]) > maxPeak) maxPeak = Math.Abs(_data[c][pos]);
            }
            return maxPeak;
        }

        public float Normalize(float iRatio)
        {
            UInt32 pos;
/*            if (iPercent < 0 || iPercent > 100) throw new ArgumentOutOfRangeException();
            float maxVal = (float)MaxAllowableValue * iPercent / 100;
            float peak = GetPeakModule();
            
            float ratio = maxVal / peak;
            if(iPreview)
                return ratio;
 */
            if (iRatio == 1) return iRatio;
            for (pos = _startMarker; pos < _endMarker; pos++)
                for (int c = 0; c < _nChannels; c++)
                    _data[c][pos] *= iRatio;
            return iRatio;
        }
        

    }
}