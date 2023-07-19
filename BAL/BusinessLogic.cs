using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvc.BAL
{
    public class BusinessLogic
    {


    }


    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }

        public List<City> GetCities()
        {
            List<City> cityList = new List<City>()
            {
                new City(){CityId =1,CityName ="Guduvanchery"},
                new City(){CityId =2,CityName ="Tambaram"},
                new City(){CityId =3,CityName ="AnnaNagar"},
                new City(){CityId =4,CityName ="TNagar"},
                new City(){CityId =5,CityName =" R A Puram"}
            };
            return cityList;
        }
    }

    public class Destination
    {
        public int DestId { get; set; }
        public string DestName { get; set; }

        public List<Destination> GetDestinations()
        {
            List<Destination> destList = new List<Destination>()
            {
                new Destination(){DestId=1, DestName="Developer"},
                new Destination(){DestId=2, DestName="Tester"},
                new Destination(){DestId=3, DestName="Manager"},
                new Destination(){DestId=4, DestName="Lead"}
            };
            return destList;
        }

    }

    public class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int DestId { get; set; }
        public int CityId { get; set; }
       // public virtual List<Destination> destinaltionList { get; set; }
      //  public virtual List<City> cityList { get; set; }
        public Destination destination { get; set; }
        public City city { get; set; } 

        public List<Emp> GetEmps()
        {
            Destination dst = new Destination();
            City ct = new City();            

            List<Emp> empList = new List<Emp>()
            {
            new Emp (){EmpId =1 ,EmpName="Raja" ,CityId=1,DestId=1, destination = dst.GetDestinations().Where(d => d.DestId == 1).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 1).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =2 ,EmpName="Gopal" ,CityId=3,DestId=3, destination = dst.GetDestinations().Where(d => d.DestId == 3).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =3 ,EmpName="Karthick" ,CityId=4,DestId=4 , destination = dst.GetDestinations().Where(d => d.DestId == 4).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 4).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =4 ,EmpName="Mohan" ,CityId=1,DestId=3 , destination = dst.GetDestinations().Where(d => d.DestId == 2).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =5 ,EmpName="Praveen" ,CityId=1,DestId=1, destination = dst.GetDestinations().Where(d => d.DestId == 1).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 1).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =6 ,EmpName="Kannan" ,CityId=3,DestId=3, destination = dst.GetDestinations().Where(d => d.DestId == 3).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =7 ,EmpName="Prabhu" ,CityId=4,DestId=4 , destination = dst.GetDestinations().Where(d => d.DestId == 4).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 4).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =8 ,EmpName="Suresh" ,CityId=1,DestId=3 , destination = dst.GetDestinations().Where(d => d.DestId == 2).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =9 ,EmpName="Durai" ,CityId=1,DestId=1, destination = dst.GetDestinations().Where(d => d.DestId == 1).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 1).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =10 ,EmpName="Gopi" ,CityId=3,DestId=3, destination = dst.GetDestinations().Where(d => d.DestId == 3).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =11 ,EmpName="Selvam" ,CityId=4,DestId=4 , destination = dst.GetDestinations().Where(d => d.DestId == 4).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 4).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =12 ,EmpName="Mani" ,CityId=1,DestId=3 , destination = dst.GetDestinations().Where(d => d.DestId == 2).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =13 ,EmpName="Kandan" ,CityId=1,DestId=1, destination = dst.GetDestinations().Where(d => d.DestId == 1).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 1).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =14 ,EmpName="Palani" ,CityId=3,DestId=3, destination = dst.GetDestinations().Where(d => d.DestId == 3).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =15 ,EmpName="Prabakaran" ,CityId=4,DestId=4 , destination = dst.GetDestinations().Where(d => d.DestId == 4).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 4).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =16 ,EmpName="Herman" ,CityId=1,DestId=3 , destination = dst.GetDestinations().Where(d => d.DestId == 2).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =17 ,EmpName="Naveen" ,CityId=1,DestId=1, destination = dst.GetDestinations().Where(d => d.DestId == 1).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 1).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =18 ,EmpName="Sathiyababu" ,CityId=3,DestId=3, destination = dst.GetDestinations().Where(d => d.DestId == 3).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =19 ,EmpName="Kishor" ,CityId=4,DestId=4 , destination = dst.GetDestinations().Where(d => d.DestId == 4).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 4).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =20 ,EmpName="Tamil" ,CityId=1,DestId=3 , destination = dst.GetDestinations().Where(d => d.DestId == 2).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =21 ,EmpName="Bala" ,CityId=1,DestId=1, destination = dst.GetDestinations().Where(d => d.DestId == 1).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 1).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =22 ,EmpName="Rajesh" ,CityId=3,DestId=3, destination = dst.GetDestinations().Where(d => d.DestId == 3).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault() },
            new Emp (){EmpId =23 ,EmpName="Shunmugam" ,CityId=4,DestId=4 , destination = dst.GetDestinations().Where(d => d.DestId == 4).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 4).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},
            new Emp (){EmpId =24 ,EmpName="Kiran" ,CityId=1,DestId=3 , destination = dst.GetDestinations().Where(d => d.DestId == 2).Select(s => new Destination() { DestId = s.DestId, DestName = s.DestName }).SingleOrDefault() ,city = ct.GetCities().Where(c => c.CityId == 3).Select(s => new City() { CityId = s.CityId, CityName = s.CityName }).SingleOrDefault()},



            };

            return empList;
        }
    }


    public class EmployeeModel 
    {
        ///<summary>
        /// Gets or sets Customers.
        ///</summary>
        public List<Emp> Employes { get; set; }   

        ///<summary>
        /// Gets or sets CurrentPageIndex.
        ///</summary>
        public int CurrentPageIndex { get; set; }

        ///<summary>
        /// Gets or sets PageCount.
        ///</summary>
        public int PageCount { get; set; }

        public int TotalRecords { get; set; }
    }
}