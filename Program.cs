namespace calculator;
      
class Programm
{
    static void print(string qwe)
    {
        Console.WriteLine(qwe);
    }

    static void Main(string[] args)
    {
        print("Введите первое число: ");
        int number_1 = Convert.ToInt32(Console.ReadLine());

        print("Введите второе число: ");
        int number_2 = Convert.ToInt32(Console.ReadLine());

        int summ = number_1 + number_2;
        print("Сумма = " + summ);
    }
}
