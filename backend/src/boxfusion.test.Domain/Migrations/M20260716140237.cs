using FluentMigrator;
using Shesha.Domain;
using Shesha.FluentMigrator;

namespace boxfusion.test.Domain.Migrations
{
    /// <summary>
    /// Creates the FlightBooking table used by the flight ticket booking form.
    /// </summary>
    [Migration(20260716140237)]
    public class M20260716140237 : OneWayMigration
    {
        public override void Up()
        {
            Create.Table("test_FlightBookings")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithColumn("BookingReference").AsString(50).Nullable()
                .WithColumn("PassengerName").AsString(200).Nullable()
                .WithColumn("ContactEmail").AsString(200).Nullable()
                .WithColumn("ContactPhone").AsString(50).Nullable()
                .WithColumn("TripTypeLkp").AsInt64().Nullable()
                .WithColumn("OriginAirport").AsString(100).Nullable()
                .WithColumn("DestinationAirport").AsString(100).Nullable()
                .WithColumn("DepartureDate").AsDateTime().Nullable()
                .WithColumn("ReturnDate").AsDateTime().Nullable()
                .WithColumn("NumberOfPassengers").AsInt32().Nullable()
                .WithColumn("CabinClassLkp").AsInt64().Nullable()
                .WithColumn("BookingStatusLkp").AsInt64().Nullable();
        }
    }
}
