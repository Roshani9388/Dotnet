using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal abstract class Dashboard
    {
        public int financialyear;
        public String department;

        public Dashboard()
        {
            this.financialyear = 0;
            this.department = null;

        }

        public Dashboard(int financialyear, string department)
        {
            this.financialyear = financialyear;
            this.department = department;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract void Refresh();


    }

}
