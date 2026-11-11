using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Scale.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public float Price { get; set; }
    }

    public class Sales
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public float Weight { get; set; }
        public float TotalPrice { get; set; }
        public DateTime Date { get; set; }

    }


}
