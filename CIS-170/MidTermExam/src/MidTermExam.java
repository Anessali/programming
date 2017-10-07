import java.util.Scanner;
public class MidTermExam {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        long credNum = 0;
        long numMod; //will hold last number in long
        long numDouble; //holds doubled digits
        int credLength; //represents # of doubled digits
        //user input
        System.out.print("Enter a credit card number: ");
        credNum = input.nextLong();
        
        /*************************************************************
         * credNum is converted to string to get length divided by 2.*
         * credLength = the number of values being doubled           *
         * numHolder array is used to hold doubled numbers           *
         *************************************************************/
        credLength = Long.toString(credNum).length() / 2;
        int numHolder[] = new int[credLength]; 
        System.out.println("Cred length: " + credLength);
        /******************************************************************************
         * numMod collects the second digit from the right. The rest of the math      * 
         * further breaks down the number to reach every second digit.                *
         ******************************************************************************/
        for (int i = 0; i < credLength; i++) {
            numMod = ((credNum - (credNum % 10)) / 10) % 10;
            numDouble = numMod * 2;
            System.out.println("Doubled number: " + numDouble);
        }
        
    }//end of main
    
//    public static boolean isValid(long credNum){
//        boolean creditCard;
//        return creditCard;
//    }
    
//    public static int sumOfDoubleEvenPlace(){
//        
//    }
    
    
    
}
