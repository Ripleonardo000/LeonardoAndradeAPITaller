using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonardoAndradeAPITaller.Models
{

    /*
    public class Burger
    {
        public int burgerId { get; set; }
        public string name { get; set; }
        public bool withCheese { get; set; }
        public int costo { get; set; }
        public List<object> promos { get; set; }
    }
    */

    
    public class Burger
    {
        public int burgerId { get; set; }
        public string? name { get; set; }
        public bool withCheese { get; set; }
        public decimal costo { get; set; }
        public object[]? promos { get; set; }
    }
    



}
