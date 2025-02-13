void CountDownRecursive(int number)
{
    if (number == 0) return;
    Console.WriteLine(number);
    CountDownRecursive(--number);
}

CountDownRecursive(5);