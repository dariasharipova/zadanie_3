//17
Console.WriteLine("Введите четырехзначное число:");
int x = int.Parse(Console.ReadLine());
int a = (x/1000);
int b = (x/100)%10;
int c = (x/10)%10;
int d = x%10;
Console.WriteLine(d);
Console.WriteLine(c);
Console.WriteLine(b);
Console.WriteLine(a);
Console.ReadKey();