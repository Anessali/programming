import java.util.Scanner;
public class ThreeCities {

    public static void main(String[] args) {
        Scanner city = new Scanner(System.in);
        String cityOne, cityTwo, cityThree;
        String one = "", two = "", three = "";
        int valueOne, valueTwo, valueThree;
        
        //input
        System.out.print("Enter the first city: ");
        cityOne = city.nextLine();
        System.out.print("Enter the second city: ");
        cityTwo = city.nextLine();
        System.out.print("Enter the third city: ");
        cityThree = city.nextLine();
        
        //process
        valueOne = cityOne.charAt(0);
        valueTwo = cityTwo.charAt(0);
        valueThree = cityThree.charAt(0);
        
        //first city first
        if(valueOne < valueTwo && valueOne < valueThree){
            one = cityOne;
            if(valueTwo < valueThree){
                two = cityTwo;
                three = cityThree;
            }
            else{
                two = cityThree;
                three = cityTwo;
            }
        }
        //second city first
        else if(valueTwo < valueOne && valueTwo < valueThree){
            one = cityTwo;
            if(valueOne < valueThree){
                two = cityOne;
                three = cityThree;
            }
            else{
                two = cityThree;
                three = cityOne;
            }
        }
        
        //third city first
        if(valueThree < valueOne && valueThree < valueTwo){
            one = cityThree;
            if(valueOne < valueTwo){
                two = cityOne;
                three = cityTwo;
            }
            else{
                two = cityTwo;
                three = cityOne;
            }
        }
        
        //output
        System.out.print("The three cities in alphabetical order are " + one + " "
                + two + " " + three);
    }
    
}
