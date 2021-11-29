using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {


            Generics<int> generics1 = new Generics<int>("blue", 4);
            Generics<double> generics2 = new Generics<double>("blue", 4.5);

            Chair<double> chair1 = new Chair<double>(22.4, 4.3);
            Chair<string> chair2 = new Chair<string>("arba", "shalosh");

            //שאלה 1

            List<int> numbers = new List<int>();
            //שאלה 2

            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(9);
            numbers.Add(12);
            numbers.Add(4);

            //שאלה 3
            List<string> words = new List<string>();

            //שאלה 4
            words.Add("hello");
            words.Add("shalom");
            words.Add("hey");
            words.Add("kif halak");

            //שאלה5 

            List<double> number = new List<double>();
            number.Add(3.5);
            number.Add(4.7);
            number.Add(4.1);

            //שאלה 6

            double[] array = new double[] { 1.3, 1.4, 1.5 };
            number.AddRange(array);


            //שאלה 7

            number.RemoveAt(4);

            //שאלה 8

            Console.WriteLine(number);

            //שאלה 9



            //שאלה 10

            forniture_store<int> forniture_Store1 = new forniture_store<int>(3, 4, 7);

            //שאלה 11

            List<forniture_store<int>> shop1 = new List<forniture_store<int>>();
            forniture_store<int> forniture_Store2 = new forniture_store<int>(3, 4, 7);
            forniture_store<int> forniture_Store3 = new forniture_store<int>(3, 4, 7);
            forniture_store<int> forniture_Store4 = new forniture_store<int>(3, 4, 7);

            shop1.Add(forniture_Store1);
            shop1.Add(forniture_Store2);
            shop1.Add(forniture_Store3);
            shop1.Add(forniture_Store4);



            //שאלה 12

            for (int i = 0; i < shop1.Count; i++)
            {
                Console.WriteLine(shop1[i].numberboard);
            }

            //שאלה 13



        }
    }
}
