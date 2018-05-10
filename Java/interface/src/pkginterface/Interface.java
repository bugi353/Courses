/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkginterface;

import java.util.Arrays;
import java.util.Collections;

/**
 *
 * @author Piotr
 */
public class Interface {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        Pracownik[] pracownik = new Pracownik[3];
        pracownik[0] = new Pracownik(10000);
        pracownik[1] = new Pracownik(1000);
        pracownik[2] = new Pracownik(5000);
        
        for(Pracownik p: pracownik)
        {
            System.out.println(p.getWynagrodzenie());
        }
        
        System.out.println("Rosnąco");
        
        Arrays.sort(pracownik);
        
        for(Pracownik p: pracownik)
        {
            System.out.println(p.getWynagrodzenie());
        }
        
        System.out.println("Malejąco");
        
        Arrays.sort(pracownik, Collections.reverseOrder());
        
        for(Pracownik p: pracownik)
        {
            System.out.println(p.getWynagrodzenie());
        }
    }
    
}

class Pracownik implements Comparable
{
    private int wynagrodzenie;
    
    Pracownik(int wynagrodzenie)
    {
        this.wynagrodzenie = wynagrodzenie;
    }
    
    public int getWynagrodzenie()
    {
        return this.wynagrodzenie;
    }

    @Override
    public int compareTo(Object t) 
    {
        Pracownik przyslany = (Pracownik)t;
         if(this.wynagrodzenie < przyslany.wynagrodzenie)
             return -1;
         else if(this.wynagrodzenie > przyslany.wynagrodzenie)
             return 1;
         
         return 0;
    }
    
}