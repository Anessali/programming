import java.io.IOException; //automatically imported by Netbeans
import java.util.Scanner;

/**
 *
 * @author Shiro
 */
public class madlibs {

    public static void main(String[] args) throws IOException {
        String animal;
        String name;
        String village;
        String weapon;
        String bodyPart;
        String onomatopoeia;
        String verb;
        String blank;
        Scanner word = new Scanner(System.in);
        //prompt for user input
        System.out.print("Name the protagonist: ");
        name = word.next();
        System.out.print("Name the village: ");
        village = word.next();
        System.out.print("Enter a type of beast/monster: ");
        animal = word.next();
        System.out.print("Enter an object to be used as a weapon: ");
        weapon = word.next();
        System.out.print("Enter a body part: ");
        bodyPart = word.next();
        System.out.print("Enter a word that is a sound(singular): ");
        onomatopoeia = word.next();
        //Output
        System.out.print("\tThe village of " + village + " lay in ruins. Its citizens had lived a quiet, peaceful for many years,"
                + " but with winter's end an ancient beast, \na " + animal + ", had awakened.");
        System.in.read();
        System.out.print("\tSadly, there was only one survivor. Their name was " + name + ". A hunter, they were hunting outside of "
                + village + " when the " + animal + " attacked. \nIf not for the telltale signs and the dying words of a man they once called a friend, "
                        + "then they may never had known what happened.");
        System.in.read();
        System.out.print("\tEnraged, " + name + " grabbed a " + weapon + " to use as a weapon and embarked on a journey. "
                + "All knew of the " + animal + " that slumbered in the forest's deepest depths, \nbut all had avoided it until this day.");
        System.in.read();
        System.out.print("\tWhen " + name + " reached the cave, they entered quietly. Even from the entrance, " + name + " could hear the " + animal + 
                "'s " + onomatopoeia + "s echoing through the cave. \nYet " + name + " continued onward, more determined than ever.");
        System.in.read();
        System.out.print("\tWhen " + name + " found the " + animal + ", they knew they had to act quickly. With " + weapon + " in hand, they charged.");
        System.in.read();
        System.out.print("\tThe " + animal + " was caught completely off guard. " + name + " swung their " + weapon + " into the " + animal + 
                "'s " + bodyPart + ", destroying it, and the " + animal + " " + onomatopoeia + "ed furiously. \nThe " + animal + " fought hard, "
                        + "but in its weakened state it didn't stand a chance. The " + animal + " fell at the end.");
        System.in.read();
        System.out.print("\tWith evil slain and friends avenged, " + name + " left behind the ruins of " + village + ". Though some years have passed and"
                + " the journey afterwards was lost, \nit's said they eventually found a new place to call home.");
        System.in.read();
        System.out.println("\tEnd");
    }
    
}
