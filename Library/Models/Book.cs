namespace Library;

public class Book
{
    public Author Author { get; set; }
    public Country Country { get; set; }
    public Publisher Publisher { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string PublicationYear { get; set; }
    public int Pages { get; set; }
    public string TitleIdentification { get; set; }
    #region Methods
    public Book(string title, Author author, Country country, string publicationYear, int pages, Publisher publisher, string titleIdentification)
    {
        Title = title;
        Author = author;
        Country = country;
        PublicationYear = publicationYear;
        Publisher = publisher;
        Pages = pages;
        TitleIdentification = titleIdentification;
        ISBN = new ISBN(country.CodeIsbn, publisher.CodeIsbn, titleIdentification, "2").GetIsbn();
    }
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Título: " + Title);
        Console.WriteLine("Autor: " + Author.Name);
        Console.WriteLine("Ano de publicação: " + PublicationYear);
        Console.WriteLine("ISBN: " + ISBN);
        Console.ReadKey();
    }

    public void DisplayNameAndIsbn()
    {
        Console.WriteLine("Título: " + Title + " ISBN: " + ISBN);
    }
    #endregion
}