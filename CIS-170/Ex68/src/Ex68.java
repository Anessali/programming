import java.util.Scanner;
public class Ex68 {

    public static void main(String[] args) {
        //declared variables
        Scanner input = new Scanner(System.in);
        double temp = 0;
        double converted = 0;
        String tempType = "";
        //console menu prompts for user choice
        System.out.println("What would you like to convert?");
        System.out.println("\t1 - Celsius to Fahrenheit");
        System.out.println("\t2 - Fahrenheit to Celsius");
        int choice = input.nextInt();
        if (choice == 1){
            System.out.print("Enter temperature: ");
            temp = input.nextDouble();
            converted = celsiusToFahrenheit(temp);
        }
        if (choice == 2){
            System.out.print("Enter temperature: ");
            temp = input.nextDouble();
            converted = fahrenheitToCelsius(temp);
        }

        //prints results
        System.out.println(temp + " in " + tempType + " is: " + converted);
        
    }
    
    public static double celsiusToFahrenheit(double celsius){
        double fahr = (9.0 / 5) * celsius + 32;
        return fahr;
    }
    
    public static double fahrenheitToCelsius(double fahrenheit){
        double cels = (5.0 / 9) * (fahrenheit - 32);
        return cels;
    }
    
    public void enterTemp(){
        System.out.print("Enter temperature: ");
    }
}