Console.WriteLine("Estatment for carpet cleaning service");
Console.Write("Numbers of small carpets: ");
// S = Numbers of small carpets
int S = Convert.ToInt32(Console.ReadLine());
Console.Write("Numbers of large carpets: ");
// L = Numbers of large carpets
int L = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Price per small room: $25");
Console.WriteLine("Price per Large room: $35");
// TC = Total Cost without Tax
int TC = (S * 25) + (L * 35);
// TX = Tax
double TX = TC * 0.06;

Console.WriteLine($"Cost: ${TC}");
Console.WriteLine($"Tax: ${TX}");

Console.WriteLine("================================");


Console.WriteLine($"Total estimate: ${TC + TX}");
Console.WriteLine("This estimate is valid for 30 days");