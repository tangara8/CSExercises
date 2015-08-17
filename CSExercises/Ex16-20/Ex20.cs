using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



﻿namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity for TV : ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for DVD : ");
            
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for MP3 : ");
            qty = Convert.ToInt32(Console.ReadLine());
        
            double TVPrice = 900;
            double DVDPrice = 500;
            double MP3Price = 700;

            double TotalTVPrice = qty * TVPrice;
            double TotalDVDPrice = qty * DVDPrice;
            double TotalMP3Price = qty * MP3Price;
            double discount;
            double discount1;
            double tier1;
            double tier2;

            double DiscountApplicable = TotalTVPrice+ TotalDVDPrice;
            if (DiscountApplicable > 5000)
            {
                discount = 0.1 * DiscountApplicable;            
                tier1 = DiscountApplicable - discount;
                Console.WriteLine("${0:.00}", tier1);
            Console.ReadLine();
        }
            else if (DiscountApplicable > 10000)
            {
                discount1 = 0.15 * DiscountApplicable;        
                tier2 = DiscountApplicable - discount1;
                Console.WriteLine("${0:.00}", tier2);
            Console.ReadLine();
        
        }
        
