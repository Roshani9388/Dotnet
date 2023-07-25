using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    using BOL;

    public interface IDBManager
    {
        void Delete(int id);
        List<Department> getAll();
        void Insert(Department dept);
        void Update(Department updateDept);
    }
}
