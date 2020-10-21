using System;
using System.Collections.Generic;
using System.Text;
using SharedTrip.Services;
using SharedTrip.ViewModels.Trips;
using SUS.HTTP;
using SUS.MvcFramework;

namespace SharedTrip.Controllers
{
    public class TripsController : Controller
    {
        private readonly ITipsServices tipsServices;

        public TripsController(ITipsServices tipsServices)
        {
            this.tipsServices = tipsServices;
        }

        public HttpResponse Add()
        {
            return this.View();
        }

        [HttpPost]
        public HttpResponse Add(AddTripInputModel model)
        {
            if (string.IsNullOrEmpty(model.StartPoint))
            {
                return this.Error("Invalid start point");
            }

            if (string.IsNullOrEmpty(model.EndPoint))
            {
                return this.Error("Invalid end point");
            }

            if (model.Seats < 2 && model.Seats > 6)
            {
                return this.Error("Seats should be between 2 and 6");
            }

            if (string.IsNullOrEmpty(model.Description) ||model.Description.Length > 80)
            {
                return this.Error("Description is required and must by max 80 characters length");
            }

            this.tipsServices.Create(model);

            return this.Redirect("/Trips/All");
        }
    }
}
