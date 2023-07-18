using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Salesdashboard : Dashboard,CustomerDetails,OrderDetails
    {

        private string creator;
        private string modifier;

        public Salesdashboard() { }

        public Salesdashboard(string creator, string modifier,int fyear,string dept):base(fyear,dept)
        {
            this.creator = creator;
            this.modifier = modifier;   
        }

        public override void Refresh()
        {
            Console.WriteLine("In refresh Method");
        }

         void OrderDetails.ShowDetails()
        {
            Console.WriteLine(" In orderDetails showdetails()");
        }

        void CustomerDetails.ShowDetails()
        {
			Console.WriteLine(" In CustomerDetails showdetails()");
		}
    }
}
