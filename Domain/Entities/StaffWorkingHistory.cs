using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class StaffWorkingHistory
    {

        [Key]
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [MaxLength (50, ErrorMessage = "Company name must be 50 characters or less"), MinLength (3)]
        public string CompanyName { get; set; }
        [MaxLength(100, ErrorMessage = "Company Adress must be 100 characters or less"), MinLength(3)]
        public string CompanyAdress { get; set; }
        [MaxLength (50)]
        public string Qualification { get; set; }
        public string StaffId { get; set; }
        public string DepartamentId { get; set; }
        public bool IsCurrentCompany { get; set; }
        public bool IsCurrentWorking { get; set; }

        [ForeignKey ("StaffId")]
        public Staff Staff { get; set; }
        [ForeignKey("DepartamentId")]
        public Department Department { get; set; }

    }
}
