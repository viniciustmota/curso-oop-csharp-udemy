using System;
using System.Resources;
using PersonalizedException.Entities;
using PersonalizedException.Entities.Exceptions;

namespace PersonalizedExcepiton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Ckeck-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Ckeck-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut); ;
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Ckeck-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Ckeck-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException e) {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Uncexpected error: {e.Message}");
            }
        }
    }
}