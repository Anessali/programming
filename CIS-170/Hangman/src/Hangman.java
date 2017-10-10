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
        String[] words = {"banana", "cobra"/*, "onomatopoeia", "security"*/};
        int randNum = rand.nextInt(words.length);
        //Array 2 - correct answers
        char[] corAnswers = new char[randNum];
        //Array 3 - incorrect answers
        char[] incAnswers = new char[randNum];
        int correctAnswers = 0,
            incorrect = 0;
        char guessLetter;
        boolean lever = false;
        
        
        /*~~~  Program Processing  ~~~*/
        while (lever == false) {
            //letters = generateCorrect(letters, words, randNum);
            System.out.println("Guess a letter");
            guessLetter = guess.next().charAt(0);
            correctAnswers += check(guessLetter, words[randNum]);
            incorrect += wrong(guessLetter, words[randNum]);
            //if/for/else adds correct and incorrect answers to arrays
            if (check(guessLetter, words[randNum]) >= 1){
                for (int i = 0; i < corAnswers.length; i++){
                    corAnswers[i] = guessLetter;
                }
            } else {
                for (int i = 0; i < corAnswers.length; i++){
                    incAnswers[i] = guessLetter;
                }
            }
            
            
            /*~~~  Output  ~~~*/
            System.out.println("So far you've guessed: ");
            for (int cor = 0; cor < corAnswers.length; cor++){
                System.out.print(corAnswers[cor]);
            }
            System.out.println("\nYou've guessed the following incorrect letters: ");
            for (int inc = 0; inc < corAnswers.length; inc++){
                System.out.print(incAnswers[inc]);
            }
            
            System.out.println("\nYou've gotten " + correctAnswers + " correct");
            System.out.println("You have " + (6 - incorrect) + " guesses remaining");
            //loser output
            if(incorrect == 6){
                System.out.println("Sorry, but you've lost! Feel free to try again.");
                lever = true;
            } 
            //winner output
            if(correctAnswers == words[randNum].length()){
                output(words[randNum]);
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
    public static int check(char guess, String word){
        int correct= 0;
        for(int i = 0; i < word.length(); i++){
            //chars are pulled directly from string
            if (guess == word.charAt(i)) {
                System.out.print(guess);
                correct++;
            }
            else{
                System.out.print("*");
            }
        }
        System.out.println();
        return correct;
    }
    
    //program output
    public static void output(String word){
        System.out.println("You've won! The word was: ");
        System.out.print(word);
        System.out.println();
    }
}
