namespace Library
{
    public class ISBN
    {
        private string Country { get; }
        private string BookMaker { get; }
        private string Title { get; }
        private string CodeVerification { get; }
        private string BaseIsbn { get; }
        
        public ISBN(string country, string bookMaker, string title, string codeVerification)
        {
            if (string.IsNullOrEmpty(country) || 
                string.IsNullOrEmpty(bookMaker) || 
                string.IsNullOrEmpty(title) || 
                string.IsNullOrEmpty(codeVerification))
            {
                throw new ArgumentException("Nenhum dos parâmetros pode ser nulo ou vazio.");
            }
            
            BaseIsbn = "987";
            Country = country;
            BookMaker = bookMaker;
            Title = title;
            CodeVerification = codeVerification;
        }
        
        public override string ToString()
        {
            return $"{BaseIsbn}-{Country}-{BookMaker}-{Title}-{CodeVerification}";
        }
        
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        
        public string GetIsbn()
        {
            return ToString();
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is ISBN isbnCompare)
            {
                return Country == isbnCompare.Country &&
                       BookMaker == isbnCompare.BookMaker &&
                       Title == isbnCompare.Title &&
                       CodeVerification == isbnCompare.CodeVerification; 
            }
            if (obj is string stringCompare)
            {
                return ToString() == stringCompare;
            }
            
            return false;
        }
        
        public override int GetHashCode()
        {
            return HashCode.Combine(Country, BookMaker, Title, CodeVerification);
        }
    }
}
