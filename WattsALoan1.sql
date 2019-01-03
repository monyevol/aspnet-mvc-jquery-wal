CREATE TABLE Employees
(
	EmployeeId	    INT IDENTITY(1, 1),
	EmployeeNumber  NVARCHAR(10) UNIQUE,
	FirstName	    NVARCHAR(20),
	LastName        NVARCHAR(20),
	EmploymentTitle NVARCHAR(50),
	CONSTRAINT PK_Employees PRIMARY KEY(EmployeeId)
);
GO
CREATE TABLE LoanContracts
(
	LoanContractId	  INT IDENTITY(1, 1),
	LoanNumber        INT UNIQUE NOT NULL,
	DateAllocated	  NVARCHAR(40),
	EmployeeId	      INT,
	CustomerFirstName NVARCHAR(20),
	CustomerLastName  NVARCHAR(20),
	LoanType		  NVARCHAR(20),
	LoanAmount		  NVARCHAR(10),
	InterestRate	  NVARCHAR(10),
	[Periods]	      INT,
	MonthlyPayment	  NVARCHAR(10),
	FutureValue	      NVARCHAR(10),
	InterestAmount	  NVARCHAR(10),
	PaymentStartDate  NVARCHAR(40),
	CONSTRAINT PK_LoansContracts PRIMARY KEY(LoanContractId)
);
GO
CREATE TABLE Payments
(
	PaymentId	   INT IDENTITY(1, 1),
	ReceiptNumber  INTEGER,
	PaymentDate	   NVARCHAR(40),
	EmployeeId     INT,
	LoanContractId INT,
	PaymentAmount  NVARCHAR(10),
	Balance		   NVARCHAR(10),
	CONSTRAINT PK_Payments PRIMARY KEY(PaymentId)
);
GO