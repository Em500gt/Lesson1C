using static System.Console;

Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());
if (num1 > 7 || num1 < 1){
    WriteLine("Не верное число");
}
if (num1 == 1){
    WriteLine("Понедельник");
}
if (num1 == 2){
    WriteLine("Вторник");
}
if (num1 == 3){
    WriteLine("Среда");
}
if (num1 == 4){
    WriteLine("Четверг");
}
if (num1 == 5){
    WriteLine("Пятница");
}
if (num1 == 6){
    WriteLine("Субота");
}
if (num1 == 7){
    WriteLine("Воскресение");
}
