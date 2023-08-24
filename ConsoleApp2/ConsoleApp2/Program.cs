
while (true){
    DateTime data = DateTime.Now;
    int hora = data.Hour;
    int minuto = data.Minute;
    int seg = data.Second;
    Console.Write("\r{0:D2}:{1:D2}:{2:D2}",hora,minuto,seg);
    Thread.Sleep(1000);
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
        if( keyInfo.Key == ConsoleKey.X)
        {
            break;
        }
    }
}