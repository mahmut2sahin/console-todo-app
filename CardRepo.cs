using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace console_todo_app
{
    public class CardRepo
    {
        MenuDesc menu = new();
        MemberRepo memberRepo = new();
        List<Card> cards = new List<Card>();
        public CardRepo(List<Member> members)
        {
            cards.Add(new Card
            {
                Header = "Kampa Git",
                Desc = "Uludağ kampına git",
                AppointedTo = members[0],
                Size = (int)Sizes.XL,
                Line = "TODO"
            });
            cards.Add(new Card
            {
                Header = "Ödevi Yap",
                Desc = "Ödevi yarına kadar yap",
                AppointedTo = members[1],
                Size = (int)Sizes.M,
                Line = "IN PROGRESS"
            });
            cards.Add(new Card
            {
                Header = "Parayı Yatır",
                Desc = "Kirayı yatırmayı unutma",
                AppointedTo = members[2],
                Size = (int)Sizes.L,
                Line = "DONE"
            });
        }

        public Card FindCard(string header)
        {
            return cards.FirstOrDefault(i => i.Header == header);
        }

        public void DeleteCard()
        {
            menu.DeleteInput();
            string header = Console.ReadLine();
            List<Card> toRemove = cards.FindAll(i => i.Header == header);
            if (toRemove.Count == 0)
            {
                menu.DeleteNotFound();
                if (Console.ReadLine() == "2")
                {
                    DeleteCard();
                }
            }
            else
            {
                toRemove.ForEach(i => cards.Remove(i));
            }

        }

        public void AddCard()
        {
            menu.AddCardHeader();
            string header = Console.ReadLine();
            menu.AddCardDesc();
            string desc = Console.ReadLine();
            menu.AddCardSize();
            int sizeId = Convert.ToInt32(Console.ReadLine());
            menu.AddCardAppointedTo();
            int memberId = Convert.ToInt32(Console.ReadLine());
            var member = memberRepo.GetMemberById(memberId);
            if (member == null)
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
            }
            else
            {
                cards.Add(new Card
                {
                    Header = header,
                    Desc = desc,
                    Size = sizeId,
                    AppointedTo = member,
                    Line = "TODO"
                });
            }
        }

        public void ChangeCardLine()
        {
            menu.MoveInput();
            var card = FindCard(Console.ReadLine());
            if (card == null)
            {
                menu.MoveNotFound();
                if (Console.ReadLine() == "2")
                {
                    ChangeCardLine();
                }
            }
            else
            {
                Console.WriteLine("Bulunan Kart Bilgileri");
                Console.WriteLine("*********************************");
                CardListingOps.PrintOneCard(card);
                menu.AskWhichLine();
                switch (Console.ReadLine())
                {
                    case "1":
                        card.Line = "TODO";
                        break;
                    case "2":
                        card.Line = "IN PROGRESS";
                        break;
                    case "3":
                        card.Line = "DONE";
                        break;
                    default:
                        break;
                }
            }
        }

        public List<Card> GetAllCards()
        {
            return cards;
        }
    }
}
