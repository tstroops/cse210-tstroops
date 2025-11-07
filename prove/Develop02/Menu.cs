class Menu
{
    public string[] _menuStrings =
    {
        "Welcome to the count",
        "You can create, display, save and read journal entries",
        "1- Create journal entry",
        "2- Display Journal",
        "3- Save journal to file",
        "4- Load journal from file",
        "5- Quit"
    };

    /*process menu will display menu to user, read and validate the input, and return the input
    no parameters needed*/
    public int ProcessMenu()
    {
        int userIn;
        do
        {
            foreach (string menuItem in _menuStrings)
            {
                Console.WriteLine(menuItem);
            }
            userIn = int.Parse(Console.ReadLine());
        } while (userIn < 1 || userIn > 5);
        return userIn;
    }
}