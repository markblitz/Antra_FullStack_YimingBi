using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Model.ResponseModel
{
    public class ProductResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? UnitsInStock { get; set; }

        public bool Discontinued { get; set; }
    }
}
