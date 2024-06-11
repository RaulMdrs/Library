namespace Library;

public class BooksController
{
    public Library Books = new Library();
    
    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("------------------ LIVROS ------------------");
        Console.WriteLine("1. Adicionar");
        Console.WriteLine("2. Remover");
        Console.WriteLine("3. Buscar");
        Console.WriteLine("4. Listar");
        Console.WriteLine("5. Voltar");
        Console.WriteLine("--------------------------------------------");
        Console.Write("Escolha uma opção: ");
        int option = int.Parse(Console.ReadLine());
        OnSelectOption(option);
    }
    
    public void OnSelectOption(int option)
    {
        switch (option)
        {
            case 1:
                Console.WriteLine("Adicionar");
                AddBook();
                break;
            case 2:
                Console.WriteLine("Remover");
                RemoveBook();
                break;
            case 3:
                Console.WriteLine("Buscar");
                FindBook();
                break;
            case 4:
                Console.WriteLine("Listar");
                ListBooks();
                break;
            case 5:
                Console.WriteLine("Voltar");
                break;
            default:
                Console.WriteLine("Opcao inválida");
                break;
        }
    }
    
    private void AddBook()
    {
        Console.WriteLine("Para adicionarmos preciso saber:");
        Console.Write("Título: ");
        string title = Console.ReadLine();
        Console.Write("Autor: ");
        string author = Console.ReadLine();
        Console.Write("Ano de publicação: ");
        string publicationYear = Console.ReadLine();
        Console.Write("Paginas: ");
        int pages = int.Parse(Console.ReadLine());
        Console.Write("Editora: ");
        string publisher = Console.ReadLine();
        Console.Write("Identificação do título: ");
        string titleIdentification = Console.ReadLine();
        
        Book book = new Book(title, Constants.authors[author], Constants.countries["Brasil"], publicationYear, pages, Constants.publishers[publisher], titleIdentification);
        Books.AddBook(book);
    }
    
    private void RemoveBook()
    {
        Books.DisplayNameAndIsbn();
        Console.Write("Qual o Isbn do livro que deseja remover: ");
        string isbn = Console.ReadLine();
        Books.RemoveBook(Books.FindBook(isbn));
    }
    
    private void ListBooks()
    {
        Books.ListBooks();
    }

    private void FindBook()
    {
        Console.Write("Qual o Isbn do livro que deseja encontrar: ");
        string isbn = Console.ReadLine();
        Books.FindBook(isbn);
    }
}