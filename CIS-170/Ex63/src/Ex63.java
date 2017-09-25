import java.util.Scanner;
public class Ex63 {

    
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter a number to test if it's a palindrome: ");
        int num = input.nextInt();
        reverse(num);
    }
    
    //should return the reverse of passed value
    public static int reverse(int number){
        boolean p;
        int oldNum = number; //old value saved to test palindrome
        int reverse = 0;
        while (number != 0){
            reverse = reverse * 10 + number % 10;
            number = number / 10;
        }
        p = isPalindrome(oldNum, reverse);
        System.out.println(p);
        return oldNum;
    }
    //return true if number is same backwards)
    public static boolean isPalindrome(int old, int rev){
        boolean palindrome = true;
        if(old != rev){
            palindrome = false;
        }
        return palindrome;
    }
}