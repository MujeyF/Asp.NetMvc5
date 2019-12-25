using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.DomainModels
{
    public class Province
    {
        public Province()
        {
            Cities = new List<City>;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Poplulation { get; set; }
        public List<City> Cities { get; set; }
    }
}
