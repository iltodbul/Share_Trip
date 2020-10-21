using SharedTrip.ViewModels.Trips;

namespace SharedTrip.Services
{
    public interface ITipsServices
    {
        void Create(AddTripInputModel tripModel);
    }
}
