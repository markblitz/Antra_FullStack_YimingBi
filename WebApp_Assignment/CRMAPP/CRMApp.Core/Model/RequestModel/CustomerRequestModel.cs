using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Model.RequestModel
{
    public class CustomerRequestModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [Column(TypeName = "varchar(30)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string? Title { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string? Address { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? City { get; set; }

        public int RegionId { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? PostalCode { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Country { get; set; }

        [Column(TypeName = "varchar(24)")]
        public string? Phone { get; set; }
    }
}
