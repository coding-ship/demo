using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class Vechile
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Condition { get; set; }
        public string Engine_Cylinders { get; set; }
        public int Year { get; set; }
        public int NoOfDoors { get; set; }

        public double Price { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public string Date_Sold { get; set; }

        
        public static List<Vechile> VechileList()
        {
            List<Vechile> vechileList = new List<Vechile>();
            vechileList.Add(new Vechile{ 
                Make = "Honda",
                Model = "Honda City 4th Generation",
                Condition = "New",
                Engine_Cylinders = "v4",
                Year = 2014,
                NoOfDoors = 4,
                Price = 986000,
                Color = "black",
                Image="honda4",
                Date_Sold="11/12/2021"
                
            });
            vechileList.Add(new Vechile
            {
                Make = "Honda",
                Model = "Honda City",
                Condition = "New",
                Engine_Cylinders = "v4",
                Year = 2016,
                NoOfDoors = 4,
                Price = 1116000,
                Color = "grey",
                Image = "city",
                Date_Sold=""
            });
            vechileList.Add(new Vechile
            {
                Make = "Honda",
                Model = "Honda Amaze",
                Condition = "Old",
                Engine_Cylinders = "v4",
                Year = 2015,
                NoOfDoors = 4,
                Price = 632000,
                Color = "black",
                Image = "amaze",
                Date_Sold = ""
            });
            vechileList.Add(new Vechile
            {
                Make = "Nissan",
                Model = "Nissan Magnite",
                Condition = "Old",
                Engine_Cylinders = "v4",
                Year = 2013,
                NoOfDoors = 4,
                Price = 571000,
                Color = "red",
                Image = "magnite",
                Date_Sold = ""
            });
            vechileList.Add(new Vechile
            {
                Make = "Nissan",
                Model = "Nissan Kicks",
                Condition = "New",
                Engine_Cylinders = "v4",
                Year = 2015,
                NoOfDoors = 4,
                Price = 949000,
                Color = "red",
                Image = "kicks",
                Date_Sold = ""
            });
            return vechileList;
        }

    }
}
