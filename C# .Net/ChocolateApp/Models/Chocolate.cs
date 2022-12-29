using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateApp.Models
{
    public class Chocolate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public String Quantity { get; set; }
        public String Price { get; set; }
        public String Stockdetails { get; set; }
        public String Ingrdients { get; set; }
        public String ImportBy { get; set; }
        public string picture { get; set; }
        public String PD { get => ProductionDate.ToString("yyyy-MM-dd"); }
        public String ED { get => ExpiredDate.ToString("yyyy-MM-dd"); }

    }
}
