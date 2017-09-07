import java.util.Scanner;

public class Janken {

    public static void main(String[] args) {
        // declared variables
        Scanner input = new Scanner(System.in);
        String cNum = ""; //computer string
        String uNum = ""; //user string
        int compNum = (int) (Math.random() * 3);
        //prompts for user input
        System.out.print("scissor (0), rock (1), paper (2): ");
        int userNum = input.nextInt();
        //data processing
        switch (compNum) {
            case 0:
                cNum = "The computer is scissor. ";
                break;
            case 1:
                cNum = "The computer is rock. ";
                break;
            case 2:
                cNum = "The computer is paper. ";
                break;
        }
        switch (userNum) {
            case 0:
                uNum = "You are scissor. ";
                break;
            case 1:
                uNum = "You are rock. ";
                break;
            case 2:
                uNum = "You are paper. ";
                break;
        }
        /*
        * Game output below
        * 0 = scissors
        * 1 = rock
        * 2 = paper
        * */
        if (compNum == userNum) {
            System.out.print(cNum + uNum + "It's a tie");
        }
        else if(compNum == 0 && userNum == 1){
            System.out.print(cNum + uNum + "You won");
        }
        else if(compNum == 0 && userNum == 2){
            System.out.print(cNum + uNum + "You lost");
        }
        else if(compNum == 1 && userNum == 0){
            System.out.print(cNum + uNum + "You lost");
        }
        else if(compNum == 1 && userNum == 2){
            System.out.print(cNum + uNum + "You won");
        }
        else if(compNum == 2 && userNum == 0){
            System.out.print(cNum + uNum + "You won");
        }
        else if(compNum == 2 && userNum == 1){
            System.out.print(cNum + uNum + "You lost");
        } else {
            System.out.print("Error. Please enter a valid number.");
        }
    }
}