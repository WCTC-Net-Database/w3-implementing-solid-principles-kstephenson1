namespace w3_assignment_ksteph.Config;

public static class Config
{
    // Added this csv file to add changable aspects of the program.  Could (and probably should) be changed to a .config file at a later date.

    /* * * * * * * * * * * * * * * * *
     *       CHARACTER SETTINGS      *
     * * * * * * * * * * * * * * * * */

    // If true, the program will add double quotes on all values when writing .csv files.(Default: true)
    public const int CHARACTER_LEVEL_MAX = 20;

    /* * * * * * * * * * * * * * * * *
     *         CSV SETTINGS          *
     * * * * * * * * * * * * * * * * */

    // If true, the program will add double quotes on all values when writing .csv files.(Default: true)
    public const bool CSV_CHARACTER_WRITER_QUOTES_ON_EXPORT = true;
}
