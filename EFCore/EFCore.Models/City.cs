using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.DomainModels
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AreaCode { get; set; }
        public int ProvinceCode { get; set; }
        public Province Province { get; set; }

    }
}
