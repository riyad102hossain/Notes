int[] arr = { 2, 4, 5, 3, 9 };

int mid = arr.Length / 2 + 1;

int[] firsthalf = arr.Take(mid).ToArray();
int[] secondhalf = arr.Skip(mid).ToArray();

Console.WriteLine($"First half : {string.Join(",", firsthalf)}");
Console.WriteLine($"Second Half: {string.Join(",", secondhalf)}");



