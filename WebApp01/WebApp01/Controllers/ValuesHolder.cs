using System;
using System.Collections.Generic;

namespace WebApp01.Controllers
{
    public class ValuesHolder
    {
        public List<WeatherForcast> Values { get; set; } = new List<WeatherForcast>();

        public void Add (WeatherForcast weatherForcast)
        {
            Values.Add(weatherForcast);
        }

        public IList<WeatherForcast> Get()
        {
            return Values;
        }
    }
}
