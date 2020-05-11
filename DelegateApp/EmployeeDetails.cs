using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    public class EmployeeDetails
    {
        public int eid { get; set; }
        public string ename { get; set; }
        public int  esal { get; set; }
        public int eexp { get; set; }

        public static void PromotedEmployee(List<EmployeeDetails> employeeDetails, IsPromoted isPromoted  )
        {
            foreach (EmployeeDetails employee in employeeDetails)
            {
                if(isPromoted(employee))
                {
                    Console.WriteLine("Below employee are promoted - {0}", employee.ename);
                }
                //if(employee.eexp >5)
                //{
                //    Console.WriteLine("Below employee are promoted - {0}", employee.ename);
                //}
            }
        }
    }

    //public class clientEmployee
    //{
    //    public static void Main()
    //    {
    //        List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>
    //        {
    //            new EmployeeDetails{eid=1,ename="Avnish",eexp=7,esal=7000},
    //            new EmployeeDetails{eid=1,ename="Manish",eexp=6,esal=6000},
    //            new EmployeeDetails{eid=1,ename="Sohan",eexp=4,esal=4000},
    //            new EmployeeDetails{eid=1,ename="Arti",eexp=5,esal=5000},
    //        };
    //        EmployeeDetails.PromotedEmployee(employeeDetails);
    //    }
    //}

    public  delegate bool IsPromoted(EmployeeDetails employee);
    public class clientEmployeeDelegate
    {
        public static void Main()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>
            {
                new EmployeeDetails{eid=1,ename="Avnish",eexp=7,esal=7000},
                new EmployeeDetails{eid=1,ename="Manish",eexp=6,esal=6000},
                new EmployeeDetails{eid=1,ename="Sohan",eexp=4,esal=4000},
                new EmployeeDetails{eid=1,ename="Arti",eexp=5,esal=5000},
            };

            //IsPromoted objEmp = new IsPromoted(IsEmployeePromoted);
            // EmployeeDetails.PromotedEmployee(employeeDetails, objEmp);
            EmployeeDetails.PromotedEmployee(employeeDetails, emp => emp.esal  > 6000);

        }

        
        
        //public static  bool IsEmployeePromoted(EmployeeDetails employeeDetails)
        //{
        //    if (employeeDetails.eexp > 5)
        //        return true;
        //    else
        //        return false;
            
        //}
    }
}
