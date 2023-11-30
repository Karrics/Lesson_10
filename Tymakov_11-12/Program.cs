using System;

namespace Tymakov_11_12
{
    internal enum BankAccountType
    {
        Current,
        Savings
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 11.1");
            BankAccountFactory accountFactory = new BankAccountFactory();

            // Создание счета с помощью фабрики
            int accountNumber1 = accountFactory.CreateAccount(1000m, BankAccountType.Current);
            Console.WriteLine("Номер первого счёта: " + accountNumber1);

            // Создание другого счета с помощью фабрики
            int accountNumber2 = accountFactory.CreateAccount(5000m, BankAccountType.Savings);
            Console.WriteLine("Номер второго счёта: " + accountNumber2);

            // Закрытие счета
            accountFactory.CloseAccount(accountNumber1);

            // Попытка закрыть несуществующий счет
            accountFactory.CloseAccount(999);

            // Получение следующего доступного номера счета
            int nextAccountNumber = accountFactory.GetNextAccountNumber();
            Console.WriteLine("Следующий номер счёта: " + nextAccountNumber);
            Console.WriteLine();

            
            Console.WriteLine("Упр 11.2");
            Console.WriteLine();


            Console.WriteLine("Упр 11.3");
            Building building1 = Creator.CreateBuild(1, 50, 10, 100, 2);
            Building building2 = Creator.CreateBuild(2, 60, 12, 120, 3);

            Console.WriteLine($"Здание 1 номер: {building1.GetBuildingNumber()}");
            Console.WriteLine($"Здание 1 высота: {building1.GetHeight()}");

            Console.WriteLine($"Здание 2 номер: {building2.GetBuildingNumber()}");
            Console.WriteLine($"Здание 2 высота: {building2.GetHeight()}");

            Creator.RemoveBuilding(1);

            // Попытка получить доступ к удалённому зданию
            Building removedBuilding = Creator.CreateBuild(1, 70, 15, 150, 4);
            Console.WriteLine($"Номер удалённого здания: {removedBuilding.GetBuildingNumber()}");
            Console.WriteLine();


            Console.WriteLine("Упр 11.4");
            Console.WriteLine();


            Console.WriteLine("Упр 12.1");
            BankAccount account7 = new BankAccount(500m, BankAccountType.Savings);
            BankAccount account8 = new BankAccount(400m, BankAccountType.Savings);
            BankAccount account9 = new BankAccount(600m, BankAccountType.Savings);

            Console.WriteLine(account7 == account8);  // Вывод: False
            Console.WriteLine(account7 != account9);  // Вывод: True

            Console.WriteLine(account7.Equals(account8));  // Вывод: False
            Console.WriteLine(account7.Equals(account9));  // Вывод: False

            Console.WriteLine(account7.ToString());
            Console.WriteLine();


            Console.WriteLine("Упр 12.2");
            // Создание двух рациональных чисел
            RationalNumber a = new RationalNumber(1, 2);
            RationalNumber b = new RationalNumber(3, 4);

            // Проверка операторов сравнения
            bool isEqual = a == b;
            bool isNotEqual = a != b;
            bool isLessThan = a < b;
            bool isGreaterThan = a > b;
            bool isLessThanOrEqual = a <= b;
            bool isGreaterThanOrEqual = a >= b;

            Console.WriteLine($"a == b: {isEqual}");  // false
            Console.WriteLine($"a != b: {isNotEqual}");  // true
            Console.WriteLine($"a < b: {isLessThan}");  // true
            Console.WriteLine($"a > b: {isGreaterThan}");  // false
            Console.WriteLine($"a <= b: {isLessThanOrEqual}");  // true
            Console.WriteLine($"a >= b: {isGreaterThanOrEqual}");  // false

            // Проверка операторов арифметических операций
            RationalNumber sum = a + b;
            RationalNumber difference = a - b;
            RationalNumber product = a * b;
            RationalNumber quotient = a / b;
            RationalNumber remainder = a % b;

            Console.WriteLine($"a + b: {sum}");  // 5/4
            Console.WriteLine($"a - b: {difference}");  // -1/4
            Console.WriteLine($"a * b: {product}");  // 3/8
            Console.WriteLine($"a / b: {quotient}");  // 2/3
            Console.WriteLine($"a % b: {remainder}");  // 1/2

            // Проверка операторов инкремента и декремента
            RationalNumber c = new RationalNumber(2, 3);
            RationalNumber incremented = c++;
            RationalNumber decremented = c--;

            Console.WriteLine($"c++: {incremented}");  // 2/3
            Console.WriteLine($"c--: {decremented}");  // 5/3

            // Проверка операторов преобразования типов
            float floatValue = (float)a;
            int intValue = (int)b;

            Console.WriteLine($"(float)a: {floatValue}");  // 0.5
            Console.WriteLine($"(int)b: {intValue}");  // 0
            Console.WriteLine();


            Console.WriteLine("Упр 12.3");
            Complex c1 = new Complex(2, 3);
            Complex c2 = new Complex(4, -1);

            Console.WriteLine($"c1 = {c1}");
            Console.WriteLine($"c2 = {c2}");

            Complex sum1 = c1 + c2;
            Complex difference1 = c1 - c2;
            Complex product1 = c1 * c2;

            Console.WriteLine($"c1 + c2 = {sum1}");
            Console.WriteLine($"c1 - c2 = {difference1}");
            Console.WriteLine($"c1 * c2 = {product1}");

            Console.WriteLine($"c1 == c2: {c1 == c2}");
            Console.WriteLine($"c1 != c2: {c1 != c2}");
            Console.WriteLine();


            Console.WriteLine("Упр 12.4");
            BookContainer container = new BookContainer();

            container.AddBook(new Book("Книга 'Гарри Поттер и кубок огня'", "Автор: Дж.Роулинг", "Издатель АСТ"));
            container.AddBook(new Book("Книга 'Мёртвые души'", "Автор: Гоголь", "Издатель АСТ"));
            container.AddBook(new Book("Книга '1984'", "Автор: Джордж Оруэлл", "Издатель АСТ"));

            Console.WriteLine("Книги до сортировки:");
            container.PrintBooks();
            Console.WriteLine();
            // Создаем экземпляр делегата, который будет сравнивать книги по полю 'Название'
            Comparison<Book> sortByTitle = (book1, book2) => book1.Title.CompareTo(book2.Title);

            // Сортировка книг по названию
            container.SortBooks(sortByTitle);
            Console.WriteLine("Книги после сортировки по названию:");
            container.PrintBooks();
            Console.WriteLine();

            // Создаем экземпляр делегата, который будет сравнивать книги по полю 'Автор'
            Comparison<Book> sortByAuthor = (book1, book2) => book1.Author.CompareTo(book2.Author);

            // Сортировка книг по автору
            container.SortBooks(sortByAuthor);
            Console.WriteLine("Книги отсартированные по автору:");
            container.PrintBooks();
            Console.WriteLine();

            // Создаем экземпляр делегата, который будет сравнивать книги по полю 'Издательство'
            Comparison<Book> sortByPublisher = (book1, book2) => book1.Publisher.CompareTo(book2.Publisher);

            // Сортировка книг по издательству
            container.SortBooks(sortByPublisher);
            Console.WriteLine("Сортировка по издателю:");
            container.PrintBooks();
            Console.ReadKey();
        }
    }
}
