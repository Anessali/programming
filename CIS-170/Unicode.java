 import java.util.Scanner;
 
 class Unicode
   {
      static public void main (String args[])
      {
         //collect user input
		 String character;
		 Scanner jaaava = new Scanner(System.in);
         System.out.print("Enter a character: ");
		 character = jaaava.nextLine();
		 
		 //process data
		 int unicode = character.charAt(0);
		 
		 //output
		 System.out.printf("The Unicode for the character " + character +" is " + unicode + "\n");
      }
   }