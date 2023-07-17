//2.Verilmiş n - ədədinin 3 - ə və 7-ə bölünüb-bölünməməsini tapın.

//Console.WriteLine("Regemi daxil edin");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("--------------");
//Check(num);
//static void Check(int num)
//{
//    if (num % 21 == 0)
//    {
//        Console.WriteLine("Bolunur");
//    }
//    else
//    {
//        Console.WriteLine("Bolunmur");
//    }

//}

//3. n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//Console.WriteLine("N regemi daxil edin");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("N regemi daxil edin");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("--------------");
//int result = SumOfEvenNumbers(n, m);
//Console.WriteLine(result);
//static int SumOfEvenNumbers(int n, int m)
//{
//	int sum = 0;
//	if(n%2==0 && m % 2 == 0)
//	{
//		sum=n+m;
//	}
//	return sum;
//}

//4.Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//Console.WriteLine("N regemi daxil edin");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("N regemi daxil edin");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("--------------");
//int result = SumOfOddNumbers(n, m);
//Console.WriteLine(result);
//static int SumOfOddNumbers(int n, int m)
//{
//	int sum = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 1)
//		{
//			sum += i;
//		}
//	}
//	return sum;
//}

//5.  Verilmish arrayin icindeki tek ededlerin cemini tapin.

//int[] array = { 2, 2, 3, 4, 5 };
//int result = SumOfOddNumbersFromArray(array);
//Console.WriteLine(result);
//static int SumOfOddNumbersFromArray(int[] arr)
//{
//    int sum = 0;
//	foreach (var item in arr)
//	{
//		if (item % 2 == 1)
//		{
//			sum += item;
//		}
//	}
//	return sum;
//}

//6. Verilmish arrayin icindeki cut ededlerin sayini tapin.

//int[] array = { 1, 2, 3, 4, 5 };
//int result = CountOfEvenNumbersFromArray(array);
//Console.WriteLine(result);
//static int CountOfEvenNumbersFromArray(int[] arr)
//{
//	int count = 0;
//	foreach (var item in arr)
//	{
//		if (item % 2 == 0)
//		{
//			count++;
//		}
//	}
//	return count;
//}

//7.  Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//Console.WriteLine("N regemi daxil edin");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("N regemi daxil edin");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("--------------");
//int result = CountOfOddNumbers(n, m);
//Console.WriteLine(result);
//static int CountOfOddNumbers(int n, int m)
//{
//	int count = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 1)
//		{
//			count++;
//		}
//	}
//	return count;
//}

//8.  Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//Console.WriteLine("N regemi daxil edin");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("N regemi daxil edin");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("--------------");
//int result = SumOfEvenNumbers(n, m);
//Console.WriteLine(result);
//static int SumOfEvenNumbers(int n, int m)
//{
//	int sum = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			sum+=i;
//		}
//	}
//	return sum;
//}

//9. Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//Console.WriteLine("N regemi daxil edin");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("N regemi daxil edin");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("--------------");
//int result = CountOfEvenNumbers(n, m);
//Console.WriteLine(result);
//static int CountOfEvenNumbers(int n, int m)
//{
//	int count = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			count++;
//		}
//	}
//	return count;
//}

//10. Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//Console.WriteLine("N regemi daxil edin");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("-------------");
//Check(n);

//static void Check(int n)
//{
//	for (int i = 2; i < n-1; i++)
//	{

//		if (n % i == 0)
//		{
//            Console.WriteLine("Murekkebdir");
//			return;

//		}
//		else
//		{
//            Console.WriteLine("Sadedir");
//			break;
//        }

//	}
//}

//11. n ededinin faktorialini hesablamaq.

//Console.WriteLine("N regemi daxil edin");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("-------------");
//int result = GetFactorialOfNumber(n);
//Console.WriteLine(result);
//static int GetFactorialOfNumber(int n)
//{
//	int multiplication = 1;
//	for (int i = 1; i <= n; i++)
//	{
//		multiplication *= i;
//	}
//	return multiplication;
//}





