namespace Task_4
{

    public class BookList : List<Book>
    {
        public void PrintSortedBooks()
        {
            // Расположить книги толще чем 20 стр. по алфавиту по свойству «Название»
            var LINQ = from book in this where book.PageСount > 20 orderby book.Title select book;

            // Решил сделать вывод результата в виде таблицы.
            Console.WriteLine(new string('-', 80 + 15 + 3));
            Console.WriteLine("|{0,80}|{1,15}|", "Название", "Кол-во стр.");
            Console.WriteLine(new string('-', 80 + 15 + 3));

            foreach (Book book in LINQ)
            {
                Console.WriteLine("|{0,80}|{1,15}|", book.Title, book.PageСount);
            }

            Console.WriteLine(new string('-', 80 + 15 + 3));

        }
    }

}