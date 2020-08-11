using iData.Context;
using iData.rs;
using iInterface.rs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using vModel.rs;
using iData.cw;
using vModel;

namespace iServices.rs
{
    public class ihr_hi_personService : ihr_hi_personInterface
    {
        private readonly RsDbContext _rsU8DbContext;
        private readonly RsCqDbContext _rsCqDbContext;
        private readonly RsTjDbContext _rsTjDbContext;
        private readonly RsDlDbContext _rsDlDbContext;

        public ihr_hi_personService(RsDbContext rsU8DbContext,RsCqDbContext rsCqDbContext,RsTjDbContext rsTjDbContext,RsDlDbContext rsDlDbContext)
        {
            _rsU8DbContext = rsU8DbContext;
            _rsCqDbContext = rsCqDbContext;
            _rsTjDbContext = rsTjDbContext;
            _rsDlDbContext = rsDlDbContext;
        }

        public Task<IEnumerable<vPerson>> GetAll(string company)
        {
            //return Task.Run(() =>_rsU8DbContext.hr_hi_persons.AsEnumerable().Select(x => personDTO(x)));
            return Task.Run(() =>{
                if (company == "大连")
                {
                    return _rsDlDbContext.hr_hi_persons.AsEnumerable().Select(x => personDTO(x));
                }
                else if (company == "重庆")
                {
                    return _rsCqDbContext.hr_hi_persons.AsEnumerable().Select(x => personDTO(x));
                }
                else if (company == "天津") {
                    return _rsTjDbContext.hr_hi_persons.AsEnumerable().Select(x => personDTO(x));
                }
                else
                {
                    return _rsU8DbContext.hr_hi_persons.AsEnumerable().Select(x => personDTO(x));
                }

                
            });
        }

        public Task<IEnumerable<vPerson>> GetByName(string name)
        {
            return Task.Run(() =>
            {
                return _rsU8DbContext.hr_hi_persons.Where(x => x.cPsn_Name.Contains(name)).AsEnumerable().Select(x => personDTO(x));
            });
        }

        public Task<PageList<vPerson>> GetByPage(PageList<vPerson> vPersonPage)
        {
            return Task.Run(() => {
                var vp = vPersonPage.ItemData.FirstOrDefault();
                var vps = new PageList<vPerson>();
                IEnumerable<vPerson> persons = GetAll(vp.Department).Result;
                var viewPersons = persons.OrderBy(x => x.Name).Skip(vPersonPage.PageIndex - 1).Take(vPersonPage.PageSize);
                vps.ItemData = new List<vPerson>();
                vps.ItemData.AddRange(viewPersons);
                vps.PageIndex = vPersonPage.PageIndex;
                vps.PageSize = vPersonPage.PageSize;
                vps.PageIndex = vPersonPage.PageIndex;
                vps.Total = persons.Count();
                return vps;
            });
        }

        private vPerson personDTO(hr_hi_person uhr)
        {
            var vp = new vPerson()
            {
                Key = uhr.cPsn_Num,
                Department = uhr.cDept_num,
                IdCard = uhr.vIDNo,
                Name = uhr.cPsn_Name,
                Sex = uhr.rSex
            };
            return vp;
        }
    }


}
