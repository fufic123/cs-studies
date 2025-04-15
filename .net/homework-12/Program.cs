using System;

class Program
{
    delegate void MenuAction();

    static void NewGame() {
        Console.WriteLine("\nЗапуск новой игры\n");
    }

    static void LoadGame() {
        Console.WriteLine("\nЗагрузка игры\n");
    }

    static void ShowRules() {
        Console.WriteLine("\nПравила игры\n");
    }

    static void AboutAuthor() {
        Console.WriteLine("\nАвтор: Марк Семенов\n");
    }

    static void Exit() {
        Console.WriteLine("\nВыход\n");
    }

    static void Main()
    {
        MenuAction[] actions = new MenuAction[5];
        actions[0] = NewGame;
        actions[1] = LoadGame;
        actions[2] = ShowRules;
        actions[3] = AboutAuthor;
        actions[4] = Exit;

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("0 - Новая игра");
            Console.WriteLine("1 - Загрузить игру");
            Console.WriteLine("2 - Правила");
            Console.WriteLine("3 - Об авторе");
            Console.WriteLine("4 - Выход");

            Console.WriteLine("пункт меню: ");
            string input = Console.ReadLine();
            int choice = Convert.ToInt32(input);
            
            if (choice >= 0 && choice <= 4)
            {
                actions[choice]();
                if (choice == 4)
                    break;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
