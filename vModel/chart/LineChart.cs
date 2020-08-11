using System;
using System.Collections.Generic;
using System.Text;

namespace vModel.chart
{
    public class LineChart
    {

        public Title Title { get; set; } = new Title();

        public Tooltip Tooltip { get; set; } = new Tooltip();
        public Legend Legend { get; set; } = new Legend();
        public Grid Grid { get; set; } = new Grid();
        public Toolbox Toolbox { get; set; } = new Toolbox();
        public xAxis xAxis { get; set; } = new xAxis();
        public yAxis yAxis { get; set; } = new yAxis();
        public List<Series> Series { get; set; } = new List<Series>();
    }

    public class Title {
        public string Text { get; set; }
    }

    public class Tooltip {
        public string Trigger { get; set; } = "axis";
    }

    public class Legend {
        public List<string> Data { get; set; } = new List<string>();
    }

    public class Grid {
        public string Left { get; set; } = "3%";
        public string Right { get; set; } = "4%";
        public string Buttom { get; set; } = "1%";
        public bool ContainLabel { get; set; } = true;
    }

    public class Toolbox
    {
        public Feature Feature { get; set; } = new Feature();
    }

    public class Feature
    {
        public SaveAsImage SaveAsImage { get; set; } = new SaveAsImage();
    }

    public class SaveAsImage
    {

    }

    public class xAxis
    {
        public string Type { get; set; } = "category";
        public bool BoundaryGap { get; set; } = false;
        public List<string> Data { get; set; } = new List<string>();
    }
    public class yAxis {
        public string Type { get; set; } = "value";
    }

    public class Series { 
        public string Name { get; set; }
        public string Type { get; set; } = "line";
        public string stack { get; set; } = "总量";
        public List<decimal> Data { get; set; } = new List<decimal>();
    }
}
