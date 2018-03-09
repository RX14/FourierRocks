using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FourierRocks
{
    public class WorkProgress
    {
        int _progress;
        public ProgressBar PBar = null;
        public void UpdateProgress(int iP)
        {
            if (iP < 0 || iP > 100) return;
            _progress = iP;
            if (PBar != null)
            {
               PBar.Value = iP;
               PBar.Refresh();
            }
            Application.DoEvents();
        }

        public int Progress
        {
            get { return _progress; }
        }
    }
}
