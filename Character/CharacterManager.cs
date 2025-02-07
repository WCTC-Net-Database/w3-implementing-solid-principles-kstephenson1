namespace w3_assignment_ksteph.Character;

using CsvHelper;
using System.Globalization;
using w3_assignment_ksteph.Csv;
using w3_assignment_ksteph.DataHelper;
using w3_assignment_ksteph.Inventory;


// The CharacterHandler class contains methods that manipulate Character data, including displaying, adding, and leveling up characters.

public static class CharacterManager
{
    public static List<Character> Characters { get; set; } = new();

    public static void DisplayAllCharacters() //Displays each character's information.
    {
        Console.Clear();

        foreach (Character character in CharacterManager.Characters)
        {
            DisplayCharacterInfo(character);

            InventoryManager.ListInventory(character.Inventory);
        }
    }

    public static void NewCharacter()
    {
        string name = Input.GetString("Enter your character's name: ");
        string characterClass = Input.GetString("Enter your character's class: ");
        int level = Input.GetInt("Enter your character's level: ", 1, "must be greater than 0");
        int hitPoints = Input.GetInt("Enter your character's maximum hit points: ", 1, "must be greater than 0");
        string? inventory = Input.GetString("Enter your character's equipment (separate items with a '|'): ", false);

        Console.Clear();
        Console.WriteLine($"\nWelcome, {name} the {characterClass}! You are level {level} and your equipment includes: {string.Join(", ", inventory)}.\n");

        CharacterManager.AddCharacter(
            new() { Name = name, Class = characterClass, Level = level, HitPoints = hitPoints, Inventory = InventoryManager.ToInventory(inventory) } );

        CsvManager.ExportCharacters();
    }

    public static void LevelUp()
    {
        string levelingCharacterName = Input.GetString("Please enter the name of the character you would like to level up: ");
        Console.Clear();

        int charactersLeveled = 0;
        foreach (Character character in CharacterManager.Characters)
        {
            if (character.Name == levelingCharacterName)
            {
                character.LevelUp();
                charactersLeveled += 1;
            }
        }

        if (charactersLeveled > 0)
        {
            Console.WriteLine($"\n{charactersLeveled} characters leveled up!\n");
        }
        else
        {
            Console.WriteLine($"No characters with that name found.");
        }
    }

    public static void DisplayCharacterInfo(Character character)
    {
        Console.WriteLine($"{character.Name}  |  Level {character.Level} {character.Class}  |  HP: {character.HitPoints}");
    }

    public static void AddCharacter(Character character)
    {
        Characters.Add(character);
    }

    public static void DeleteCharacter(Character character)
    {
        Characters.Remove(character);
    }
}