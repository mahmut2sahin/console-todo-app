using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_todo_app
{
    public static class CardListingOps
    {
        public static void PrintCardWithoutLine(Card card)
        {
            Console.WriteLine("Başlık: " + card.Header);
            Console.WriteLine("İçerik: " + card.Desc);
            Console.WriteLine("Atanan Kişi: " + card.AppointedTo.NameSurname);
            Console.WriteLine("Büyüklük: " + (Sizes)card.Size);
        }

        public static void PrintOneCard(Card card)
        {
            Console.WriteLine("Başlık: " + card.Header);
            Console.WriteLine("İçerik: " + card.Desc);
            Console.WriteLine("Atanan Kişi: " + card.AppointedTo.NameSurname);
            Console.WriteLine("Büyüklük: " + (Sizes)card.Size);
            Console.WriteLine("Line: " + card.Line);
        }

        public static void ListBoard(List<Card> cards)
        {
            int i = 0;
            Console.WriteLine("TODO Line");
            Console.WriteLine("***************");
            foreach (var card in cards)
            {
                if (card.Line == "TODO")
                {
                    PrintCardWithoutLine(card);
                    Console.WriteLine("-");
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }

            i = 0;
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("***************");
            foreach (var card in cards)
            {
                if (card.Line == "IN PROGRESS")
                {
                    PrintCardWithoutLine(card);
                    Console.WriteLine("-");
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }

            i = 0;
            Console.WriteLine("DONE Line");
            Console.WriteLine("***************");
            foreach (var card in cards)
            {
                if (card.Line == "DONE")
                {
                    PrintCardWithoutLine(card);
                    Console.WriteLine("-");
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
        }

    }
}
