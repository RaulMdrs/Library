namespace Library;

public static class Constants
{
    public static Dictionary<string, Country> countries = new Dictionary<string, Country>
    {
        { "Brasil", new Country("Brasil", "85") },
        { "Estados Unidos", new Country("Estados Unidos", "0") },
        { "Alemanha", new Country("Alemanha", "3") },
        { "Japão", new Country("Japão", "4") },
        { "França", new Country("França", "2") },
        { "China", new Country("China", "7") },
        { "Rússia", new Country("Rússia", "5") },
        { "Itália", new Country("Itália", "88") },
        { "Espanha", new Country("Espanha", "84") },
        { "Reino Unido", new Country("Reino Unido", "0") }
    };
    
    public static Dictionary<string, Publisher> publishers = new Dictionary<string, Publisher>
    {
        { "Axcel Books", new Publisher("Axcel Books", "1243") },
        { "Saraiva", new Publisher("Saraiva", "6636") },
        { "Editora Biruta", new Publisher("Editora Biruta", "2184") },
        { "Editora Ogitrov Analog", new Publisher("Editora Ogitrov Analog", "5389") }
    };
    
    public static Dictionary<string, Author> authors = new Dictionary<string, Author>
    {
        { "J.K. Rowling", new Author("J.K. Rowling", 56, "Japão") },
        { "J.R.R. Tolkien", new Author("J.R.R. Tolkien", 32, "Inglaterra") },
        { "Raul", new Author("Raul", 24, "Brasil") },
        { "João", new Author("João", 24, "Brasil") }
        
    };
    
}