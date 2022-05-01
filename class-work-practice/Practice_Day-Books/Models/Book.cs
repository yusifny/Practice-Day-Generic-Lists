namespace Practice_Day_Books.Models
{
    class Book
    {
        private static int _counter = 10;

        private int _pageCount;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount 
        {
            get => _pageCount;
            set
            {
                if (value>0)
                {
                    _pageCount = value;
                }
            }
        }
        public string Code { get; set; }

        public Book(string name, string authorName, int pageCount)
        {
            _counter++;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = Name.Substring(0, 2).ToUpper() + _counter;
        }
    }
}
