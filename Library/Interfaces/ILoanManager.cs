namespace Library.Interfaces;

public interface ILoanManager
{
    void RegisterLoan(Loan loan);
    void RegisterReturn(ISBN isbn, int userId);
    void ListLoans();
    Loan FindLoan(ISBN isbn, int userId);
}