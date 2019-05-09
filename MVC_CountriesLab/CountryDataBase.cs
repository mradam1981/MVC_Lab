﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CountriesLab
{
    class CountryDataBase
    {
       public List<Country> Countries = new List<Country>();

        public CountryDataBase()
        {

            List<string> usaColors = new List<string> { "Red, White, and Blue" };
            Countries.Add(new Country("USA", "North America", usaColors));
            List<string> chinaColors = new List<string> { "Red and Yellow" };
            Countries.Add(new Country("China", "Asia", chinaColors));
            List<string> germanyColors = new List<string> { "Black, Yellow, Red" };
            Countries.Add(new Country("Germany", "Europe", germanyColors));
            List<string> greeceColors = new List<string> { "Blue and White" };
            Countries.Add(new Country("Greece", "Europe", greeceColors));
            List<string> egyptColors = new List<string> { "Red, Black, and White" };
            Countries.Add(new Country("Egypt", "Africa", egyptColors));
        }

        




        


    }
}
