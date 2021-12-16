using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class Company
    {
       
        public string Name { get; set; }

        public string Image { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public int CarSold { get; set; }
        public double TotalProfit { get; set; }

        public static Company company;

        public static void data()
        {
            Company data = new Company();
            data.Name = "AA Canada Inc";
            data.StreetName = "5709 Steeles Ave W";
            data.City = "North York";
            data.Province = "Ontario";
            data.PostalCode = "ON M9L 1S7";
            data.CarSold = 37;
            data.TotalProfit = 23324.75;
            data.Image = "Company";
            Company.company = data;
        }
    }
}
