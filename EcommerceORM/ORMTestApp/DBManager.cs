using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BOL;

namespace DAL
{
    public class DBManager : IDBManager
    {
        public void Delete(int id)
        {
            using (var context=new CollectionContext())
            {
                context.Departments.Remove(context.Departments.Find(id));
                context.SaveChanges();
            }
        }

        public List<Department> getAll()
        {
            using (var context = new CollectionContext())
            {
                var deptartments = from dept in context.Departments select dept;
                return deptartments.ToList<Department>();
            }
        }

        public void Insert(Department dept)
        {
            using (var context = new CollectionContext())
            {
                context.Departments.Add(dept);
                context.SaveChanges();
            }

        }

        public void Update(Department Dept)
        {
            using (var context = new CollectionContext())
            {
                var thedept = context.Departments.Find(Dept.Id);
                thedept.Name = Dept.Name;
                thedept.Location = Dept.Location;
                context.SaveChanges();
            }
        }
    }
}
