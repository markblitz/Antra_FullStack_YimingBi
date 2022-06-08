using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMApp.Core.Entity
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required!")]
        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required!")]
        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string TitleOfCourtesy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime HireDate { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string City { get; set; }

        public int RegionId { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string PostalCode { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Country { get; set; }

        [Column(TypeName = "varchar(24)")]
        public string Phone { get; set; }

        public int ReportsTo { get; set; }

        [Column(TypeName = "ntext")]
        public string PhotoPath { get; set; }
    }
}
