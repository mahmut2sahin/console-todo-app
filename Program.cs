using System;
using System.Collections.Generic;

namespace console_todo_app
{
    class Program
    {
        static void Main()
        {
            MemberRepo memberRepo = new();
            List<Member> members = memberRepo.GetMembers();

            CardRepo cardRepo = new CardRepo(members);
            MenuDesc menu = new(); // ??

            while (true)
            {
                menu.MainMenu();
                switch (Console.ReadLine())
                {
                    case "1":
                        CardListingOps.ListBoard(cardRepo.GetAllCards());
                        break;
                    case "2":
                        cardRepo.AddCard();
                        break;
                    case "3":
                        cardRepo.DeleteCard();
                        break;
                    case "4":
                        cardRepo.ChangeCardLine();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                Console.Write("Ekranı temizle? (y/n)");
                if (Console.ReadLine() == "y")
                {
                    Console.Clear();
                }
            }
        }
    }
}
