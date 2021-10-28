// Program 1A
// CIS 200-01
// Fall 2020
// Due: 9/21/2020
// By: Andrew L. Wright (students use Grading ID)

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Mason Hale", "2252 Kelley Road",
                "Pascagoula", "MS", 39567); // Test Address 5
            Address a6 = new Address("Ruby Anderson", "619 Round Table Drive",
                "Cincinnati", "OH", 45202); // Test Address 6
            Address a7 = new Address("Irene Freund", "3225 Wolf Pen Road",
                "Oakland", "CA", 94501); // Test Address 7
            Address a8 = new Address("Christopher Irwin", "3983 Primrose Lane",
                "Indianapolis", "IN", 46249); // Test Address 8

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            
            Letter letter2 = new Letter(a5, a6, 3.95M);                            // Letter test object 2
            GroundPackage gp2 = new GroundPackage(a7, a5, 8, 12, 6, 15);        // Ground test object 2
            NextDayAirPackage ndap2 = new NextDayAirPackage(a8, a6, 12, 12, 12,    // Next Day test object 2
                40, 7.50M);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a5, a8, 50, 45.5, 30.0, // Two Day test object 2
                80.5, TwoDayAirPackage.Delivery.Saver);
            
            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(letter2); 
            parcels.Add(gp2);
            parcels.Add(ndap2);
            parcels.Add(tdap2);

            WriteLine("Original List:");
            WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("====================");
            }
            Pause();

            var parcelsInDescOrderZip = from p in parcels
                                        orderby p.DestinationAddress.Zip descending
                                        select p;


            var parcelsInAscOrderPrice = from p in parcels
                                         orderby p.CalcCost() ascending
                                         select p;

            var parcelsInDescOrderPriceAndType = from p in parcels
                                                 orderby p.GetType().ToString
                                                 orderby p.CalcCost() descending
                                                 select p;
            var airParcels = from p in parcels

                             let airp = parcel as AirPackage

                             where (airp != null) && airp.IsHeavy()

                             orderby airp.Weight ascending

                             select parcels;

        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            WriteLine("Press Enter to Continue...");
            ReadLine();

            Console.Clear(); // Clear screen
        }

        
    }
}
