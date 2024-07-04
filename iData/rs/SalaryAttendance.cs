using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Text;

namespace iData.rs
{
    [Table(nameof(SalaryAttendance))]
    public class SalaryAttendance:Base
    {
        public DateTime Period { get; set; }
        public int DepartmentId { get; set; }
        [Display(Name = "工号"), MaxLength(20)]
        public string gh { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal rcCq { get; set; }
        [Display(Name = "日常小时"), Column(TypeName = "decimal(8, 2)")]
        public decimal F_37 { get; set; }
        [Display(Name = "日常小时-旷工*8*3"), Column(TypeName = "decimal(8, 2)")]
        public decimal rcxs { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal zjCq { get; set; }
        [Display(Name = "出勤天数"),Column(TypeName = "decimal(8, 2)")]
        public decimal F_89 { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal rcJb { get; set; }
        [Display(Name = "日常加班小时"),Column(TypeName = "decimal(8, 2)")]
        public decimal F_38 { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal jqJb { get; set; }
        [Display(Name = "周末加班小时"),Column(TypeName = "decimal(8, 2)")]
        public decimal F_39 { get; set; }
        //[Display(Name = "节假日加班小时")]
        //模具加班可能是62
        //public float F_98 { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal ybSum { get; set; }
        [Display(Name = "基本夜班天数"),Column(TypeName = "decimal(8, 2)")]
        //模具加班可能是62
        public decimal F_64 { get; set; }
        [Display(Name = "模具满勤天数"), Column(TypeName = "decimal(8, 2)")]
        //模具加班可能是62
        public decimal F_61 { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal thingJ { get; set; }
        [Display(Name = "事假"), Column(TypeName = "decimal(8, 2)")]
        public decimal F_105 { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal illJ { get; set; }
        [Display(Name = "病假"), Column(TypeName = "decimal(8, 2)")]
        public decimal F_106 { get; set; }
        [Display(Name = "计件工时"), Column(TypeName = "decimal(8, 2)")]
        public decimal Piece { get; set; }
        [Display(Name = "异常工时"), Column(TypeName = "decimal(8, 2)")]
        public decimal oPiece { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal sumColPiece { get; set; }
        [Display(Name = "计件工时")]
        public float F_111 { get; set; }
        [Display(Name = "标准工时"), Column(TypeName = "decimal(8, 2)")]
        public int F_114 { get; set; } = 286;
        [Display(Name = "超产小时")]
        public float F_112 { get; set; }
        [Display(Name ="是否满勤")]
        public bool IsFull { get; set; }
        [Display(Name = "全勤奖"), Column(TypeName = "decimal(8, 2)")]
        public decimal F_48 { get; set; }
        [Display(Name = "迟到")]
        public int cd { get; set; }
        [Display(Name = "早退")]
        public int zt { get; set; }
        [Display(Name = "迟到早退扣费"), Column(TypeName = "decimal(8, 2)")]
        public decimal kqkf { get; set; }
        [Display(Name = "入职缺勤"), Column(TypeName = "decimal(8, 2)")]
        public decimal rzqq { get; set; }
        [Display(Name = "离职缺勤"), Column(TypeName = "decimal(8, 2)")]
        public decimal lzqq { get; set; }
        [Display(Name = "旷工天数"), Column(TypeName = "decimal(8, 2)")]
        public decimal kgqq { get; set; }
        [Display(Name = "入离天数"), Column(TypeName = "decimal(8, 2)")]
        public decimal lzTs { get; set; }
        [Display(Name = "个人绩效系数"), Column(TypeName = "decimal(8, 2)")]
        public decimal F_15 { get; set; }
        [Display(Name = "效益绩效系数"), Column(TypeName = "decimal(8, 2)")]
        public decimal xyxs { get; set; }
        [Display(Name = "二次嘉奖"), Column(TypeName = "decimal(8, 2)")]
        public decimal ecjj { get; set; }
        [Display(Name = "节日加班"), Column(TypeName = "decimal(8, 2)")]
        public decimal jrjb { get; set; }
        [Display(Name = "节日加班改"), Column(TypeName = "decimal(8, 2)")]
        public decimal jrjbg { get; set; }
        [Display(Name = "总计出勤")]
        public float workZc { get; set; }
        [Display(Name = "总计事假")]
        public float allThing { get; set; }
        [Display(Name = "社保"),Column(TypeName = "decimal(8, 2)")]
        public decimal Sb { get; set; }
        [Display(Name = "医保"), Column(TypeName = "decimal(8, 2)")]
        public decimal Yb { get; set; }
        [Display(Name = "公积金"), Column(TypeName = "decimal(8, 2)")]
        public decimal Gjj { get; set; }
        [Display(Name = "社保医保")]
        public float SbYb { get; set; }
        [Display(Name = "社保基数")]
        public int SbJs { get; set; } = 0;
        [Display(Name = "全勤奖"), Column(TypeName = "decimal(8, 2)")]
        public decimal iFull { get; set; }
        [Display(Name = "高温补贴"), Column(TypeName = "decimal(8, 2)")]
        public decimal HighTemperature { get; set; }
        [Display(Name = "工作服扣费"), Column(TypeName = "decimal(8, 2)")]
        public decimal oaGf { get; set; }
        [Display(Name = "其他项"), Column(TypeName = "decimal(8, 2)")]
        public decimal iQt { get; set; }
        [Display(Name = "oa奖惩"), Column(TypeName = "decimal(8, 2)")]
        public decimal oaJc { get; set; }
        [Display(Name = "oa奖励"), Column(TypeName = "decimal(8, 2)")]
        public decimal oaJl { get; set; }
        [Display(Name = "oa处罚"), Column(TypeName = "decimal(8, 2)")]
        public decimal oaCf { get; set; }
        [Display(Name = "oa奖励次")]
        public int zjec { get; set; }
        [Display(Name = "oa处罚次")]
        public int fjec { get; set; }
        [Display(Name = "餐费"), Column(TypeName = "decimal(8, 2)")]
        public decimal eatPay { get; set; }
        [Display(Name = "调休"), Column(TypeName = "decimal(8, 2)")]
        public decimal Tx { get; set; }
        [Display(Name = "年假"), Column(TypeName = "decimal(8, 2)")] 
        public decimal Nj { get; set; }
        [Display(Name = "事假"), Column(TypeName = "decimal(8, 2)")]
        public decimal Sj { get; set; }
        [Display(Name = "病假"), Column(TypeName = "decimal(8, 2)")]
        public decimal Bj { get; set; }
        [Display(Name = "探亲假"), Column(TypeName = "decimal(8, 2)")]
        public decimal Tq { get; set; }
        [Display(Name = "婚假"), Column(TypeName = "decimal(8, 2)")]
        public decimal Hj { get; set; }
        [Display(Name = "产假"), Column(TypeName = "decimal(8, 2)")]
        public decimal Cj { get; set; }
        [Display(Name = "哺乳假"), Column(TypeName = "decimal(8, 2)")]
        public decimal Prj { get; set; }
        [Display(Name = "丧假"), Column(TypeName = "decimal(8, 2)")]
        public decimal Sx { get; set; }
        [Display(Name = "陪产假"), Column(TypeName = "decimal(8, 2)")]
        public decimal Pcj { get; set; }
        [Display(Name = "带薪病假"), Column(TypeName = "decimal(8, 2)")]
        public decimal Dxbj { get; set; }
        [Display(Name = "加班"), Column(TypeName = "decimal(8, 2)")]
        public decimal Jb { get; set; }
        [Display(Name = "出差"), Column(TypeName = "decimal(8, 2)")]
        public decimal Cc { get; set; }
        [Display(Name = "工作总时"), Column(TypeName = "decimal(8, 2)")] 
        public decimal workZxs { get; set; }
        [Display(Name = "签名图像")]
        public string UserCanvas { get; set; }
        [Display(Name = "签名"),MaxLength(20)]
        public string UserName { get; set; }

        [Display(Name = "签名时间")]
        public DateTime? ConfirmTime { get; set; }
    }
}
