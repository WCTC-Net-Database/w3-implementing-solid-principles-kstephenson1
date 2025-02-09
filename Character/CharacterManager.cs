namespace w3_assignment_ksteph.Character;

using System;
using System.Drawing;
using Console = Colorful.Console;
using w3_assignment_ksteph.Csv;
using w3_assignment_ksteph.DataHelper;
using w3_assignment_ksteph.Inventory;


// The CharacterHandler class contains methods that manipulate Character data, including displaying, adding, and leveling up characters.

public static class CharacterManager
{
    private const string CHARACTER_PATH = "input.csv";
    public static List<Character> Characters { get; set; } = new();

    public static void ImportCharacters()
    {
        Characters = CsvManager.ImportCharacters(CHARACTER_PATH);
    }

    public static void ExportCharacters()
    {
        CsvManager.ExportCharacters(Characters, CHARACTER_PATH);
    }

    public static void DisplayAllCharacters() //Displays each character's information.
    {
        Console.Clear();

        foreach (Character character in CharacterManager.Characters)
        {
            character.DisplayCharacterInfo();

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
            new() { Name = name, Class = characterClass, Level = level, HitPoints = hitPoints, Inventory = InventoryManager.ToInventory(inventory) });

        CharacterManager.ExportCharacters();
    }

    public static void FindCharacter()
    {
        string characterName = Input.GetString("What is the name of the character you would like to search for? ");
        Character character = FindCharacterByName(characterName);
        Console.Clear();

        if (character != null)
        {
            character.DisplayCharacterInfo();
        } else
        {
            Console.WriteLine($"No characters found with the name {characterName}\n", Color.Red);
        }
    }

    public static Character? FindCharacterByName(string name)
    {
        return Characters.Where(character => character.Name == name).FirstOrDefault();
    }

    public static void LevelUp()
    {
        string characterName = Input.GetString("What is the name of the character that you would like to level up? ");
        Character character = FindCharacterByName(characterName);
        Console.Clear();

        if (character != null)
        {
            character.LevelUp();
            Console.WriteLine($"Congratulations! {characterName} has reached level {character.Level}\n", Color.Green);
        }
        else
        {
            Console.WriteLine($"No characters found with the name {characterName}\n", Color.Red);
        }
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
