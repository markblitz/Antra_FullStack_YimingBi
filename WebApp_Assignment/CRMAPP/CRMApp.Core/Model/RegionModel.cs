using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Model
{
    public class RegionModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
    }
}
