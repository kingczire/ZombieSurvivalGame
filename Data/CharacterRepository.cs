using ZombieSurvivalGame.Config;
using ZombieSurvivalGame.Domain.Structures;
using ZombieSurvivalGame.Model;

namespace ZombieSurvivalGame.Data
{
    internal class CharacterRepository
    {
        // save character
        public void SaveCharacter(Character character)
        {
            try
            {
                using (var conn = new SqliteDatabase().CreateConnection())
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            INSERT INTO Characters 
                            (Role, Name, Age, EyeType, EyeColor, EyebrowColor, NoseType, MouthType, HairStyle, FacialHair, FacialHairColor, Scar, BodyType, SkinColor, Posture, Hat, Shirt, Jacket, Pants, Gloves, Boots, Armor, Tattoo, Weapon, IsStealthy) 
                            VALUES 
                            (@Role, @Name, @Age, @EyeType, @EyeColor, @EyebrowColor, @NoseType, @MouthType, @HairStyle, @FacialHair, @FacialHairColor, @Scar, @BodyType, @SkinColor, @Posture, @Hat, @Shirt, @Jacket, @Pants, @Gloves, @Boots, @Armor, @Tattoo, @Weapon, @IsStealthy);
                        ";
                        cmd.Parameters.AddWithValue("@Role", character.Role);
                        cmd.Parameters.AddWithValue("@Name", character.Name);
                        cmd.Parameters.AddWithValue("@Age", character.Age);
                        cmd.Parameters.AddWithValue("@EyeType", character.Appearance.Eye);
                        cmd.Parameters.AddWithValue("@EyeColor", character.Appearance.EyeColor);
                        cmd.Parameters.AddWithValue("@EyebrowColor", character.Appearance.EyebrowColor);
                        cmd.Parameters.AddWithValue("@NoseType", character.Appearance.Nose);
                        cmd.Parameters.AddWithValue("@MouthType", character.Appearance.Mouth);
                        cmd.Parameters.AddWithValue("@HairStyle", character.Appearance.HairStyle);
                        cmd.Parameters.AddWithValue("@FacialHair", character.Appearance.FacialHair);
                        cmd.Parameters.AddWithValue("@FacialHairColor", character.Appearance.FacialHairColor);
                        cmd.Parameters.AddWithValue("@Scar", character.Appearance.Scar);
                        cmd.Parameters.AddWithValue("@BodyType", character.Appearance.Body);
                        cmd.Parameters.AddWithValue("@SkinColor", character.Appearance.Skin);
                        cmd.Parameters.AddWithValue("@Posture", character.Appearance.Posture);
                        cmd.Parameters.AddWithValue("@Hat", character.Apparel.Hat);
                        cmd.Parameters.AddWithValue("@Shirt", character.Apparel.Shirt);
                        cmd.Parameters.AddWithValue("@Jacket", character.Apparel.Jacket);
                        cmd.Parameters.AddWithValue("@Pants", character.Apparel.Pants);
                        cmd.Parameters.AddWithValue("@Gloves", character.Apparel.Gloves);
                        cmd.Parameters.AddWithValue("@Boots", character.Apparel.Boots);
                        cmd.Parameters.AddWithValue("@Armor", character.Equipment.Armor);
                        cmd.Parameters.AddWithValue("@Tattoo", character.Equipment.Tattoo);
                        cmd.Parameters.AddWithValue("@Weapon", character.Equipment.Weapon);
                        cmd.Parameters.AddWithValue("@IsStealthy", character.IsStealthy ? 1 : 0);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error in saving character: " + e.Message);
            }
        }

        // delete character
        public bool DeleteCharacter(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid ID: Cannot proceed in deleting character.");
            }

            try
            {
                using (var conn = new SqliteDatabase().CreateConnection())
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Characters WHERE Id = @Id;";
                        cmd.Parameters.AddWithValue("@Id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            throw new Exception("No character found with the given ID.");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error in deleting character: " + e.Message);
            }
        }

        // load character
        public List<Character> LoadCharacters()
        {
            List<Character> characters = new List<Character>();
            try
            {
                using (var conn = new SqliteDatabase().CreateConnection())
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Characters;";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Appearance appearance = new Appearance(
                                    reader.GetString(reader.GetOrdinal("EyeType")),
                                    reader.GetString(reader.GetOrdinal("EyeColor")),
                                    reader.GetString(reader.GetOrdinal("EyebrowColor")),
                                    reader.GetString(reader.GetOrdinal("NoseType")),
                                    reader.GetString(reader.GetOrdinal("MouthType")),
                                    reader.GetString(reader.GetOrdinal("HairStyle")),
                                    reader.GetString(reader.GetOrdinal("FacialHair")),
                                    reader.GetString(reader.GetOrdinal("FacialHairColor")),
                                    reader.GetString(reader.GetOrdinal("Scar")),
                                    reader.GetString(reader.GetOrdinal("BodyType")),
                                    reader.GetString(reader.GetOrdinal("SkinColor")),
                                    reader.GetString(reader.GetOrdinal("Posture"))
                                );
                                Apparel apparel = new Apparel(
                                    reader.GetString(reader.GetOrdinal("Hat")),
                                    reader.GetString(reader.GetOrdinal("Shirt")),
                                    reader.GetString(reader.GetOrdinal("Jacket")),
                                    reader.GetString(reader.GetOrdinal("Pants")),
                                    reader.GetString(reader.GetOrdinal("Gloves")),
                                    reader.GetString(reader.GetOrdinal("Boots"))
                                );
                                Equipment equipment = new Equipment(
                                    reader.GetString(reader.GetOrdinal("Armor")),
                                    reader.GetString(reader.GetOrdinal("Tattoo")),
                                    reader.GetString(reader.GetOrdinal("Weapon"))
                                );
                                int id = reader.GetInt32(reader.GetOrdinal("Id"));
                                Character character = new Character(
                                    id,
                                    reader.GetString(reader.GetOrdinal("Role")),
                                    reader.GetString(reader.GetOrdinal("Name")),
                                    reader.GetInt32(reader.GetOrdinal("Age")),
                                    appearance, apparel, equipment,
                                    reader.GetInt32(reader.GetOrdinal("IsStealthy")) != 0
                                );

                                characters.Add(character);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error in loading characters: " + e.Message);
            }
            return characters;
        }
    }
}
