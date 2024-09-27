using M13.T1;

Building building = new Building("Невский проспект", 100, 200, 200);
Console.WriteLine(building.Print());

MultiBuilding multiBuilding = new MultiBuilding(5, "Ленинский проспект", 12.32, 200.32, 200.49);

Console.WriteLine(multiBuilding.Print());