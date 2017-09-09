/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author liggettt
 */
import java.util.Scanner;
public class inclass {

    public static void main(String[] args) {
//        Scanner input = new Scanner(System.in);
//        System.out.print("Enter a phrase: ");
//        String userPhrase = input.nextLine();
//        userPhrase = userPhrase.toLowerCase();
//        System.out.println("The phrase is: " + userPhrase);
//        
//        //convert the input string using String methods
//        userPhrase = userPhrase.toUpperCase();
//        
//        //comparing Strings
//        String myString = "MYSTRING";
//        boolean isMatch = myString == userPhrase;
//        System.out.println(isMatch);
//        isMatch = myString.equals(userPhrase);
//        System.out.println(isMatch);
        
        char letter = 'A';
        System.out.println("Character value is: " + letter);
        //print out the equivalent decimal value of A
        int decLetter = (int) 'A';
        System.out.println("Decimal value is " + decLetter);
        
        //Let's convert that letter to its opposite case
        String userPhrase = "My dog stinks";
        char firstLetter = userPhrase.charAt(0);
        System.out.println("The first letter is " + firstLetter);
        
        int charLetter = (int) firstLetter;
        System.out.println("The decimal value of " + firstLetter + " is: " + charLetter);
        
        int toggleCharacter;
        if (charLetter >= 65 && charLetter <= 90){//uppercase
            toggleCharacter = firstLetter + 32;
        } else {
            toggleCharacter = firstLetter - 32;
        }
        
        System.out.println((char)toggleCharacter);
        
    }
}
