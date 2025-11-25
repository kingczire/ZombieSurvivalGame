using Microsoft.Data.Sqlite;

namespace ZombieSurvivalGame.Config
{
    public class SqliteDatabase : IDatabase
    {
        public SqliteConnection CreateConnection()
        {
            return new SqliteConnection(DbConfig.ConnectionString);
        }

        public void Initialize()
        {
            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Characters (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT,
                        Role TEXT,
                        Age INTEGER,
                        EyeType TEXT,
                        EyeColor TEXT,
                        EyebrowColor TEXT,
                        NoseType TEXT,
                        MouthType TEXT,
                        HairStyle TEXT,
                        FacialHair TEXT,
                        FacialHairColor TEXT,
                        Scar TEXT,
                        BodyType TEXT,
                        SkinColor TEXT,
                        Posture TEXT,
                        Hat TEXT,
                        Shirt TEXT,
                        Jacket TEXT,
                        Pants TEXT,
                        Gloves TEXT,
                        Boots TEXT,
                        Armor TEXT,
                        Tattoos TEXT,
                        Weapon TEXT,
                        IsStealthy INTEGER
                    );
                ";

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"[DB ERROR] Initialization failed: {e.Message}");
            }
        }
    }
}
