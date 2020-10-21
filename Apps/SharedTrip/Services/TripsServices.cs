using System;
using System.Globalization;
using SharedTrip.Data;
using SharedTrip.Models;
using SharedTrip.ViewModels.Trips;

namespace SharedTrip.Services
{
    public class TripsServices :ITipsServices
    {
        private readonly ApplicationDbContext dbContext;

        public TripsServices(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public void Create(AddTripInputModel tripModel)
        {
            var trip = new Trip()
            {
                StartPoint = tripModel.StartPoint,
                EndPoint = tripModel.EndPoint,
                DepartureTime = DateTime.ParseExact(tripModel.DepartureTime, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture),
                Description = tripModel.Description,
                ImagePath = tripModel.ImagePath,
                Seats = tripModel.Seats,
            };

            this.dbContext.Trips.Add(trip);
            this.dbContext.SaveChanges();
        }
    }
}
