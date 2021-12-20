Console.Write("Введите расстояние между друзьями - ");
double distance = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость первого мальчика - ");
double speed_1_boy = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость второго мальчика - ");
double speed_2_boy = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите скорость собаки - ");
double speed_dog = Convert.ToDouble(Console.ReadLine());
int N = 0;
int i = 2;
double time = 0;
while (distance > 2)
{
    if (i == 1)
    {
        time = distance / (speed_1_boy + speed_dog);
        i = 2;
    }
    else
    {
        time = distance / (speed_2_boy + speed_dog);
        i = 1;
    }
    distance = distance - (time * (speed_1_boy + speed_2_boy));
    N++;
}
Console.Write("Собака успеет сбегать между друзьями - " + N + " раз.");