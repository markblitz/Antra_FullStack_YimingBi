using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMApp.Core.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [Column(TypeName = "varchar(40)")]
        public string Name { get; set; }

        public int SupplierId { get; set; }

        public int CategoryId { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string QuantityPerUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "smallint")]
        public int UnitsInStock { get; set; }

        [Column(TypeName = "smallint")]
        public int UnitsOnOrder { get; set; }

        [Column(TypeName = "smallint")]
        public int ReorderLevel { get; set; }

        [Required(ErrorMessage = "If discontinued is required!")]
        public bool Discontinued { get; set; }

        public Category Category { get; set; }

        public Supplier Supplier { get; set; }
    }
}
