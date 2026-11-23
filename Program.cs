int number = 1000000;
byte[] bytes = BitConverter.GetBytes(number);
Console.WriteLine($"Число: {number}");
Console.Write("Байты: ");
foreach (byte b in bytes) {
Console.Write($"{b:X2} ");
}
Console.WriteLine();
