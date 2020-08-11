using System;
using System.Collections.Generic;
using System.Text;

namespace vModel.chart
{
    public class LineBase
    {
        public string Text { get; set; }
        public string Type { get; set; }
        public List<string> Data { get; set; } = new List<string>();
    }
}
