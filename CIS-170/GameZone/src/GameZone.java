import java.util.Scanner;
public class GameZone {

    public static void main(String[] args) {
        //
        String[] questions = {
            "What's the Japanese word for friend?", 
            "What should you do if you get attacked by a mountain lion?", 
            "What is Kirsten's favorite type of soda?", 
            "Is TJ going to get an A on this assignment?", 
            "5",
            "6", 
            "7", 
            "8", 
            "9", 
            "10",
        };
        String[] answers = {"b", "b", "a", "c"};
        Scanner input = new Scanner(System.in);
        
        /**********************************
         * Below code loops through switch*
         * to ask questions               *
         **********************************/
        for (int i = 1; i <= questions.length; i++){
            switch (i){
                case 1:
                    System.out.println(questions[i - 1]);
                    System.out.println("\tA. Namae\n" 
                                     + "\tB. Tomodachi\n" 
                                     + "\tC. Ohayou");
                break;
                case 2: 
                    System.out.println(questions[i - 1]);
                    System.out.println("\tA. Punch it in the snoot\n" 
                                     + "\tB. Give it the finger\n" 
                                     + "\tC. Run away");
                break;
                case 3: 
                    System.out.println(questions[i - 1]);
                    System.out.println("\tA. Dr. Pepper\n" 
                                     + "\tB. She only drinks vodka\n" 
                                     + "\tC. Sprite");
                break;
                case 4: 
                    System.out.println(questions[i - 1]);
                    System.out.println("\tA. Who's TJ?\n" 
                                     + "\tB. No\n" 
                                     + "\tC. Yes");
                break;
                case 5: 
                    System.out.println(questions[i - 1]);
                    System.out.println("\tA. \n" 
                                     + "\tB. \n" 
                                     + "\tC. ");
                break;
                case 6: 
                    System.out.println(questions[i - 1]);
                    System.out.println("\tA. \n" 
                                     + "\tB. \n" 
                                     + "\tC. ");
                break;
                case 7: 
                    System.out.println(questions[i - 1]);
                    System.out.println("\tA. \n" 
                                     + "\tB. \n" 
                                     + "\tC. ");
                break;
                case 8: 
                    System.out.println(questions[i - 1]);
                    System.out.println("\tA. \n" 
                                     + "\tB. \n" 
                                     + "\tC. ");
                break;
                case 9: 
                    System.out.println(questions[i - 1]);
                    System.out.println("\tA. \n" 
                                     + "\tB. \n" 
                                     + "\tC. ");
                break;
                case 10: 
                    System.out.println(questions[i - 1]);
                    System.out.println("\tA. \n" 
                                     + "\tB. \n" 
                                     + "\tC. ");
                break;
            }
        }
    }
}
