using static System.Console;

Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите число: ");
int num2 = int.Parse(ReadLine());
int sqr2 = Convert.ToInt32(Math.Pow(num2, 2));
if (num1 == sqr2 | sqr2 == num1){
    WriteLine("Yes");
}
else{
    WriteLine("No");
}
