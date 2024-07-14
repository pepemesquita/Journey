using Journey.Communication.Requests;
using Journey.Communication.Responses;
using Journey.Infrastructure;

namespace Journey.Application.UseCases.Trips.GetAllTrips
{
    public class GetAllTripsUseCase
    {
        public ResponseTripsJson Execute()
        {
        
            var dbContext = new JourneyDbContext();

            var trips = dbContext.Trips.ToList();

            return new ResponseTripsJson
            {
               Trips = trips.Select(trip => new ResponseShortTripJson
               {
                    Id = trip.Id,
                    EndDate = trip.EndDate,
                    StartDate = trip.StartDate,
                    Name = trip.Name
                }).ToList()
            };
        }
    }
}
