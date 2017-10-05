
import java.util.Random;
public class RandomExample {

    public static void main(String[] args) {
        String[] words = {"fancy", "swimming",
            "Tom Petty"};
        Random rand = new Random();
        int randomNum = rand.nextInt(3);
        //System.out.println(words[randomNum]);
        
        String[] aryReverse = reverseArray(words);
        for (int i = 0; i < words.length; i++){
            System.out.println(aryReverse[i]);
        }
    }
    
    public static String[] reverseArray(String[] ary) {
        String tmp[] = new String[ary.length];
        int j = tmp.length - 1;
        
        for (int i = 0; i < tmp.length; i++){
            tmp[i] = ary[j];
            j--;
        }
        return tmp;
    }
}
