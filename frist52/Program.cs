Console.WriteLine("-----------------daybook----------------");


Console.Write("ENTER.Rating1=");
Double rating1 = double.Parse(Console.ReadLine());


Console.Write("ENTER.Rating2=");
Double rating2 = double.Parse(Console.ReadLine());


Console.Write("ENTER.Rating3=");
Double rating3 = double.Parse(Console.ReadLine());


Console.Write("ENTER.Rating4=");
Double rating4 = double.Parse(Console.ReadLine());


Console.Write("ENTER.Rating5=");
Double rating5 = double.Parse(Console.ReadLine());


Console.Write("Resulte average score =");
Console.Write((rating1 + rating2 + rating3 + rating4 + rating5) / 5);