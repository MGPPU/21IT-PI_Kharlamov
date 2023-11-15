namespace Task_4
{

    public class Book
    {
        public Book(string Title, ushort PageСount)
        {
            this.Title = Title;
            this.PageСount = PageСount;
        }
        public string Title { get; set; }
        public ushort PageСount { get; set; }

    }

}