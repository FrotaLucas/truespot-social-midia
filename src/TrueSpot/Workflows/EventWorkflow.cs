using TrueSpot.Models;

namespace TrueSpot.Workflows
{
    public class EventWorkflow
    {
        public TrueSpotEvent CreateEvent(TrueSpotUser user, string title, string description, DateTime startdate, DateTime? enddate = null)
        {
            // TODO: Save to a database where the ID is created automatically.
            if (enddate < startdate)
            {
                throw new InvalidOperationException("End date cannot be before start date");
            }

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

        public void AddUserToEvent(TrueSpotEvent @event, TrueSpotUser user)
        {
            // TODO: Add a return value that indicates what happened in this method.
            // i.e. Was the user successfuly added, and if not, explain the reason (user added already, user is creator).
            if (@event.AttendingUsers.Any(u => u.Id == user.Id))
                return;

            if (@event.CreatorUserId == user.Id)
                return;

            @event.AttendingUsers.Add(user);
        }
    }
}