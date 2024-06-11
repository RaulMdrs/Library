namespace Library;

public class Loan
{
    public int UserId { get; set; }
    public ISBN BookIsbn { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime ReturnDate { get; set; }
    
    public Loan(int userId, ISBN bookIsbn, DateTime loanDate, DateTime returnDate)
    {
        UserId = userId;
        BookIsbn = bookIsbn;
        LoanDate = loanDate;
        ReturnDate = returnDate;
    }
    
    public void DisplayDetails()
    {
        Console.WriteLine("Usário: " + UserId + "\nLivro: " + BookIsbn.ToString() + "\nData de emprestimo: " + LoanDate + "\nData de devolução: " + ReturnDate);
    }
}