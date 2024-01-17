using Amaliy_topshiriq_11;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        AvtomatlashtirilganTizim avtoTizim = new AvtomatlashtirilganTizim();

        // 1. Dastlabki ma'lumotlarni kiritish va kiritilgan ma'lumotlarni daraxt ko’rinishida tasvirlash
        avtoTizim.MalumotKiritish("001", "Toshkent", "08:00");
        avtoTizim.MalumotKiritish("002", "Samarqand", "10:30");
        avtoTizim.MalumotKiritish("003", "Buxoro", "12:45");

        // 2. Daraxtni to’liq chiqarish
        avtoTizim.DaraxtChiqarish();

        // 3. Poezd raqamini kiritish va ushbu poezd haqidagi ma’lumotlarni chiqarish
        avtoTizim.PoezdMalumotlari("002");
    }
}