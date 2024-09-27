//using System.ComponentModel;

//Console.WriteLine("Enter your email:");
//string email = Console.ReadLine();


//if (email.Contains("@") && email.Contains(".")) 
//{
//    Console.WriteLine("GOOD EMAIL VASIL");
//}

//else
//{
//    Console.WriteLine("TU SHO Dyrniy nepravilno");
//}


//------------------------------2--------------------///


//Console.WriteLine("Enter your name:");
//string name = Console.ReadLine();


//if (name.Length > 1)
//{
//    Console.WriteLine("GOOD name VASIL");
//}

//else
//{
//    Console.WriteLine("TU SHO Dyrniy nepravilno");
//}




//----------------------------------3---------------------//

Console.WriteLine("Enter your rechenya:");
string rechenya = Console.ReadLine();


if (rechenya.Length >= 20)
{
    string newrechenya = rechenya.Replace('.', '!');
    Console.WriteLine("Great rechenya length!");
    Console.WriteLine(newrechenya);
}
else
{ 
    string newrechenya = rechenya.Replace('.', '/');
    Console.WriteLine("rechenya too short!");
    Console.WriteLine(newrechenya);
}

