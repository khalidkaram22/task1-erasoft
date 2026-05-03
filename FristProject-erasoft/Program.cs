Console.WriteLine("Estimate for carpet cleaning service");

Console.Write("Enter Number of small carpets: ");
int smallCrpetNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Number of large carpets: ");
int largeCarpetNumber = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Price per small room: $250 ");
Console.WriteLine("Price per large room: $350 ");

int cost = (smallCrpetNumber * 250) + (largeCarpetNumber * 350);


double tax = cost * 0.14;

Console.WriteLine($"cost : {cost:c}");
Console.WriteLine($"Tax {tax:c}");


Console.WriteLine("===============================");

Console.WriteLine($"Total estimate: ${cost + tax:c0}");
Console.WriteLine($"This estimate is valid for 30 days due to {DateTime.Today.AddDays(30):d}");



