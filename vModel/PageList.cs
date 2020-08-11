using System;
using System.Collections.Generic;
using System.Text;

namespace vModel
{
    public class PageList<T> where T:class
    {
        public List<T> ItemData { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }
    }
}
