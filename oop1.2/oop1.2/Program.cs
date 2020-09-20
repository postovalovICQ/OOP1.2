using System;

namespace oop1._2
{
    class Program
    {
        class Member
        {
            internal int Id;
            public string Surname;
            public string Name;
            public string Patronymic;
            internal string Address;
            internal string Creditcard;
            internal string Time;
        }
        static void Main(string[] args)
        {
            Member Member = new Member();
            Console.WriteLine("Введите данные абонента");

            Console.Write("Введите идентификационный номер: ");
            Member.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите фамилию: ");
            Member.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Введите имя: ");
            Member.Surname = Convert.ToString(Console.ReadLine());

            Console.Write("Введите отчество: ");
            Member.Patronymic = Convert.ToString(Console.ReadLine());

            Console.Write("Введите адресс: ");
            Member.Address = Convert.ToString(Console.ReadLine());

            Console.Write("Номер кредитной карточки: ");
            Member.Creditcard = Convert.ToString(Console.ReadLine());

            Console.Write("Введите время междугородных и городских переговоров: ");
            Member.Time = Convert.ToString(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
            Console.WriteLine(Member.Id);
            Console.WriteLine(Member.Surname);
            Console.WriteLine(Member.Name);
            Console.WriteLine(Member.Patronymic);
            Console.WriteLine(Member.Address);
            Console.WriteLine(Member.Creditcard);
            Console.WriteLine(Member.Time);
            Console.WriteLine("------------------------");
            Console.ReadLine();

        }
    }
}
