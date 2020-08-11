using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iData.rs
{
    [Table("hr_hi_person")]
    public class hr_hi_person
    {
        [Key]
        public string cPsn_Num { get; set; }
        [Required]
        public string cPsn_Name { get; set; }
        public string cDept_num { get; set; }
        //public int iRecordID { get; set; }
        public string rPersonType { get; set; }
        public string rSex { get; set; }
        public string dBirthDate { get; set; }
        //public string rNativePlace { get; set; }
        //public string rNational { get; set; }
        //public string rhealthStatus { get; set; }
        //public string rMarriStatus { get; set; }
        public string vIDNo { get; set; }
        //public string MPicture { get; set; }
        //public string rPerResidence { get; set; }
        //public string vAliaName { get; set; }
        //public string dJoinworkDate { get; set; }
        //public string dEnterDate { get; set; }
        //public string dRegularDate { get; set; }
        //public string vSSNo { get; set; }
        //public string rworkAttend { get; set; }
        //public string vCardNo { get; set; }
        //public string rtbmRule { get; set; }
        public string rCheckInFlag { get; set; }
        //public string dLastDate { get; set; }
        //public TimeSpan hrts { get; set; }
        //public string vstatus1 { get; set; }
        //[MaxLength(18)]
        //public string nstatus2 { get; set; }
        public bool bPsnPerson { get; set; }
        public string cPsnMobilePhone { get; set; }
        //public string cPsnFPhone { get; set; }
        //public string cPsnOPhone { get; set; }
        //public string cPsnInPhone { get; set; }
        //public string cPsnEmail { get; set; }
        //public string cPsnPostAddr { get; set; }
        //public string cPsnPostCode { get; set; }
        //public string cPsnFAddr { get; set; }
        //public string cPsnQQCode { get; set; }
        //public string cPsnURL { get; set; }
        //public string CpsnOSeat { get; set; }
        public string dEnterUnitDate { get; set; }
        //public string cPsnProperty { get; set; }
        //public string cPsnBankCode { get; set; }
        //public string cPsnAccount { get; set; }
        //public string pk_hr_hi_person { get; set; }
        public bool bProbation { get; set; }
        //public string cDutyclass { get; set; }
        public bool bTakeTM { get; set; }
        public string MPictureqpb { get; set; }
        public string rIDType { get; set; }
        //public string rCountry { get; set; }
        //public string dLeaveDate { get; set; }
        public string rFigure { get; set; }
        //public string rWorkStatus { get; set; }
        public string EmploymentForm { get; set; }
        public string rPersonParameters { get; set; }
        public bool bDutyLock { get; set; }
        //public bool bpsnshop { get; set; }
        public string CardState { get; set; }
        //public string FirstHTBeginDate { get; set; }
        //public string LastHTEndDate { get; set; }
        //public string cPsn_NameEN { get; set; }
        //public string sysAge { get; set; }
        //public string SysCompage { get; set; }
        //public string SysWorkAge { get; set; }
        //public string CRegion { get; set; }
        //public string NatrueType { get; set; }
        public string cShiftType { get; set; }
        public string cDefaultBC { get; set; }
        //public DateTime? dEnterDutyClassDate { get; set; }
        public string cRestType { get; set; }
        public string JobNumber { get; set; }
        //public string PersonDepart { get; set; }
        //public string CardEffectiveBeginTime { get; set; }
        //public string CardEffectiveEndTime { get; set; }
        //public bool KeyPerson { get; set; }
        //public string cLeaveReson { get; set; }
        public string rEmployState { get; set; }
        //public string cDutyLocker { get; set; }
        //public string cDutyLockerNum { get; set; }
        public string cJobCode { get; set; }
        //public string cJobRankCode { get; set; }
        //public string cJobGradeCode { get; set; }
        //public string cPsnNowAddress { get; set; }
        //public string cUrgentPsnName { get; set; }
        //public string cUrgentPsnPhone { get; set; }
        //public bool bLongIDCard { get; set; }
        //public string cLeaveType { get; set; }
        //public string cDutyCode { get; set; }
        //public string cFax { get; set; }
        //public string cTitle { get; set; }
        //public string cReportTo { get; set; }
        //public string cStartWorkTime { get; set; }
        //public string cEndWorkTime { get; set; }
        //public string cLoginSubIDs { get; set; }
        public string cpersonbarcode { get; set; }
        //public bool bMobileCard { get; set; }
        //public string cMobileSites { get; set; }
        //public string vOldCard { get; set; }
        //public int MaxLeadNum { get; set; }
        //public int MaxPAccountNum { get; set; }
        //public int MaxAccountNum { get; set; }
        //public int MaxOpportunityNum { get; set; }
        //public string LeadRcyReg { get; set; }
        //public string PAccountRcyReg { get; set; }
        //public string OpportunityRcyReg { get; set; }
        //public string cESpaceUserID { get; set; }
        //public string cWeixinid { get; set; }
        //public string FAccountRcyReg { get; set; }
        public string xulie { get; set; }
        public string rylx { get; set; }
        public string gwxj { get; set; }
        public string sblx { get; set; }
        public string zpqd { get; set; }
        //重庆没有
        //public string htqs { get; set; }
        //重庆没有
        //public string htjs { get; set; }
        //重庆没有
        //public string GZHZ { get; set; }
        //public string BM { get; set; }
        public string XL { get; set; }
        //public string XUEXIAO { get; set; }
        //public string ZY { get; set; }
        public string GZDD { get; set; }
        public string dlgzhz { get; set; }
        //public string ZYZG { get; set; }
        //public string PXJL { get; set; }
        //public string HJJL { get; set; }
        //public string GZJL { get; set; }
        //public string GRTC { get; set; }
        //重庆无此字段
        //public string RYSZ { get; set; }
        public string zwdj { get; set; }
        public string xzdj { get; set; }

    }
}
