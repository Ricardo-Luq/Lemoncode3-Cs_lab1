# Lemoncode3-Git_lab
Laboratory made for learning the knacks of C#'s basics

## Info:
All answers below have been stripped of the structure surrounding them and lightly formatted, so that they would occupy as few lines as possible.

## Tasks:
__1. Ask for someone's name, their age and a city's name. Then showcase the following message:__ _"Your name is \_\_\_ and you are \_\_\_ years old. Welcome to \_\_\_."_
```javascript
    Console.WriteLine("[1. Greeting machine]");
    bool success;
    do {
        success = true;
        try {
            Console.WriteLine("Please input your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Now input your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Finally input a city name:");
            string city = Console.ReadLine();
            Console.WriteLine($"Your name is {name} and you are {age} years old. Welcome to {city}.");
        } catch (Exception) { //Extremely generic catch, but it works for a simple exercise like this 
            Console.WriteLine("You have introduced an incorrect value. Please follow the instructions.");
            success = false;
        }
    } while (!success);
    Console.ReadLine();
```

__2. Ask for two numbers and say which is greater:__
```javascript 
    Console.WriteLine("[2. Number comparator]");
    bool success;
    do {
        success = true;
        try {
            Console.WriteLine("Input a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the number you wish to compare it with:");
            int num2 = int.Parse(Console.ReadLine());
            string response = num1 == num2 ?
                "They are equal." : num1 > num2 ?
                    "The first number is greater" : "The second number is greater.";
            Console.WriteLine(response);
        } catch (Exception) { //Extremely generic catch, but it works for a simple exercise like this
            Console.WriteLine("You have introduced an incorrect value. Please follow the instructions.");
            success = false;
        }
    } while (!success);
    Console.ReadLine();
```
__3. Ask for a day of the week and say if it's a weekend, If there is an error, mention it:__
```javascript 
      try { 
      Console.WriteLine("[3. Weekend teller]");
      Console.WriteLine("Write the name of a day of the week");
      string weekday = Console.ReadLine().ToLower();
      string response = weekday == "saturday" || weekday == "sunday" ?
          "It's a weekend day." : "It's not part of the weekend";
      Console.WriteLine(response);
      } catch (Exception e) { 
          Console.WriteLine("The following error happened:");
          Console.WriteLine(e.ToString());
      }
      Console.ReadLine();
```
__4. Go through numbers 1 to 100, show only even numbers. Use any loop type you want.__
```javascript 
    Console.WriteLine("[4. even number counter]");
    for (int i = 2; i <= 100; i += 2) {
        Console.Write(i + " ");
        if (i % 10 == 0) {
            Console.Write("\n");
        }
    }
    Console.ReadLine();
```
__5. Ask for a number and create an array with that size, filled with random numbers.__ For example, if the user inputs 4, then the console should output: 23, 34, 234, 11
```javascript 
            Console.WriteLine("[5. Array generator]");
            bool success;
            Random rnd = new Random();
            do {
                success = true;
                try {
                    Console.WriteLine("Input a new array's length, greater than 0:");
                    int arrLength = int.Parse(Console.ReadLine());
                    if (arrLength > 0) { 
                        int[] newArray = new int[arrLength]; //Creates the array
                        for (int i = 0; i < arrLength; i++) { //Fills the array with random numbers
                            newArray[i] = rnd.Next(255) ;
                        }
                        for (int i = 0; i < arrLength; i++) { //Displays the array
                            Console.Write(newArray[i]+" ");
                            if ((i+1)%5 == 0 && i != 0) {
                                Console.Write('\n');
                            }
                        }
                    } else {
                        throw new Exception("Array length can't be negative (nor 0 in this case)");
                    }
                } catch (Exception) { //Extremely generic catch, but it works for a simple exercise like this
                    Console.WriteLine("You have introduced an incorrect value. Please follow the instructions.");
                    success = false;
                }
            } while (!success);
            Console.ReadLine();
```
__6. Ask for a number and a character, then showcase a triangle with N rows drawn with said character. __ For example, if the user inputs 5 and *, then the result should be:
```
*
**
* *
*  *
*****
```
```javascript 
      Console.WriteLine("[6. Triangle generator]");
      bool success;
      do {
          success = true;
          try {                    
              Console.WriteLine("Write the pyramid's size:");
              int height = int.Parse(Console.ReadLine());
              Console.WriteLine("Write the character used for it");
              char baseChar = Console.ReadLine().ElementAt(0);
              Console.WriteLine("");
              for (int length = 0; length < height; length++) {
                  if (length != 0) { //Writes the inital character, respecting smaller sizes like 1 or 2
                  Console.Write(baseChar);
                  }
                  if (length != height-1) { //Writes the main diagonal
                      for (int j = 0; j < (length-1); j++) {
                          Console.Write(" ");
                      }
                      Console.Write(baseChar);
                  } else {
                      for (int j = 1; j < length; j++) { //Draws the triangle's base
                          Console.Write(baseChar);
                      }
                      Console.Write(baseChar);
                  }
                  Console.Write("\n");
              }
          } catch (Exception) { //Extremely generic catch, but it works for a simple exercise like this
              Console.WriteLine("You have introduced an incorrect value. Please follow the instructions.");
              success = false;
          }
      } while (!success);
      Console.ReadLine();
```

