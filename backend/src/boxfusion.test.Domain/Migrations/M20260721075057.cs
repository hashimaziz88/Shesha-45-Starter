using FluentMigrator;
using Shesha.FluentMigrator;

namespace boxfusion.test.Domain.Migrations
{
    /// <summary>
    /// Creates the SupportAgent table used by the Agents listing page.
    /// </summary>
    [Migration(20260721075057)]
    public class M20260721075057 : OneWayMigration
    {
        public override void Up()
        {
            Create.Table("test_SupportAgents")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithColumn("Name").AsString(200).Nullable()
                .WithColumn("Email").AsString(200).Nullable()
                .WithColumn("IsActive").AsBoolean().WithDefaultValue(false);
        }
    }
}
