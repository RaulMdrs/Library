using Library.Interfaces;
namespace Library;

public class Library : IBookManager
{
    List<Book> Books = new List<Book>();

    public Library()
    {
        Books.Add(new Book("O Hobbit", Constants.authors["J.R.R. Tolkien"], Constants.countries["Japão"], "1937", 
            310, Constants.publishers["Editora Biruta"], "723"));
        Books.Add(new Book("Harry Potter", Constants.authors["J.K. Rowling"], Constants.countries["Brasil"], "1090", 
            123, Constants.publishers["Saraiva"], "069"));
        Books.Add(new Book("Constantinopla", Constants.authors["J.R.R. Tolkien"], Constants.countries["Espanha"], "1937", 
            424, Constants.publishers["Axcel Books"], "123"));
    }
    
    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    
    public void RemoveBook(Book book)
    {
        foreach (var b in Books)
        {
            if (b.ISBN == book.ISBN)
            {
                Books.Remove(b);
                break;
            }
        }
    }
    
    public Book FindBook(string isbn)
    {   
        foreach (var book in Books)
        {
            if (book.ISBN == isbn)
            {
                book.DisplayDetails();
                return book;
            }
        }
        Console.WriteLine("Livro não encontrado");
        Console.ReadKey();
        return null;
    }
    
    public void ListBooks()
    {
        Console.Clear();
        Console.WriteLine("------------------ LIVROS ------------------");
        Console.WriteLine("Títulos:" + Books.Count);
        Console.WriteLine("____________________________");
        
        foreach (var book in Books)
        {
            book.DisplayDetails();
            Console.WriteLine("____________________________");
            Console.ReadKey();
        }
    }

    public void DisplayNameAndIsbn()
    {
        foreach (var book in Books)
        {
            book.DisplayNameAndIsbn();
            Console.WriteLine("____________________________");
        }
        Console.ReadKey();
    }
    
}
