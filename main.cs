using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
  
  double[] celcius = new double[7]; //declaring array for up to 7 values 
  double[] farenheight = new double[7]; //declaring arrat for up to 7 values


  for (int counter = 0; counter < 7; counter++) //starting counter loop
  {
  Console.WriteLine("Give temperature in Celcius");
  celcius[counter] = Convert.ToDouble(Console.ReadLine()); //ReadLine values will be stored in the array celcius
  farenheight[counter] = (((celcius[counter]) * 9/5)+32); //calculated values will be stored in array farenheight
  }

 
  Array.Reverse(farenheight); //reverses order of farenheight array values. if you do array.sort it sorts it greatest to least 

  Console.WriteLine("Temperatures in Farenheight"); // outside of loop so it does not repeat. 

  foreach (double items in farenheight) // (variable type, items, in what Array?)
  {
  Console.WriteLine (items); //display reverse list
  }

  double sum = farenheight.Sum(); // CAN ONLY DO THIS WITH SYSTEM.LINQ!!!!
  double average = sum/7;
  Console.WriteLine("The average weekly temperature is " + average + " degrees farenheight"); 
 
   }
 
    

  
  }
