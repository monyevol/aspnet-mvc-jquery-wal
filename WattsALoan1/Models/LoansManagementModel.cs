namespace WattsALoan1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LoansManagementModel : DbContext
    {
        public LoansManagementModel()
            : base("name=LoansManagementModel")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<LoanContract> LoanContracts { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
