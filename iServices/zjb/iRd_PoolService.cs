using iData.Context;
using iData.cw;
using iInterface.cw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vModel;
using vModel.chart;

namespace iServices.zjb
{
    public class iRd_PoolService : iRd_PoolInterface
    {
        private readonly MyDbContext _myContext;

        public iRd_PoolService(MyDbContext myContext) {
            _myContext = myContext;
        }
        
        public Task<LineChart> GetAll(string company)
        {
            return Task.Run(()=> {
                var listAll=_myContext.rd_Pools.ToList().Where(x=>x.Location.StartsWith(company)).GroupBy(x=>x.Years).Select(g=>new { Name=g.Key.ToString(),Prices=Math.Round(g.Sum(o=>o.Prices),2),Sales=Math.Round(g.Sum(o=>o.Sales),2),Salaries=Math.Round(g.Sum(o=>o.Salary),2)});
                listAll = listAll.OrderBy(x => x.Name);
                var lineChart = new LineChart();
                lineChart.Title.Text = "经营分析堆叠图";
                lineChart.Legend.Data.Add("销售出库");
                lineChart.Legend.Data.Add("人员工资");
                lineChart.Legend.Data.Add("采购入库");
                lineChart.Tooltip = new Tooltip();
                Series seriescg = new Series();
                seriescg.Name = "采购入库";
                Series seriesxs = new Series();
                seriesxs.Name = "销售出库";
                seriesxs.stack = "";
                Series seriesgz = new Series();
                seriesgz.Name = "人员工资";
                foreach (var line in listAll) {
                    lineChart.xAxis.Data.Add(line.Name);
                    seriesxs.Data.Add(line.Sales);
                    seriesgz.Data.Add(line.Salaries);
                    seriescg.Data.Add(line.Prices);
                }
                lineChart.Series.Add(seriesxs);
                lineChart.Series.Add(seriesgz);
                lineChart.Series.Add(seriescg);
                return lineChart;
            });
        }

        public Task<List<vKeyValue>> GetCompanyList()
        {
            return Task.Run(()=> { 
                var clist=_myContext.rd_Pools.Select(x => x.Location).Distinct();
                List<vKeyValue> vkeys = new List<vKeyValue>();
                vkeys.Add(new vKeyValue { Key = "", Value = "全部" });
                foreach (var c in clist) {
                    vkeys.Add(new vKeyValue { Key = c, Value = c });
                }
                return vkeys;
            });
        }
    }
}
