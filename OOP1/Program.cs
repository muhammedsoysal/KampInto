﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//Mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,//Kırtasiye
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
            };

            //PascalCase her ikisi büyük harfle başlamalı  //camelCase - ikinci büyük harfle başlar
            //case sensitive
            //          stack                    heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


            //int,double,bool --> Değer Tipi
            //diziler,class,Abstract class,interface --> Referans Tipi
            //Ref out
        }
    }
}