using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace console_todo_app
{
    public class MenuDesc
    {
        public void AddCardAppointedTo()
        {
            Console.Write("Kişi Seçiniz(ID'yi girin): ");
        }

        public void AddCardDesc()
        {
            Console.Write("İçerik Giriniz: ");
        }

        public void AddCardHeader()
        {
            Console.Write("Başlık Giriniz: ");
        }

        public void AddCardSize()
        {
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
        }

        public void DeleteInput()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
        }

        public void DeleteNotFound()
        {
            Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
            Console.WriteLine("* Yeniden denemek için: (2)");
        }

        public void MainMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
        }

        public void MoveInput()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
        }

        public void MoveNotFound()
        {
            Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Taşımayı sonlandırmak için: (1)");
            Console.WriteLine("* Yeniden denemek için: (2)");
        }
        public void AskWhichLine()
        {
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");
        }
    }
}
