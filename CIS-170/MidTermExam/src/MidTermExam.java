import java.util.Scanner;
public class MidTermExam {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        long credNum = 0;
        int numLength,
            credLength, //represents # of doubled digits
            numDouble, //holds doubled digits
            numMod, //will hold last number in long
            oddNum; //holds odd numbers
        
        //user input
        System.out.print("Enter a credit card number: ");
        credNum = input.nextLong();
        /*************************************************************
         * credNum is converted to string to get length divided by 2 *
         * credLength = the number of values being doubled           *
         *************************************************************/
        credLength = Long.toString(credNum).length() / 2;
        int numHolder[] = new int[credLength]; 
        int oddHolder[] = new int[credLength];
        for (int i = 0; i < credLength; i++) {
            //collects second digit from right
            numMod = (int) (((credNum - (credNum % 10)) / 10) % 10);
            //odd number stored
            oddNum = (int) (credNum % 10);
            //removes last two digits from credNum
            credNum = (credNum - credNum % 10) / 10;
            credNum = (credNum - credNum % 10) / 10;
            //doubles collected number
            numDouble = numMod * 2;
            //double digit number's digits are added up
            numLength = Long.toString(numDouble).length();
            if (numLength > 1){
                numDouble = getDigit(numLength, numDouble);
            }
            //numbers stored in array
            numHolder[i] = numDouble;
            oddHolder[i] = oddNum;
        }
        
        int evenSum = sumOfDoubleEvenPlace(numHolder);
        int oddSum = sumOfOddPlace(oddHolder);
        boolean isItValid = isValid(evenSum, oddSum);
        
        
        
    }//end of main
    
    public static boolean isValid(long credNum){
        boolean creditCard;
        
        return creditCard;
    }
    
    public static int sumOfDoubleEvenPlace(int[] evenNums){
        int numSum = 0;
        for(int i = 0; i < evenNums.length; i++){
            numSum = numSum + evenNums[i];
        }
        return numSum;
    }
    
    public static int sumOfOddPlace(int[] oddNums){
        int numSum = 0;
        for(int i = 0; i < oddNums.length; i++){
            numSum = numSum + oddNums[i];
        }
        return numSum;
    }
    
    //10 = 3 (1 + 2)
    public static int getDigit(int numLength, int num){
        int numOne, numTwo;
        for (int x = 0; x < numLength; x++){
            numOne = num % 10;
            numTwo = (num - numOne) / 10;
            num = numOne + numTwo;
        }
        return num;
    }
}