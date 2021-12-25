//вид 1
void Method1()
{
    Console.WriteLine("Автор MiG @");
}
//Method1();

//вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "какой то текст");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "ТЕКСТ", count: 6);
//Method21(count: 6, msg: "НОВЫЙ ТЕКСТ");

//вид 3
int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

//вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // String.Empty - пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(4, "qwerty");
Console.WriteLine(res);