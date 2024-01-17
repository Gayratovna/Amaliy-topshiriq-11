using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliy_topshiriq_11
{
    public class AvtomatlashtirilganTizim
    {
        private List<Poezd> poezdlar = new List<Poezd>();

        public void MalumotKiritish(string raqam, string yonalish, string vaqt)
        {
            Poezd poezd = new Poezd { Raqam = raqam, Yonalish = yonalish, Vaqt = vaqt };
            poezdlar.Add(poezd);
        }

        public void DaraxtChiqarish()
        {
            foreach (var poezd in poezdlar)
            {
                Console.WriteLine($"Poezd raqami: {poezd.Raqam}, Yo'nalishi: {poezd.Yonalish}, Ketish vaqti: {poezd.Vaqt}");
            }
        }

        public void PoezdMalumotlari(string raqam)
        {
            Poezd poezd = poezdlar.Find(p => p.Raqam == raqam);
            if (poezd != null)
            {
                Console.WriteLine($"Poezd raqami: {poezd.Raqam}, Yo'nalishi: {poezd.Yonalish}, Ketish vaqti: {poezd.Vaqt}");
            }
            else
            {
                Console.WriteLine($"{raqam} raqamli poezd topilmadi.");
            }
        }
    }
}
