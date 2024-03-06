//====================================1.1
Console.WriteLine("tasks #Z1.1");
Console.WriteLine("Вывести на экран все целые числа от 100 до 200, кратные трем.");
for (int i = 100; i <= 200; i++)
{
	while (i % 3 == 0)
	{
		Console.WriteLine(i);
		break;
	}
}
//====================================1.3
Console.WriteLine("tasks #Z1.3");
Console.WriteLine("Найти сумму положительных нечетных чисел, меньших 50.");
int res = 0;
for (int i = 0; i < 50; i++)
{
	while (i % 2 == 1)
	{
		res += i;
		break;
	}
}
Console.WriteLine(res); res = 0;
//====================================1.4
Console.WriteLine("tasks #Z1.4");
Console.WriteLine("Найти сумму целых положительных чисел из промежутка от a до b, кратных четырем.");
Console.WriteLine("Введите число а");
int a = 0, b = 0;
_parcer(Console.ReadLine());
if (res == 0) { Console.WriteLine("Ошибка ввода! \nВведите число а"); _parcer(Console.ReadLine()); }
else a = res; Console.WriteLine("Введите число b"); _parcer(Console.ReadLine());
if (res == 0) { Console.WriteLine("Ошибка ввода! \nВведите число b"); _parcer(Console.ReadLine()); }
else b = res; res = 0;
if (a != 0 & b != 0)
{
	for (int i = a; i <= b; i++) { while (i % 4 == 0) { res += i; break; } }
}
Console.WriteLine(res);
res = 0;
//*********
int _parcer(string s) { int.TryParse(s, out res); return res; } //Метод парсинга ввода в объект типа int
																//*********

//====================================1.5
Console.WriteLine("tasks #Z1.5");
Console.WriteLine("Составить программу поиска четырехзначных чисел, которые при делении на 47 дают в остатке 43, а при делении на 43 дают в остатке 37.");
for (int i = 0; i < int.MaxValue; i++)
{
	while (i % 47 == 43 & i / 43 == 37)
	{
		Console.WriteLine(i + " % 47 = " + (i % 47) + "\n" + i + " / 43 = " + (i / 43));
		Console.WriteLine(i);
		break;
	}
}
//====================================1.8
Console.WriteLine("tasks #Z1.8");
Console.WriteLine("Определить количество трехзначных натуральных чисел, сумма цифр которых равна целому числу n (0 < n <= 27).");
for (uint x = 1; x <= 27; x++)
{
	for (uint y = 1; y <= 27; y++)
	{
		for (uint z = 1; z <= 27; z++)
		{
			while (x + y + z <= 27)
			{
				res++;
				break;
			}
		}
	}
}
Console.WriteLine(res); res = 0;
//====================================1.12
Console.WriteLine("tasks #Z1.12");
Console.WriteLine("Найти сумму целых положительных чисел, больших 30 и меньших 100, кратных трем и оканчивающихся на 2, 4 и 8.");
for (int i = 31; i < 100; i++)
{
	while (i % 3 == 0)
	{
		while (i.ToString().LastIndexOf(2.ToString()) == 1 || i.ToString().LastIndexOf(4.ToString()) == 1 || i.ToString().LastIndexOf(8.ToString()) == 1)
		{
			res += i;
			break;
		}
        break;
	}
}
Console.WriteLine(res);
Console.ReadLine();
