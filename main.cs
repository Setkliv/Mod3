using System;

class MainClass {
  public static void Main (string[] args) {
    
		const string MyName = "Владимир";
		byte MyAge = 23;
		bool HaveIApet = false;
		double MyShoeSize = 40.0;

		Console.WriteLine("Меня зовут " + MyName);
		Console.WriteLine("Мне {0} года", MyAge);
		Console.WriteLine("У меня {0} домашнего питомца", HaveIApet);
		Console.WriteLine("У меня {0} размер ноги", MyShoeSize);
		Console.ReadKey();

  }
}