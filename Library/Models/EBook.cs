namespace Library;

public class EBook : Book
{
    public float FileSize { get; set; }
    public string FileFormat { get; set; }
    
    public EBook(string title, Author author, Country country, string publicationYear, float fileSize, string fileFormat, int pages, Publisher publisher, string titleIdentification) : base(title, author, country, publicationYear, pages, publisher, titleIdentification)
    {
        FileSize = fileSize;
        FileFormat = fileFormat;
    }
    
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Tamanho do arquivo: " + FileSize + " MB");
        Console.WriteLine("Formato do arquivo: " + FileFormat);
    }
}