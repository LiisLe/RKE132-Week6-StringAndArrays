string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");
