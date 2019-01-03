namespace WattsALoan1.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class LoanContract
    {
        [Display(Name = "Loan Contract Id")]
        public int LoanContractId { get; set; }
        [Display(Name = "Loan #")]
        public int LoanNumber { get; set; }

        [StringLength(40)]
        [Display(Name = "Date Allocated")]
        public string DateAllocated { get; set; }
        [Display(Name = "Employee Id")]
        public int? EmployeeId { get; set; }

        [StringLength(20)]
        [Display(Name = "First Name")]
        public string CustomerFirstName { get; set; }

        [StringLength(20)]
        [Display(Name = "Last Name")]
        public string CustomerLastName { get; set; }

        [StringLength(20)]
        [Display(Name = "Loan Type")]
        public string LoanType { get; set; }

        [StringLength(10)]
        [Display(Name = "Loan Amount")]
        public string LoanAmount { get; set; }

        [StringLength(10)]
        [Display(Name = "Interest Rate")]
        public string InterestRate { get; set; }

        public int? Periods { get; set; }

        [StringLength(10)]
        [Display(Name = "Monthly Payment")]
        public string MonthlyPayment { get; set; }

        [StringLength(10)]
        [Display(Name = "Future Value")]
        public string FutureValue { get; set; }

        [StringLength(10)]
        [Display(Name = "Interest Amount")]
        public string InterestAmount { get; set; }

        [StringLength(40)]
        [Display(Name = "Payment Start Date")]
        public string PaymentStartDate { get; set; }

        public string Identification
        {
            get
            {
                return LoanContractId + " - " + LoanNumber + " as " + LoanType + " to " +
                       CustomerFirstName + " " + CustomerLastName + " for " +
                       LoanAmount + " (" + MonthlyPayment + "/month)";
            }
        }

        public virtual Employee Employee { get; set; }
    }
}
