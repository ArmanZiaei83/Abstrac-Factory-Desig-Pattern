﻿using AbstractFactory.furnitures;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var classicHome = new HomeFactory().ClassicalHome();

            classicHome.CreateChair()
                .ChairName("mdch13")
                .ChairLegs(4);

            classicHome.CreateTable()
                .TableColor("Green")
                .TableLegs(5);
        }
    }
}