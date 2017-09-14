
import java.util.Scanner;

 class Ascii
   {
      static public void main (String args[])
      {
		 //collect user input
		 String character;
		 Scanner thisBeJavascript = new Scanner(System.in);
         System.out.print("Enter an ASCII code: ");
		 character = thisBeJavascript.nextLine();
		 
		 //process data
		 int ascii = character.charAt(0);
		 
		 //output
		 System.out.printf("The character for ASCII code " + ascii +" is " + character + "\n");
      }
   }