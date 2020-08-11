using System;
using System.Collections.Generic;
using System.Text;

namespace vModel
{
    public class vResult
    {
        public StateType State { get; set; }
        public string Message { get; set; }
    }

    public enum StateType { 
        Ok=0,
        Error=1
    }
}
