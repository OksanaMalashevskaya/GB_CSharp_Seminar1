﻿using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
        int number = 0;
        if (a >= b) {
            number = a;
        } else {
            number = b;
        }

        if (number < c) {
            number = c;
        }
        return number;

    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = -7;
           b = -9;
           c = -3;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}