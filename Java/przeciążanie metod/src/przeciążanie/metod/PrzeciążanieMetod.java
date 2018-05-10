/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package przeciążanie.metod;

/**
 *
 * @author Piotr
 */
public class PrzeciążanieMetod {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        
        Dupa d = new Dupa();
        d.metoda(1,2,2);
    }
    
    
    
}

class Dupa
{
    void metoda(int a, int b)
    {
        int suma = a + b;
         System.out.println(suma);
    }
    void metoda(int a, int b, int c)
    {
        int suma = a + b + c;
        System.out.println(suma);
         System.out.println("przeciążenie");
    }
}