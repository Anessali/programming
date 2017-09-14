
import java.util.Scanner;

 class ascii
   {
      static public void main (String args[])
      {
        //declared data
        Scanner thisBeJavascript = new Scanner(System.in);
        int asciiCode;
        //collect user input
        System.out.print("Enter an ASCII code: ");
        asciiCode = thisBeJavascript.nextInt();
        //output
        System.out.printf("The character for ASCII code " + asciiCode +" is " + ((char)asciiCode) + "\n");
      }
   }