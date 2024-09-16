using System.Globalization;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1
            //double number1=Convert.ToDouble(Console.ReadLine());
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //double sum = number1 + number2;
            //Console.WriteLine(sum);


            //#2
            //int number1=int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 * number2;
            //if (result > 10)
            //{
            //    Console.WriteLine($"{result} > 10");
            //}
            //else
            //{
            //    Console.WriteLine($"{result} < 10");
            //}


            //#3
            //bool isEven=false;
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //double sum = number1 + number2;
            //if (sum % 2 == 0)
            //{
            //    isEven = true;
            //}

            //if (isEven == true)
            //{
            //    Console.WriteLine($"sum is even");

            //}
            //else
            //{
            //    Console.WriteLine("sum is odd");
            //}




            //#4.1
            //Console.Write("Enter 1st number: ");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 2nd number: ");
            //double number2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("enter operation (+,-,*,/): ");
            //char operation=Convert.ToChar(Console.ReadLine());

            //if (operation == '+') {
            //    Console.WriteLine(number1+number2);
            //}else if (operation == '-'){
            //    Console.WriteLine(number1 - number2);

            //}else if(operation == '*')
            //{
            //    Console.WriteLine(number1 * number2);
            //}
            //else
            //{
            //    Console.WriteLine(number1 / number2);
            //}


            //#4.2
            //Console.Write("Enter 1st number: ");
            //double number1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 2nd number: ");
            //double number2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("enter operation (+,-,*,/): ");
            //char operation = Convert.ToChar(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine(number1 + number2);
            //        break;
            //    case '-':
            //        Console.WriteLine(number1 - number2);
            //        break;
            //    case '*':
            //        Console.WriteLine(number1 * number2);
            //        break;
            //    case '/':
            //        Console.WriteLine(number1 / number2);
            //        break;
            //    default:
            //        Console.WriteLine("Wrong operation");
            //        break;

            //}



            //#5
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine( ((double)number1 * (double)number2) / 100);


            //#6
            //string number = Console.ReadLine();
            //if (number.Length != 6)
            //{
            //    Console.WriteLine("ERROR!!!!");
            //}
            //else
            //{
            //    int index1;
            //    int index2;
            //    char temp;

            //    char[] digits = new char[6];
            //    for (int i = 0; i < 6; i++)
            //    {
            //        digits[i] = Convert.ToChar(number[i]);

            //    }
            //    index1 = int.Parse(Console.ReadLine()) - 1;
            //    index2 = int.Parse(Console.ReadLine()) - 1;

            //    temp = digits[index1];
            //    digits[index1] = digits[index2];
            //    digits[index2] = temp;
            //    Console.WriteLine(digits);

            //}


            //#7
            //double temperature;
            //char unit;
            //Console.Write("Enter temperature in numbers: ");
            //temperature=Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter unit(C/F): ");
            //unit=Convert.ToChar(Console.ReadLine());
            //if(unit == 'C' || unit=='c')
            //{
            //    Console.WriteLine($"{temperature}{unit} = {temperature*1.8+32}F");
            //}
            //else if (unit == 'F' || unit=='f')
            //{
            //    Console.WriteLine($"{temperature}{unit} = {(temperature -32)/1.8}C");
            //}



            //#8

            //Console.WriteLine("Enter date:");
            //string input = Console.ReadLine();

            
            //if (DateTime.TryParseExact(input, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            //{
                
            //    DayOfWeek dayOfWeek = date.DayOfWeek;
            //    Console.WriteLine("Day of the week: " + dayOfWeek);

                
            //    int month = date.Month;
            //    string season;

            //    if (month == 12 || month == 1 || month == 2)
            //        season = "Winter";    
            //    else if (month >= 3 && month <= 5)
            //        season = "Spring";    
            //    else if (month >= 6 && month <= 8)
            //        season = "Summer";    
            //    else
            //        season = "Autumn";    

            //    Console.WriteLine("Season: " + season);
            //}

        }

    }
}
