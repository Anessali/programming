
public class FeetMeters {

    
    public static void main(String[] args) {
        //declared variables
        double feet = 4;
        double meters = 4;
        boolean exitVar = false;
        //double fTM, mTF; //variables used to hold converted values
        System.out.printf("%4s%10s%20s%10s\n", "Feet", "Meters", "Meters", "Feet");
        System.out.println("---------------------------------------------");
        
        System.out.printf("%4.1f%10.3f%20.1f%10.3f\n", feet, fTM(feet), meters, mTF(meters));
    }
    
    public static double fTM(double feet){
        feet = 0.305 * feet;
        return feet;
    }
    
    public static double mTF(double meters){
        meters = 0.305 * feet;
        return meters;
    }
}
