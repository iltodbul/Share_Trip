using System;
using System.Collections.Generic;
using System.Text;
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


        public void AddTrip(AddTripInputModel tripModel)
        {
            var trip = new Trip()
            {
                StartPoint = tripModel.StartPoint,
                EndPoint = tripModel.EndPoint,
                DepartureTime = tripModel.DepartureTime,
                Description = tripModel.Description,
                ImagePath = tripModel.ImagePath,
                Seats = tripModel.Seats,
            };

            this.dbContext.Trips.Add(trip);
            this.dbContext.SaveChanges();
        }
    }
}
