/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg7.pkg1;

import java.util.Scanner;

/**
 *
 * @author Owner
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        int answer = (int) (Math.random() * 100 + 1);
        int guess = 0, count = 0;
        while (count < 10) {
            System.out.print("I'm thinking of a number between 1 and 100. (You get 10 guesses) ");
            guess = reader.nextInt();
            if (guess == answer) {
                break;
            }else if (guess > answer){
                System.out.println("No, the number is less.");
                count++;
            }else if (guess < answer){
                System.out.println("No, the number is more.");
                count++;
            }else
                System.out.println("Please enter a valid value.");
        }
        if ((guess == answer) && (count < 10))
            System.out.println("Correct! The answer was " + answer);
        else 
            System.out.println("Sorry, you lose, the answer was " + answer);
    }

}
