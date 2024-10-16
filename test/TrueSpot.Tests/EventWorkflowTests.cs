using FluentAssertions;
using TrueSpot.Models;
using TrueSpot.Workflows;

namespace TrueSpot.Tests
{
    public class EventWorkflowTests
    {
        [Fact]
        public void Should_Create_New_Event_Without_Enddate()
        {
            var user = new TrueSpotUser { Id = Guid.NewGuid() };
            string testTile = "Test Title";
            string testDescription = "Test Description";
            var startDate = DateTime.Now;

            var workflow = new EventWorkflow();

            var tsEvent = workflow.CreateEvent(user, testTile, testDescription, startDate);

            tsEvent.Should().NotBeNull();
            tsEvent.Id.Should().NotBeEmpty();
            tsEvent.CreatorUserId.Should().Be(user.Id);
            tsEvent.Title.Should().Be(testTile);
            tsEvent.Description.Should().Be(testDescription);
            tsEvent.StartDate.Should().Be(startDate);
            tsEvent.EndDate.Should().BeNull();
        }

        [Fact]
        public void Should_Create_New_Event_With_Enddate()
        {
            var user = new TrueSpotUser { Id = Guid.NewGuid() };
            string testTile = "Test Title";
            string testDescription = "Test Description";
            var startDate = DateTime.Now;
            var endDate = startDate.AddHours(5);

            var workflow = new EventWorkflow();

            var tsEvent = workflow.CreateEvent(user, testTile, testDescription, startDate, endDate);

            tsEvent.Should().NotBeNull();
            tsEvent.Id.Should().NotBeEmpty();
            tsEvent.CreatorUserId.Should().Be(user.Id);
            tsEvent.Title.Should().Be(testTile);
            tsEvent.Description.Should().Be(testDescription);
            tsEvent.StartDate.Should().Be(startDate);
            tsEvent.EndDate.Should().Be(endDate);
        }
    }
}