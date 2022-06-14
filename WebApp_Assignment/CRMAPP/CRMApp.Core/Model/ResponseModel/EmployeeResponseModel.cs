using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Model.ResponseModel
{
    public class EmployeeResponseModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string TitleOfCourtesy { get; set; }

        public DateTime? HireDate { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string PhotoPath { get; set; }
    }
}
