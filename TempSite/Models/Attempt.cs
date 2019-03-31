using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempSite.Models
{
    public class Attempt
    {
        public DateTime mTime { get; set; }
        public string mIp { get; set; }
        public string mAction { get; set; }

        public Attempt(string mIp, string mAction)
        {
            mTime = DateTime.Now;
            this.mIp = mIp;
            this.mAction = mAction;
        }
        /*
                public string GetmAction()
                {
                    return mAction;
                }

                public void SetmAction(string value)
                {
                    mAction = value;
                }


                public DateTime GetTime()
                {
                    return mTime;
                }

                public void SetTime(DateTime value)
                {
                    mTime = value;
                }


                public string GetIp()
                {
                    return mIp;
                }

                public void SetIp(string value)
                {
                    mIp = value;
                }
                */
    }
}