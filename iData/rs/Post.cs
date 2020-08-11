using System;
using System.Collections.Generic;
using System.Text;

namespace iData.rs
{
    public class Post:Base
    {
        public Department Department { get; set; }
        public string PostName { get; set; }
    }
}
