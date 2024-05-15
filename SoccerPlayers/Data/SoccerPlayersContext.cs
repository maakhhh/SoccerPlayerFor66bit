using Microsoft.EntityFrameworkCore;

namespace SoccerPlayers.Data
{
    public class SoccerPlayersContext : DbContext
    {
        public SoccerPlayersContext (DbContextOptions<SoccerPlayersContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<SoccerPlayers.Models.SoccerPlayer> SoccerPlayer { get; set; } = default!;
    }
}
