class Planet
{
    public string _name = "";
    public double _diameter;

    public void DisplayPlanetInformation()
    {
        Console.WriteLine($"The planet name: {_name}, diameter: {_diameter}");
    }
}