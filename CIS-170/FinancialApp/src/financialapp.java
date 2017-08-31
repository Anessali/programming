import java.util.Scanner;

/**
 *
 * @author Shiro
 */
public class financialapp {
    
    public static void main(String[] args) {
        double gratuity, subtotal;
        Scanner userInput = new Scanner(System.in);
        System.out.print("Enter subtotal: ");
        subtotal = userInput.nextDouble();
        System.out.print("Enter gratuity percentage: ");
        gratuity = userInput.nextDouble();
        gratuity = gratuity * 0.1;
        System.out.println("The gratuity is " + gratuity 
                + " subtotal is: " + (subtotal + gratuity));
    }
    
}
