/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author shiro
 */
public class Tester {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int count = 0;
        boolean cat = true;
        while (cat){
            count++;
            System.out.println(count);
            if (count == 100) {
                cat = false;
            }
        }
    }
    
}
