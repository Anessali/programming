
import java.util.Scanner;
public class GameCharacter {
   /*
    * Character has name. Job if applicable
    * Character level. Possible subclass
    * 
    */
    public static void main(String[] args) {
        String character = "",
                name = "",
                job = "";
        int doubleExpTuesday = 0;
        double payrate = 0;
        boolean bSwitch = true;
        Scanner person = new Scanner(System.in);
        //while prevents user from entering blank name
        while (name == ""){
            System.out.print("Enter your character's name: ");
            name = person.nextLine();
            if (name == ""){ 
                System.out.println("Please enter a valid name");
            }
        }
        System.out.print("Enter your character's job(cook, hunter, etc): ");
        job = person.nextLine();
        //prompts for their pay if they have a job
        if (job != ""){
            System.out.print("Enter your character's pay per hour: $");
            payrate = person.nextDouble();
        }
        //code determines which Character method is used
        if (job == ""){
            character += Character(name);
        } 
        else if (job != "" && payrate != 0){
            character += Character(name, job, payrate);
        } else {
            character += Character(name, job);
        }
        System.out.print("How much experience have they earned today? ");
        int exp = person.nextInt();
        //while ensures user enters yes or no
        while (bSwitch){
            System.out.println("Is it double exp Tuesday?\n 1 - yes\n 2 - no");
            doubleExpTuesday = person.nextInt();
            //doubleExpTuesday.toLowerCase();
            if (doubleExpTuesday == 1 || doubleExpTuesday == 2){
                bSwitch = false;
            }
        }
        if(doubleExpTuesday == 2){
            character += Experience(exp);
        } else {
            character += Experience(exp, doubleExpTuesday);
        }
        System.out.print(character);
    }//end of main method
    
    //first method
    public static String Character(String name){
        String character = name + " is a lousy bum.\n";
        return character;
    }
    
    //first overloaded method
    public static String Character(String name, String job){
        String character = name + " is a " + job + ", but their pay is mysterious.\n";
        return character;
    }
    
    //second overloaded method
    public static String Character(String name, String job, double paycheck){
        String character = name + " is a " + job + " that makes $" + paycheck + " an hour.\n";
        return character;
    }
    
    //second method
    public static String Experience(int exp){
        String character = "Your character has earned " + exp + " experience.\n";
        return character;
    }
    
    //third overloaded method
    public static String Experience(int exp, int doubleExpTuesday){
        exp = exp * 2;
        String character = "Your character has earned " + exp + " experience.\n";
        return character;
    }
}
