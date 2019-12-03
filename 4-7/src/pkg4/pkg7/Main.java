/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg4.pkg7;
import java.util.Scanner;
/**
 *
 * @author Owner
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    //                              Error here \/
    public static void main(String[] args) throws Exception {
        System.out.println("Please enter the base and exponent desired, separated by a space (Or enter -1 to quit)");
        Scanner reader = new Scanner("numbers.txt");
        int base=0, exp;
        
        while (reader.hasNext()) {
            base = reader.nextInt();
            if (base==-1)
                break;
            exp = reader.nextInt();
            
            for (int i = 0; i < exp; i++) 
                System.out.print((int)Math.pow(base, i) + ", ");
            
            System.out.println("");
        }
    }
    
}
