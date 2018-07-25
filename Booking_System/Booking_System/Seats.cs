using System;
using System.Collections.Generic;
using System.IO;

namespace Booking_System
{
    public static class Seats
    {
        private static string filePath = Path.Combine(Directory.GetCurrentDirectory(), "SeatTable.csv");


        public static List<Seat> SeatList = new List<Seat>();
        public static void Build()
        {
            for (int i = 0; i < 100; i++)
                SeatList.Add(new Seat());

            //creates and populates external seat table file if it does not already exist, otherwize reads existing data to insert it into SeatList
            try
            {
                ReadSeatTable();
            }
            catch
            {
                var file = File.Create(filePath);
                file.Close();
                PopulateTable();
                ReadSeatTable();
            }
        }

        public static void WriteSeatTable()
        {//called in FrmDetails when confirm button is pressed: adds bookings to external seat table file
            User.Fname = User.Lname = User.Address1 = User.Address2 = User.County = User.Postcode = User.Email = User.Seat1 = User.Seat2 = User.Seat3 = User.Seat4 = "";
            using (var file = File.CreateText(filePath))
            {
                foreach (Seat seat in SeatList)
                {
                    file.WriteLine(Convert.ToString(seat.Occupied) + "," + seat.Row + "," + seat.Column + "," + seat.FName + "," + seat.LName + "," + seat.Address1 + "," + seat.Address2 + "," + seat.Postcode + "," + seat.County + "," + seat.Email);
                }
            }
        }

        public static void Book(string row, string col)
        {
            foreach (Seat seat in Seats.SeatList)
            {//add users details for each seat booked
                if (seat.Row == row && seat.Column == col)
                {
                    seat.Occupied = true;
                    seat.FName = User.Fname;
                    seat.LName = User.Lname;
                    seat.Address1 = User.Address1;
                    seat.Address2 = User.Address2;
                    seat.Postcode = User.Postcode;
                    seat.County = User.County;
                    seat.Email = User.Email;
                }
            }
        }
        private static void PopulateTable()
        {//creates external csv file used to store data for seats
            using (var file = File.CreateText(filePath))
                for (char r = 'A'; r <= 'J'; r++)
                    for (int c = 1; c <= 10; c++)
                    {
                        file.WriteLine("FALSE" + "," + r + "," + c + ", , , , , , , ");
                    }

        }


        private static void ReadSeatTable()
        {//adds data from external csv file to seats in SeatList
            using (var reader = new StreamReader(filePath))
                while (!reader.EndOfStream)
                {
                    {
                        foreach (Seat seat in SeatList)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');
                            seat.Occupied = Convert.ToBoolean(values[0]);
                            seat.Row = values[1];
                            seat.Column = values[2];
                            seat.FName = values[3];
                            seat.LName = values[4];
                            seat.Address1 = values[5];
                            seat.Address2 = values[6];
                            seat.Postcode = values[7];
                            seat.County = values[8];
                            seat.Email = values[9];
                        }
                    }
                }
        }

    }

}


