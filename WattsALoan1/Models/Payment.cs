namespace WattsALoan1.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Payment
    {
        [Display(Name = "Payment Id")]
        public int PaymentId { get; set; }
        [Display(Name = "Receipt #")]
        public int? ReceiptNumber { get; set; }

        [StringLength(40)]
        [Display(Name = "Payment Date")]
        public string PaymentDate { get; set; }
        [Display(Name = "Employee Id")]
        public int? EmployeeId { get; set; }
        [Display(Name = "Loan Contract Id")]
        public int? LoanContractId { get; set; }

        [StringLength(10)]
        [Display(Name = "Payment Amount")]
        public string PaymentAmount { get; set; }

        [StringLength(10)]
        public string Balance { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual LoanContract LoanContract { get; set; }
    }
}
