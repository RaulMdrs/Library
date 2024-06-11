using Library.Interfaces;

namespace Library;

public class LoanManager : ILoanManager
{
    private List<Loan> _loans = new List<Loan>();
    
    public void RegisterLoan(Loan loan)
    {
        if (loan.BookIsbn == null)
        {
            throw new ArgumentNullException("O ISBN não pode ser nulo");
        }
        if (loan.UserId == null)
        {
            throw new ArgumentNullException("O ID do usário não pode ser nulo");
        }
        if (FindLoan(loan.BookIsbn, loan.UserId) != null)
        {
            throw new ArgumentException("O ISBN informado ja foi emprestado");
        }

        _loans.Add(loan);
        Console.WriteLine("O empréstimo foi registrado com sucesso");
    }

    public void RegisterReturn(ISBN isbn, int userId)
    {
        if (isbn == null)
        {
            throw new ArgumentNullException("O ISBN não pode ser nulo");
        }
        if (userId == null)
        {
            throw new ArgumentNullException("O ID do usário não pode ser nulo");
        }
        if (FindLoan(isbn, userId) == null)
        {
            throw new ArgumentException("O ISBN informado não foi emprestado");
        }
        
        _loans.Remove(FindLoan(isbn, userId));
        
        Console.WriteLine("O empréstimo foi registrado com sucesso");
    }

    public void ListLoans()
    {
        if (_loans == null || _loans.Count == 0)
        {
            throw new ArgumentException("Nenhum empréstimo foi registrado");
        };
        Console.WriteLine("Todos os empréstimos: \n");
        _loans.ForEach(loan => loan.DisplayDetails());
    }

    public Loan FindLoan(ISBN isbn, int userId)
    {
        Console.WriteLine("Usário: " + userId + "\nLivro: " + isbn.ToString());
        return _loans.Find(loan => loan.BookIsbn == isbn && loan.UserId == userId);
    }
}