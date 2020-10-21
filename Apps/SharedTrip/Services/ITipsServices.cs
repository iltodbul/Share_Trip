using System;
using System.Collections.Generic;
using System.Text;
using SharedTrip.ViewModels.Trips;

namespace SharedTrip.Services
{
    public interface ITipsServices
    {
        void AddTrip(AddTripInputModel tripModel);
    }
}
