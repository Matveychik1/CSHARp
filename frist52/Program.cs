void ShowLinia(int shirina, ConsoleColor color)
{
    Console.ForegroundColor = color;
    
    for (int i = 1; i <= shirina; i++)
    {
        Console.Write(new string(c:' ',count: shirina - i));
        Console.WriteLine(new string(c: '-', count: i*2));
    }
    Console.ResetColor();
}
ShowLinia(shirina: 5, ConsoleColor.White);
ShowLinia(shirina: 15, ConsoleColor.Blue);
ShowLinia(shirina: 25, ConsoleColor.Red);
