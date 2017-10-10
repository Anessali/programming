import java.util.Random;
import java.util.Scanner;

public class Hangman {

    public static void main(String[] args) {
        /*=========================*
         *      Hangman Game       *
         *=========================*/
        Random rand = new Random();
        Scanner guess = new Scanner(System.in);
        
        /*~~~  Generated Variables  ~~~*/
        //Array 1 - holds words
        String[] words = {"banana", "cobra", "onomatopoeia", "security", "bahamas"};
        int randNum = rand.nextInt(words.length);
        //Array 2 - correct answers
        char[] corAnswers = new char[words[randNum].length() + 5];
        //Array 3 - incorrect answers
        char[] incAnswers = new char[words[randNum].length() + 5];
        int correct = 0,
            incorrect = 0;
        char guessLetter;
        boolean lever = false;
        //number of stars in theWord set by words array length
        String theWord = "";
        for(int i = 0; i < words[randNum].length(); i++){
            theWord += "*";
        }
        /*~~~  Program Processing  ~~~*/
        while (lever == false) {
            System.out.println("Guess a letter");
            guessLetter = guess.next().charAt(0);
            correct += check(guessLetter, words[randNum], theWord);
            incorrect += wrong(guessLetter, words[randNum]);
            //if/for/else adds correct and incorrect answers to arrays
            if (check(guessLetter, words[randNum], theWord) >= 1){
                corAnswers[correct - 1] = guessLetter;
            } else {
                incAnswers[incorrect] = guessLetter;
            }
            //calls method to generate theWord
            theWord = checkString(guessLetter, words[randNum],theWord);
            /*~~~  Output  ~~~*/
            System.out.println("Correct answers:");
            System.out.println(theWord);
            System.out.println("\nIncorrect answers: ");
            for (int inc = 0; inc < corAnswers.length; inc++){
                System.out.print(incAnswers[inc]);
            }
            System.out.println("\nYou've gotten " + correct + " correct");
            System.out.println("You have " + (6 - incorrect) + " guesses remaining");
            //loser output
            if(incorrect == 6){
                System.out.println("Sorry, but you've lost! Feel free to try again.");
                lever = true;
            } 
            //winner output
            if(correct == words[randNum].length()){
                System.out.println("You've won! The word was:\n" + words[randNum]);
                lever = true;
            }
        }
    }//end of main
    
    //calculates incorrect answers
    public static int wrong(char guess, String word){
        int count = 0,
            incorrect = 0;
        for(int i = 0; i < word.length(); i++){
            if (guess == word.charAt(i)){
              count++;  
            } 
        }
        if(count == 0){
            incorrect = 1;
        }
        return incorrect;
    }
    
    //checks if guess is correct
    public static int check(char guess, String word, String newWord){
        int correct= 0;
        for(int i = 0; i < word.length(); i++){
            //chars are pulled directly from string
            if (guess == word.charAt(i)) {
                correct++;
            }
        }
        return correct;
    }//end of method
    
    public static String checkString(char guess, String word, String newWord){
        int correct = 0;
        for(int i = 0; i < word.length(); i++){
            //chars are pulled directly from string
            if (guess == word.charAt(i)) {
                
                correct++;
            }
        }
        return newWord;
    }//end of method
}