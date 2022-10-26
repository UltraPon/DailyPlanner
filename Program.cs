namespace DailyPlanner
{
    internal class Program
    {
        static DateTime date = DateTime.Now;
        static ConsoleKeyInfo tap = Console.ReadKey();
        static int z = 0;
        static void Main()
        {
            string FirstDate = date.ToShortDateString();
            int z = 0;
            int pos = 2;
            Arrow(z, pos, FirstDate);
        }
        static void Arrow(int z, int pos, string FirstDate)
        {
            ConsoleKeyInfo tap = Console.ReadKey();
            while (tap.Key != ConsoleKey.Escape)
            {
                if (tap.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos <= 1)
                    {
                        pos = 2;
                        Console.SetCursorPosition(0, pos);
                    }

                }
                else if (tap.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                }
                Console.Clear();
                Console.WriteLine(FirstDate);
                Console.WriteLine("-", 30);
                swap(pos, FirstDate);
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                tap = Console.ReadKey();
                if (tap.Key == ConsoleKey.LeftArrow || tap.Key == ConsoleKey.RightArrow)
                {
                    Date(FirstDate, pos);
                }
            }
        }
//
//
//
//
//
        static void Date(string FirstDate, int pos)
        {
            tap = Console.ReadKey();
            if (tap.Key == ConsoleKey.LeftArrow)
            {
                date = date.AddDays(-1);
                FirstDate = date.ToShortDateString();
                Main();
            }
            else if (tap.Key == ConsoleKey.RightArrow)
            {
                date = date.AddDays(1);
                FirstDate = date.ToShortDateString();
                Main();
            }

        }
//
//
//
//
//
        static void Note(string FirstDate)
        {
            List<string> note = new List<string>();
            note.Add("  1. Пары. ");
            foreach (string a in note)
                Console.WriteLine(a);
        }
        static void SecondNote(string FirstDate)
        {
            List<string> note = new List<string>();
            note.Add("  1. Дота. ");
            note.Add("  2. практическая C#. ");
            foreach (string a in note)
                Console.WriteLine(a);
        }
        static void ThirdNote(string FirstDate)
        {
            List<string> note = new List<string>();
            note.Add("  1. Дота. ");
            note.Add("  2. ААС. ");
            foreach (string a in note)
                Console.WriteLine(a);
        }
        //
        //
        //
        //
        //
        static void Description(int pos)
        {
            List<string> desc = new List<string>();
            desc.Add("Прийти на пары. ");
            desc.Add("------------------------------");
            desc.Add("  Описание: Отсидеть все пары. ");
            desc.Add("  Дата: 28.10.2022 12:00:00 ");
            Console.Clear();
            foreach (string a in desc)
                Console.WriteLine(a);
        }
        static void FirstDescription(int pos)
        {
            List<string> desc = new List<string>();
            desc.Add("Поиграть в доту. ");
            desc.Add("------------------------------");
            desc.Add("  Описание: Поиграть в доту с кентиками. ");
            desc.Add("  Дата: 30.10.2022 11:00:00 ");
            Console.Clear();
            foreach (string a in desc)
                Console.WriteLine(a);
        }
        static void SecondDescription(int pos)
        {
            List<string> desc = new List<string>();
            desc.Add("Начать делать 'тортики'. ");
            desc.Add("------------------------------");
            desc.Add("  Описание: Начать делать практическую работу по C#. ");
            desc.Add("  Дата: 30.10.2022 19:00:00 ");
            Console.Clear();
            foreach (string a in desc)
                Console.WriteLine(a);
        }
        static void ThirdDescription(int pos)
        {
            List<string> desc = new List<string>();
            desc.Add("Дота ");
            desc.Add("------------------------------");
            desc.Add("  Описание: Сегодня обязательно нужно добить 4к. ");
            desc.Add("  Дата: 01.11.2022 11:00:00 ");
            Console.Clear();
            foreach (string a in desc)
                Console.WriteLine(a);
        }
        static void FourthDescription(int pos)
        {
            List<string> desc = new List<string>();
            desc.Add("ААС. ");
            desc.Add("------------------------------");
            desc.Add("  Описание: Подготовиться к опросу по ААС. ");
            desc.Add("  Дата: 01.11.2022 19:00:00 ");
            Console.Clear();
            foreach (string a in desc)
                Console.WriteLine(a);
        }
        //
        //
        //
        //
        //
        static void swap(int pos, string FirstDate)
        {
            if (FirstDate == "28.10.2022")
            { 
                Note(FirstDate);
                if (pos == 2 && tap.Key == ConsoleKey.Enter)
                {
                    Description(pos);
                }
            }
            else if (FirstDate == "30.10.2022")
            {
                SecondNote(FirstDate);
                if (pos == 2 && tap.Key == ConsoleKey.Enter)
                {
                    FirstDescription(pos);
                }
                else if (pos == 3 && tap.Key == ConsoleKey.Enter)
                {
                    SecondDescription(pos);
                }
            }
            else if (FirstDate == "01.11.2022")
            {
                ThirdNote(FirstDate);
                if (pos == 2 && tap.Key == ConsoleKey.Enter)
                {
                    ThirdDescription(pos);
                }
                else if (pos == 3 && tap.Key == ConsoleKey.Enter)
                {
                    FourthDescription(pos);
                }
            }
            Date(FirstDate, pos);
        }
    }
}