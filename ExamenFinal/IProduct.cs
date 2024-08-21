using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public interface IProduct
    {
        int Code { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        decimal Discount { get; }
    }
}
