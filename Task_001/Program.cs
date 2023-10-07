using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber == secondNumber){
            Console.WriteLine("Введенные числа равны `" + firstNumber.ToString()+"`");
        } else {
            if (firstNumber < secondNumber){
                Console.WriteLine("Первое число `" + firstNumber.ToString() + "` меньше чем второе число `"+ secondNumber.ToString()+"`");
            } else {
                Console.WriteLine("Первое число `" + firstNumber.ToString() + "` больше чем второе число `"+ secondNumber.ToString()+"`");   
            }
        }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 7;
            secondNumber = 3;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}
