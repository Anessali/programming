
import java.util.Scanner;
public class Exc620 {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String s = input.nextLine();
        int countedLetters = countLetters(s);
        System.out.println("The number of letters are: " + 
                countedLetters);
    }
    
    public static int countLetters(String s){
        int numOfLetters = 0;
        for(int x = 0; x < s.length() ; x++){
            numOfLetters++;
        }
        return numOfLetters;
    }
}
