///////////////////////////////
//  Void metodlar(return type olmayan 
//////////////////////////////

//static void Sum()
//{
//    int a = 11;
//    int b = 15;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}
//Sum();

/////////////////////////////////////////

//static void ShowData()
//{
//    string fullname = "Axundov Cahangir";
//    string email = "cahangir@code.edu.az";
//    string fullData = $"{fullname} - {email}";
//    ShowAge();
//    Console.WriteLine(fullData);
//}
//ShowData();

//////////////////////////////////////

//static void ShowAge()
//{
//    Welcome();
//    int age = 20;
//    Console.WriteLine(age);
//}

////////////////////////////////////// 

//static void Welcome()
//{
//    Console.WriteLine("Welcome");
//}

//////////////////////////////////

//static void SumItemsOfArray()
//{
//    int[] array = { 1,2, 3, 4, 5 };
//    int sum = 0;
//    foreach (var num in array)
//    {
//        sum += num;
//    }
//    Console.WriteLine(sum);
//}
//SumItemsOfArray();


///////////////////////////////
//  Void metodlar(break ve return ferqi)
//////////////////////////////

//static void SearchByName()
//{
//    string[] names = { "Cahangir", "Pervin", "Elvin" };
//    string searchText = "Cahangirr";
//    foreach (var name in names)
//    {
//        if (name == searchText)
//        {
//            Console.WriteLine(name);
//            break;//Loopdan cixxir Cahangiri tapanan sonra
//        }

//        if (name == "Elvin")
//        {
//            Console.WriteLine(name);
//            return;//Methodu dayandirir ve asagini gormur
//        }

//    }
//    Console.WriteLine("Is working");
//}
//SearchByName();

///////////////////////////////
//  Void metodlar(parametrler ve argumentler)
//////////////////////////////

//static void Sum(int a,int b)
//{
//    int sum = a + b;
//    Console.WriteLine(sum);
//}
//Sum(6, 10);

////////////////////////

//static void ShowText(string text,int num)
//{
//    Console.WriteLine(text + "-" +num);
//}

//string text1 = "Qrupp";
//int num1 = 139;
//ShowText(text1, num1);

//ShowText("P139",1);
//ShowText("P138",2);
//ShowText("P137",3);

////////////////////

//static void Login(string username,string password)
//{
//    if(username=="Cahangir"&& password == "cahangir2002")
//    {
//        Console.WriteLine("Login successed");
//    }
//    else
//    {
//        Console.WriteLine("Username or password is wrong");
//    }

//}
//Login("Cahangir", "cahangir2002");//Evelden teyin olunur

//Console.WriteLine("Add your username");//Consoldan teyin olunur
//string username1 = Console.ReadLine();

//Console.WriteLine("Add your password");
//string password1 = Console.ReadLine();

//Login(username1, password1);

///////////////////////////////////////////

//Console.WriteLine("Add first number");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Add second number");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Cavab :");

//Sum(num1, num2);

//static void Sum(int number1,int number2)
//{
//    int sum=number1+number2;
//    Console.WriteLine(sum);
//}

///////////////////////////////
// Return type olan metod
//////////////////////////////

//string result = ShowName();
//Console.WriteLine(result);
//static string ShowName()
//{
//    return "Cahangir";
//}

////////////////////////////////


//int result = Sum(1, 2);
//Console.WriteLine(result);
//static int Sum(int a,int b)
//{
//    return a + b;
//}

//////////////////////////

//int[] array1 = { 1, 2, 3, 4, 5 };
//int result = GetSumOfNumbersFromArray(array1);
//Console.WriteLine(result);
//static int GetSumOfNumbersFromArray(int[] array)
//{
//    int sum = 0;
//	foreach (var item in array)
//	{
//		sum += item;
//	}
//	return sum;
//}

///////////////////////////////
//  Switch-case
//////////////////////////////



//bool result = CheckWeekDayIfSunday("Sunday");
//ShowWeekDay(result);
//static void ShowWeekDay(bool isSunday)
//{
//    if (isSunday)
//    {
//        Console.WriteLine("Yes , is Sunday");
//    }
//    else
//    {
//        Console.WriteLine("No");
//    }

//}

//static bool CheckWeekDayIfSunday(string weekDay)

//{
//    bool isSunday = false;
//	switch(weekDay)
//	{
//		case "Suturday":
//		    isSunday = false;
//			break;
//        case "Monday":
//            isSunday = false;
//            break;
//        case "Tuesday":
//            isSunday = false;
//            break;
//        case "Sunday":
//            isSunday = true;
//            break;
//        case "Thruday":
//            isSunday = false;
//            break;
//        case "Friday":
//            isSunday = false;
//            break;
//        case "Wednesdey":
//            isSunday = false;
//            break;
//    }
//    return isSunday;
//}


