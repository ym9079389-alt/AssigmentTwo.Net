namespace AssigmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question One
            //int pages = 464;
            //bool isAvailable = true;
            //if(pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region Question Two
            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Question Three
            //int pages = 464;
            //string res = pages <= 300 ? "Short Book" : "Long Book";
            //Console.WriteLine(res);
            #endregion

            #region Question Four
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(books[i]);
            //}
            #endregion

            #region Question Five
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine(books[count]);
                count++;
            }
            #endregion
        }
    }
}
