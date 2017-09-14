import java.util.Scanner;
public class CdValue {
    
    public static void main(String[] args) {
       Scanner cash = new Scanner(System.in);
       
       System.out.println("How much money are you depositing?");
       double money = cash.nextDouble();
       System.out.println("What's the annual percentage yield?");
       double yield = cash.nextDouble();
       System.out.println("How many months?");
       int months = cash.nextInt();
       Calc(money, yield, months);
    }
    
    static void Calc(double money, double yield, int months){
        
        double value = money + money * yield / 1200;
        System.out.println("Month\t CD Value");
        for(int i = 1; i <= months; i++){
            System.out.print(i);
            System.out.printf("\t %,.2f\n", value);
            money = value;
            value = money + money * yield / 1200;
        }
    }
}
