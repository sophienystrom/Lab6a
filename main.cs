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

 
  Array.Reverse(farenheight); //reverses order of farenheight array values

  Console.WriteLine("Temperatures in Farenheight");

  foreach (double items in farenheight) // (variable type, items, in what arrar?)
  {
  Console.WriteLine (items);
  }

  double average = farenheight.Average();
  Console.WriteLine("The average weekly temperature is " + average + " degrees farenheight");
 
   }
 
    

  
  }
