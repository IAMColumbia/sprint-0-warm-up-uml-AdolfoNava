using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_0_Warm_Up
{
    public interface IEngine : IAboutable
    {
        public bool IsStarted { get; set; }
        public void Start();

        public void Stop();
    }
}
