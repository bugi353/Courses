/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pętle;

/**
 *
 * @author Piotr
 */
import java.util.Scanner;

public class Pętle {

    /**
     * @param args the command line arguments
     */
    
    
    public static void main(String[] args) 
    {
        int i = 0;
        int ile;
        Scanner odczyt = new Scanner(System.in);
        
        System.out.print("Ile liczb chcesz wczytać?");
        ile = odczyt.nextInt();
        
        int[] tab = new int [ile];
        
        while (i<tab.length)
        {
        System.out.print("Podaj "+(i+1)+" liczbe:");
        tab[i] = odczyt.nextInt();
        
        i++;
        }
        
        i = 0;
        
         while (i<tab.length)
        {
        System.out.println(i+1+" liczba to: "+ tab[i]);
        i++;
        }
    }
    
}
