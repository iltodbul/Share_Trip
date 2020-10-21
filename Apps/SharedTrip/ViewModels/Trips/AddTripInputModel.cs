using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SharedTrip.ViewModels.Trips
{
    public class AddTripInputModel
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public DateTime DepartureTime { get; set; }

        //public string DepartureTimeAsString => DateTime.TryParseExact(DepartureTime, "dd.MM.yyyy HH:mm",
          //  CultureInfo.InvariantCulture, DateTimeStyles.None);
        public string ImagePath { get; set; }
        public int Seats { get; set; }
        public string Description { get; set; }
    }
}
