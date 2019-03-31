using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempSite.Models
{
    public class AttemptLab
    {
        private static AttemptLab instance;
        private List<Attempt> atLab;

        public static AttemptLab Get()
        {
            if (instance == null)
                instance = new AttemptLab();
            return instance;
        }

        private AttemptLab()
        {
            atLab = new List<Attempt>();
        }

        public void Add(Attempt item)
        {
            atLab.Add(item);
        }

        public List<Attempt> GetAttempts()
        {
            return atLab;
        }
    }
}