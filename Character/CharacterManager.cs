namespace w3_assignment_ksteph.Character;

using Spectre.Console;
using w3_assignment_ksteph.Config;
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
        int level = Input.GetInt("Enter your character's level: ", 1, Config.CHARACTER_LEVEL_MAX, $"character level must be 1-{Config.CHARACTER_LEVEL_MAX}");
        int hitPoints = Input.GetInt("Enter your character's maximum hit points: ", 1, "must be greater than 0");
        Inventory inventory = new();

        while (true)
        {
            string? newItem = Input.GetString($"Enter the name of an item in {name}'s inventory. (Leave blank to end): ", false);
            if (newItem != "")
            {
                inventory.Items.Add(new(newItem));
                continue;
            }
            break;
        }

        Console.Clear();
        Console.WriteLine($"\nWelcome, {name} the {characterClass}! You are level {level} and your equipment includes: {string.Join(", ", inventory)}.\n");

        CharacterManager.AddCharacter(
            new() { Name = name, Class = characterClass, Level = level, HitPoints = hitPoints, Inventory = inventory });

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
            AnsiConsole.MarkupLine($"[Red]No characters found with the name {characterName}\n[/]");
        }
    }

    public static Character? FindCharacterByName(string name)
    {
        return Characters.Where(character => character.Name.ToUpper() == name.ToUpper()).FirstOrDefault();
    }

    public static void LevelUp()
    {
        string characterName = Input.GetString("What is the name of the character that you would like to level up? ");
        Character character = FindCharacterByName(characterName);
        Console.Clear();

        if (character != null)
        {
            if (character.Level < Config.CHARACTER_LEVEL_MAX)
            {
                character.LevelUp();
                AnsiConsole.MarkupLine($"[Green]Congratulations! {character.Name} has reached level {character.Level}[/]\n");
                character.DisplayCharacterInfo();
            }

            AnsiConsole.MarkupLine($"[Red]{character.Name} is already max level! ({Config.CHARACTER_LEVEL_MAX})[/]\n");
        }
        else
        {
            AnsiConsole.MarkupLine($"[Red]No characters found with the name {characterName}[/]\n");

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
