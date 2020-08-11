using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iInterface
{
    public interface iBaseInterface<T> where T:class
    {
        Task<IEnumerable<T>> GetAll();
    }
}
