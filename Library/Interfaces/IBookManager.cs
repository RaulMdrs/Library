namespace Library.Interfaces;

public interface IBookManager
{
    void AddBook(Book book);
    void RemoveBook(Book book);
    Book FindBook(string isbn);
    void ListBooks();
}