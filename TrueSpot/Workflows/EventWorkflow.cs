using TrueSpot.Models;

namespace TrueSpot.Workflows
{
    internal class EventWorkflow
    {
        public TrueSpotEvent CreateEvent(TrueSpotUser user, string title, string description, DateTime startdate, DateTime? enddate = null)
        {
            // TODO: Save to a database where the ID is created automatically.
            return new TrueSpotEvent
            {
                Id = Guid.NewGuid(),
                CreatorUserId = user.Id,
                Title = title,
                Description = description,
                StartDate = startdate,
                EndDate = enddate
            };
        }
    }
}
