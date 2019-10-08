using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FootballApplication.Models
{
    public partial class footballappContext : DbContext
    {
        public footballappContext()
        {
        }

        public footballappContext(DbContextOptions<footballappContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LeagueTeams> LeagueTeams { get; set; }
        public virtual DbSet<Leagues> Leagues { get; set; }
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Stadiums> Stadiums { get; set; }
        public virtual DbSet<Team> Team { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost; port=3306; user=root; password=; database=footballapp");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<LeagueTeams>(entity =>
            {
                entity.HasKey(e => e.IdLeagueTeams);

                entity.ToTable("league_teams", "footballapp");

                entity.HasIndex(e => e.FkLeaguesId)
                    .HasName("fkc_LEAGUES");

                entity.HasIndex(e => e.FkTeamId)
                    .HasName("fkc_LeagueTeam");

                entity.Property(e => e.IdLeagueTeams)
                    .HasColumnName("id_LEAGUE_TEAMS")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Draws)
                    .HasColumnName("draws")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkLeaguesId)
                    .HasColumnName("fk_LeaguesID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkTeamId)
                    .HasColumnName("fk_TeamID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GoalsConceded)
                    .HasColumnName("goals_conceded")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GoalsScored)
                    .HasColumnName("goals_scored")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Loses)
                    .HasColumnName("loses")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MatchesPlayed)
                    .HasColumnName("matches_played")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Wins)
                    .HasColumnName("wins")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Years)
                    .HasColumnName("years")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkLeagues)
                    .WithMany(p => p.LeagueTeams)
                    .HasForeignKey(d => d.FkLeaguesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkc_LEAGUES");

                entity.HasOne(d => d.FkTeam)
                    .WithMany(p => p.LeagueTeams)
                    .HasForeignKey(d => d.FkTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkc_LeagueTeam");
            });

            modelBuilder.Entity<Leagues>(entity =>
            {
                entity.HasKey(e => e.IdLeagues);

                entity.ToTable("leagues", "footballapp");

                entity.Property(e => e.IdLeagues)
                    .HasColumnName("id_LEAGUES")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Founded)
                    .HasColumnName("founded")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfClubs)
                    .HasColumnName("number_of_clubs")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Matches>(entity =>
            {
                entity.HasKey(e => e.IdMatches);

                entity.ToTable("matches", "footballapp");

                entity.HasIndex(e => e.FkAwayTeamId)
                    .HasName("fkc_AwayTeam");

                entity.HasIndex(e => e.FkHomeTeamId)
                    .HasName("fkc_HomeTeam");

                entity.HasIndex(e => e.FkLeaguesId)
                    .HasName("fkc_LeagueMatch");

                entity.HasIndex(e => e.FkStadiumsId)
                    .HasName("fkc_STADIUMS");

                entity.Property(e => e.IdMatches)
                    .HasColumnName("id_MATCHES")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AwayTeamScore)
                    .HasColumnName("away_team_score")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkAwayTeamId)
                    .HasColumnName("fk_AwayTeamID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkHomeTeamId)
                    .HasColumnName("fk_HomeTeamID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkLeaguesId)
                    .HasColumnName("fk_LeaguesID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkStadiumsId)
                    .HasColumnName("fk_StadiumsID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GameWeek)
                    .HasColumnName("game_week")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HomeTeamScore)
                    .HasColumnName("home_team_score")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MatchTime)
                    .HasColumnName("match_time")
                    .HasColumnType("date");

                entity.HasOne(d => d.FkAwayTeam)
                    .WithMany(p => p.MatchesFkAwayTeam)
                    .HasForeignKey(d => d.FkAwayTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkc_AwayTeam");

                entity.HasOne(d => d.FkHomeTeam)
                    .WithMany(p => p.MatchesFkHomeTeam)
                    .HasForeignKey(d => d.FkHomeTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkc_HomeTeam");

                entity.HasOne(d => d.FkLeagues)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.FkLeaguesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkc_LeagueMatch");

                entity.HasOne(d => d.FkStadiums)
                    .WithMany(p => p.Matches)
                    .HasForeignKey(d => d.FkStadiumsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkc_STADIUMS");
            });

            modelBuilder.Entity<Players>(entity =>
            {
                entity.HasKey(e => e.IdPlayers);

                entity.ToTable("players", "footballapp");

                entity.HasIndex(e => e.FkPlayerTeam)
                    .HasName("fkc_PlayerTeam");

                entity.Property(e => e.IdPlayers)
                    .HasColumnName("id_PLAYERS")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FkPlayerTeam)
                    .HasColumnName("fk_PlayerTeam")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KitNumber)
                    .HasColumnName("kit_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkPlayerTeamNavigation)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.FkPlayerTeam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkc_PlayerTeam");
            });

            modelBuilder.Entity<Stadiums>(entity =>
            {
                entity.HasKey(e => e.IdStadiums);

                entity.ToTable("stadiums", "footballapp");

                entity.HasIndex(e => e.FkHomeTeamsId)
                    .HasName("fkc_StadiumTeam");

                entity.Property(e => e.IdStadiums)
                    .HasColumnName("id_STADIUMS")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Capacity)
                    .HasColumnName("capacity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkHomeTeamsId)
                    .HasColumnName("fk_HomeTeamsID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.StadiumOpened)
                    .HasColumnName("stadium_opened")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkHomeTeams)
                    .WithMany(p => p.Stadiums)
                    .HasForeignKey(d => d.FkHomeTeamsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkc_StadiumTeam");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.IdTeam);

                entity.ToTable("team", "footballapp");

                entity.Property(e => e.IdTeam)
                    .HasColumnName("id_TEAM")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClubColors)
                    .HasColumnName("club_colors")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CrestUrl)
                    .HasColumnName("crest_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Founded)
                    .HasColumnName("founded")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName)
                    .HasColumnName("team_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });
        }
    }
}
