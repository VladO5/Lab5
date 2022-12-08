/*
namespace Lab5_1,2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 2");
            Console.WriteLine("Іерархія визову конструкторів");
            Bookshop bookshop = new Bookshop("Ivan", "Great");

            Console.WriteLine();

            Journal journal = new Journal("Jack", "Lopes", 199, true);

            Console.WriteLine();

            Book book = new Book("Vasya", "Morovin", 98, true);

            Console.WriteLine();

            Textbook textbook = new Textbook("Mya", "Strong", 98, true);

            Console.WriteLine();

            Console.WriteLine("Завдання 1 визов методу show");
            Console.WriteLine();

            Bookshop[] array = { bookshop, journal, book, textbook };

            foreach (Bookshop obj in array)
            {
                obj.show();
            }

        }
    }
}


class Bookshop
{
    public virtual bool availability { get; set; }
    public virtual int price { get; set; }
    public virtual string name { get; set; }
    public virtual string author { get; set; }

    public void show()
    {
        Console.WriteLine(name + " " + author + " " + price + " " + availability);
    }

    ~Bookshop()
    {
        Console.WriteLine("Деструтор магазину");
    }
    public Bookshop()
    {
        Console.WriteLine("Конструктор класу магазин");
        name = null;
        author = null;
        price = 0;
        availability = false;
    }

    public Bookshop(string name, string author)
    {
        Console.WriteLine("Конструктор класу магазин");
        this.name = name;
        this.author = author;
    }

    public Bookshop(string name, string author, int price, bool availability)
    {
        Console.WriteLine("Конструктор класу магазин");
        this.name = name;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

}

class Journal : Bookshop
{
    ~Journal()
    {
        Console.WriteLine("Деструтор журнал");
    }
    public Journal()
    {
        Console.WriteLine("Конструктор класу журнал");
        name = null;
        author = null;
        price = 0;
        availability = false;
    }

    public Journal(string name, string author) : base(name, author)
    {
        Console.WriteLine("Конструктор класу журнал");
        this.name = name;
        this.author = author;
    }

    public Journal(string name, string author, int price, bool availability) : base(name, author)
    {
        Console.WriteLine("Конструктор класу журнал");
        this.name = name;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

}

class Book : Journal
{

    ~Book()
    {
        Console.WriteLine("Деструтор книжка");
    }
    public Book()
    {
        Console.WriteLine("Конструктор класу книжка");
        name = null;
        author = null;
        price = 0;
        availability = false;
    }

    public Book(string name, string author) : base(name, author)
    {
        Console.WriteLine("Конструктор класу книжка");
        this.name = name;
        this.author = author;
    }
    public Book(string name, string author, int price, bool availability) : base(name, author, price, availability)
    {
        Console.WriteLine("Конструктор класу книжка");
        this.name = name;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

}

class Textbook : Book
{
    ~Textbook()
    {
        Console.WriteLine("Деструтор зошит");
    }
    public Textbook()
    {
        Console.WriteLine("Конструктор класу зошит");
        name = null;
        author = null;
        price = 0;
        availability = false;
    }

    public Textbook(string name, string author) : base(name, author)
    {
        Console.WriteLine("Конструктор класу зошит");
        this.name = name;
        this.author = author;
    }
    public Textbook(string name, string author, int price, bool availability) : base(name, author, price, availability)
    {
        Console.WriteLine("Конструктор класу зошит");
        this.name = name;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }
}
*/

namespace Lab5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Good good1 = new Good("Молоко", 199, 2022, 10, 11, 2022, 11, 12);
            Good good2 = new Good("Хліб", 59, 2022, );
            Good good3 = new Good("Кефір", 59, );
            Batch batch1 = new Batch();
            Batch batch2 = new Batch();
            Batch batch3 = new Batch();
            Sets sets1 = new Sets();
            Sets sets2 = new Sets();
            Sets sets3 = new Sets();

            Tovar[] array = { good1, batch1, good2, sets3, good3, sets2, batch2, batch3, sets1 };

            Console.WriteLine();
            Console.WriteLine("Шукаємо в масиві обектів Товар Продукт");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].findThisTovar(good1))
                {
                    Console.Write(i + " ");
                    array[i].show();
                };
            }

            Console.WriteLine();
            Console.WriteLine("Шукаємо в масиві обектів Товар Партію");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].findThisTovar(batch1))
                {
                    Console.Write(i + " ");
                    array[i].show();
                };
            }

            Console.WriteLine();
            Console.WriteLine("Шукаємо в масиві обектів Товар Комплект");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].findThisTovar(sets1))
                {
                    Console.Write(i + " ");
                    array[i].show();
                };
            }
        }
    }
}

abstract class Tovar
{
    public abstract void show();
    public virtual bool findThisTovar(Tovar tovar)
    {
        if (tovar is Tovar tovar1)
        {
            return true;
        }
        else return false;
    }
}

class Good : Tovar
{
    string name;
    int price;
    DateTime creationdate;
    DateTime expiredate;

    public Good(string name, int price, DateTime creationdate, DateTime expiredate)
    {
        this.name = name;
        this.price = price;
        this.creationdate = creationdate;
        this.expiredate = expiredate;
    }

    public override bool findThisTovar(Tovar tovar)
    {
        if (tovar is Good good)
        {
            return true;
        }
        else return false;
    }

    public override void show()
    {
        Console.WriteLine("Ім'я : " + name + " Ціна " + price + " Дата створення : " + creationdate + " Дата просрочки : " + expiredate);
    }
}

class Batch : Tovar
{
    string name;
    int price;
    DateTime creationdate;
    DateTime expiredate;
    int number;
    public Batch(string name, int price, DateTime creationdate, DateTime expiredate, int number)
    {
        this.name = name;
        this.price = price;
        this.creationdate = creationdate;
        this.expiredate = expiredate;
        this.number = number;
    }

    public override void show()
    {
        Console.WriteLine("Ім'я : " + name + " Ціна " + price + " Дата створення : " + creationdate + " Дата просрочки : " + expiredate + " Кількість партій" + number);
    }

    public override bool findThisTovar(Tovar tovar)
    {
        if (tovar is Batch batch)
        {
            return true;
        }
        else return false;
    }
}


class Sets : Tovar
{
    string name;
    int price;
    string listofproducts;

    public Sets(string name, int price, string listofproducts)
    {
        this.name = name;
        this.price = price;
        this.listofproducts = listofproducts;
    }

    public override void show()
    {
        Console.WriteLine("Назва : " + name + " Ціна " + price + " Список товарів " + listofproducts);
    }

    public override bool findThisTovar(Tovar tovar)
    {
        if (tovar is Sets sets)
        {
            return true;
        }
        else return false;
    }
}