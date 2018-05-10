/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dziedziczenie;

import dziedziczenie.potwor.Potwor;
import dziedziczenie.potwor.Szkielet;
import dziedziczenie.potwor.Zombie;

/**
 *
 * @author Piotr
 */
public class Dziedziczenie {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
//        Potwor p = new Potwor();
//        Szkielet s = new Szkielet(50, 20);
        Zombie z = new Zombie();
        
        Potwor x = new Szkielet();
        
        z.atakuj();
//        s.atakuj();
    }
    
}
