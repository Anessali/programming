import java.util.Scanner;
public class GameZone {

    public static void main(String[] args) {
        //
        String[] questions = {
            "What's the Japanese word for friend?", //#1 
            "What should you do if you get attacked by a mountain lion?", //#2 
            "What is Kirsten's favorite type of soda?", //#3
            "Is TJ going to get an A on this assignment?", //#4
            "英語は何ですか？", //#5
            "How many questions are on this quiz?", //#6 
            "What's the best holiday?", //#7
            "Which animal is the cutest?", //#8
            "Are you a boy or a girl?", //#9
            "What year is it?", //#10
        };
        String[] answers = {
            "b", //#1 
            "b", //#2
            "a", //#3
            "c", //#4
            "c", //#5
            "a", //#6
            "c", //#7
            "c", //#8
            "a", //#9
            "b" //#10
        };
        Scanner input = new Scanner(System.in);
        String response = "";
        int i = 1; //acts as count
        int aCount = 0; //count for answers
        boolean repBool = response.equals("a") || response.equals("b") || response.equals("c");
        
        //
        while (repBool == false) {
            System.out.println(questions[i - 1]);
            System.out.println("\tA. Namae\n" 
                             + "\tB. Tomodachi\n" 
                             + "\tC. Ohayou");
            response = input.nextLine();
            response = response.toLowerCase();
            System.out.println(response);
            if (response.equals(answers[i - 1])){
                System.out.println("Correct!");
                aCount++;
            }
            break;
        }
        i++;
        while (repBool == false) {
            System.out.println(questions[i - 1]);
            System.out.println("\tA. Punch it in the snoot\n" 
                             + "\tB. Give it the finger\n" 
                             + "\tC. Run away");
            response = input.nextLine();
            response = response.toLowerCase();
            if (response.equals(answers[i - 1])){
                    System.out.println("Correct!");
                    aCount++;
                }
            break;
        }
        i++;
        while (repBool == false) {
            System.out.println(questions[i - 1]);
            System.out.println("\tA. Dr. Pepper\n" 
                             + "\tB. She only drinks vodka\n" 
                             + "\tC. Sprite");
            response = input.nextLine();
            response = response.toLowerCase();
            if (response.equals(answers[i - 1])){
                    System.out.println("Correct!");
                    aCount++;
                }
            break;
        }
        i++;
        while (repBool == false) {
            System.out.println(questions[i - 1]);
            System.out.println("\tA. Who's TJ?\n" 
                             + "\tB. No\n" 
                             + "\tC. Yes");
            response = input.nextLine();
            response = response.toLowerCase();
            if (response.equals(answers[i - 1])){
                    System.out.println("Correct!");
                    aCount++;
                }
            break;
        }
        i++;
        while (repBool == false) {
            System.out.println(questions[i - 1]);
            System.out.println("\tA. boxboxboxbox\n" 
                             + "\tB. Um... a language?\n" 
                             + "\tC. This question is stupid");
            response = input.nextLine();
            response = response.toLowerCase();
            if (response.equals(answers[i - 1])){
                    System.out.println("Correct!");
                    aCount++;
                }
            break;
        }
        i++;
        while (repBool == false) {
            System.out.println(questions[i - 1]);
            System.out.println("\tA. 5 + 5\n" 
                             + "\tB. 122 - 120\n" 
                             + "\tC. 9");
            response = input.nextLine();
            response = response.toLowerCase();
            if (response.equals(answers[i - 1])){
                    System.out.println("Correct!");
                    aCount++;
                }
            break;
        }
        i++;
        while (repBool == false) {
            System.out.println(questions[i - 1]);
            System.out.println("\tA. Christmas\n" 
                             + "\tB. Halloween\n" 
                             + "\tC. TJ's Birthday");
            response = input.nextLine();
            response = response.toLowerCase();
            if (response.equals(answers[i - 1])){
                    System.out.println("Correct!");
                    aCount++;
                }
            break;
        } 
        i++;
        while (repBool == false) {
            System.out.println(questions[i - 1]);
            System.out.println("\tA. Doggos\n" 
                             + "\tB. Cats\n" 
                             + "\tC. You");
            response = input.nextLine();
            response = response.toLowerCase();
            if (response.equals(answers[i - 1])){
                    System.out.println("Correct!");
                    aCount++;
                }
            break; 
        }
        i++;

        while (repBool == false) {
            System.out.println(questions[i - 1]);
            System.out.println("\tA. Is this pokémon?\n" 
                             + "\tB. Boy\n" 
                             + "\tC. Girl");
            response = input.nextLine();
            response = response.toLowerCase();
            if (response.equals(answers[i - 1])){
                    System.out.println("Correct!");
                    aCount++;
                }
            break; 
        }
        i++;
        while (repBool == false) {
            System.out.println(questions[i - 1]);
            System.out.println("\tA. 1885\n" 
                             + "\tB. 2017\n" 
                             + "\tC. 3700");
            response = input.nextLine();
            response = response.toLowerCase();
            if (response.equals(answers[i - 1])){
                    System.out.println("Correct!");
                    aCount++;
                }
            break;
        }
        /*~ displays number of correct ~*/
        int incorrectAnswers = answers.length - aCount;
        System.out.println("You missed " + incorrectAnswers + " answers.");
        System.out.println("You got " + aCount + " answers correct.");
    }//end of main
    
    public static void correct(){
        
        System.out.println("Correct!");
    }
}
