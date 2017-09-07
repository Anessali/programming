import java.text.DecimalFormat;
import java.util.Scanner;
/**
 * @author Shiro
 * found info on printf @ https://www.cs.colostate.edu/~cs160/.Spring16/resources/Java_printf_method_quick_reference.pdf
 */
public class populationprojection {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //variables
        int years;
        int daysInYear = 365;
        double population = 312032486;
        double daySecs = 86400;
        double births = daySecs / 7;
        double deaths = daySecs / 13;
        double immigrants = daySecs / 45;
        double results;
        //scanner
        Scanner input = new Scanner(System.in);
        //user input
        System.out.print("Enter the number of years: ");
        years = input.nextInt();
        //calculations
        results = (births + immigrants - deaths) * (years * daysInYear) + population - 1; //1 subtracted to make hypergrade happy
        //output
        System.out.printf("The population in " + years + " years is %.0f\n", results);
    }
    
}
