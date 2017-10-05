import java.util.Scanner;
public class GameZone {

    public static void main(String[] args) {
        //
        String[] questions = {""};
        String[] answerStorage;
        
        
        
        for (int i = 1; i < 10; i++){
            switch (i){
                case 1:
                    System.out.println(questions[i - 1]);
                    question1();
                break;
                case 2: 
                    System.out.println(questions[i - 1]);
                    question2();
                break;
                case 3: 
                    System.out.println(questions[i - 1]);
                    question3();
                break;
                case 4: 
                    System.out.println(questions[i - 1]);
                    question4();
                break;
                case 5: 
                    System.out.println(questions[i - 1]);
                    question5();
                break;
                case 6: 
                    System.out.println(questions[i - 1]);
                    question6();
                break;
                case 7: 
                    System.out.println(questions[i - 1]);
                    question7();
                break;
                case 8: 
                    System.out.println(questions[i - 1]);
                    question8();
                break;
                case 9: 
                    System.out.println(questions[i - 1]);
                    question9();
                break;
                case 10: 
                    System.out.println(questions[i - 1]);
                    question10();
                break;
            }
        }
    }
    
    public static void question1(){
        System.out.println("This is method 1");   
    }
    public static void question2(){
        System.out.println("This is method 2");   
    }
    public static void question3(){
        System.out.println("This is method 3");
    }
    public static void question4(){
        System.out.println("This is method 4");
    }
    public static void question5(){
        System.out.println("This is method 5");
    }
    public static void question6(){
        System.out.println("This is method 6");
    }
    public static void question7(){
        System.out.println("This is method 7");
    }
    public static void question8(){
        System.out.println("This is method 8");
    }
    public static void question9(){
        System.out.println("This is method 9");
    }
    public static void question10(){
        System.out.println("This is method 10");
    }
}
