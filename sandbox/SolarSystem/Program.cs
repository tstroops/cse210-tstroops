using System;

class Program
{
    static void Main(string[] args)
    {
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 1234.568;

        mercury.DisplayPlanetInformation();
        Planet venus = new Planet();
        venus._name = "Venus";
        venus._diameter = 4321.568;

        venus.DisplayPlanetInformation();

        SolarSystem solarSystem = new SolarSystem();
        solarSystem._solarSystem.Add(mercury);
        solarSystem._solarSystem.Add(venus);
        solarSystem.DisplaySolarSystem();
    }
}