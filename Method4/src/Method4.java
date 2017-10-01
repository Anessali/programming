
import java.util.Scanner;
public class Method4 {

    static Scanner input = new Scanner(System.in);
    public static void main(String[] args) {
        
        String userName = getName(); 
        
        //NEW
        int usrAge = getAge();
        //printAgeAndName(userName, usrAge);
        printGreeting(userName);
        printGreeting(usrAge);
        printGreeting(usrAge, userName);
        
        //printName(userName); 
        System.out.println("End of program!");
    }
    
    public static String  getName(){ //**** add STRING return
        
        System.out.println("What is your name");       
        String name = input.nextLine();       
       
        
        return name; // return name
        
        
    }
    
    public static void printGreeting(String name){
        System.out.printf("Hello %s\n", name);
    }
    
    public static void printGreeting(int age){
        System.out.printf("Your age is %d\n", age);
    }
    
    public static void printGreeting(int age, String name){
        System.out.printf("Hello %s\n", name);
        System.out.printf("Your age is %d\n", age);
        System.out.printf("From the overloaded method");
    }
    
//    public static void printName(String userName){
//       System.out.println(userName + " from printName()");
//                    
//    }  
    
    //Add a new function
    public static int getAge(){
        
        System.out.println("What is your age");
        int age = input.nextInt();
        return age;
    }
    
//    public static void printAgeAndName(String userName, int userAge){
//        System.out.println(userName + ": age " + userAge);
//    }
    
}

