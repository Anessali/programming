
public class FeetMeters {

    
    public static void main(String[] args) {
        //variables declared at 1 and 20 to match hypergrade
        double feet = 1, 
                meters = 20;
        boolean exitVar = false;
        // *~~~ Headers ~~~*
        System.out.printf("%4s%10s%20s%10s\n", "Feet", "Meters", "Meters", "Feet");
        System.out.println("---------------------------------------------");
        //data output
        for (int i = 0; i < 10 ; i++){
            System.out.printf("%4.1f%10.3f%20.1f%10.3f\n", feet, fTM(feet), meters, mTF(meters));
            //feet and meters incremented to show conversion for 10 different values
            feet += 1;
            meters += 5;
        }
    }
    
    //fTM = feet to meters
    public static double fTM(double feet){
        feet = 0.305 * feet;
        return feet;
    }
    
    //mTF = meters to feet
    public static double mTF(double meters){
        meters = 1 / 0.305  * meters;
        return meters;
    }
}
