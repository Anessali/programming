import java.util.Scanner;

 class VowelOrConsonant
   {
      static public void main (String args[])
      {
		 Scanner wordMagic = new Scanner(System.in);
		 //variables
		 char vOrC;
		 char lower;
		 int charCheck;
		 boolean checkOne, checkTwo, checkThree;
		 
		 System.out.print("Enter a letter: ");
		 vOrC = wordMagic.next().charAt(0);
		 lower = Character.toLowerCase(vOrC);
		 charCheck = vOrC;
		 //boolean values are set to true based on conditions
		 checkOne = charCheck > 122;
		 checkTwo = charCheck < 65;
		 checkThree = charCheck > 90 && charCheck < 97;
		 if(checkOne || checkTwo || checkThree){
			 System.out.print(vOrC + " is an invalid input\n");
		 } else {
			 if (lower == 'a' || lower == 'e' || lower == 'i' 
			 || lower == 'o' || lower == 'u'){
				 System.out.print(vOrC + " is a vowel\n");
				 
			 } else {
				 System.out.print(vOrC + " is a consonant\n");
			 }
		 }
      }
   }