int[] numbers = { 1, 2, 3, 4, 5 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

int count = 0;
do
{
    Console.WriteLine("Count: " + count);
    count++;
} while (count < 3);

int count = 0;
while (count < 3)
{
    Console.WriteLine("Count: " + count);
    count++;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}
