/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dziedziczenie.potwor;

/**
 *
 * @author Piotr
 */
public abstract class Potwor {
    public double predkoscChodzenia = 10;
    public double zywotnosc;
    
    public void atakuj()
    {
        /*
        
        
        */
        
        System.out.println("To jest metoda atakuj z klasy Potwor");
    }
    
    public Potwor()
    {
        System.out.println("Domyślny konstruktor klasy Potwor");
    }
    
    public Potwor(double predkoscChodzenia, double zywotnosc)
    {
        this.predkoscChodzenia = predkoscChodzenia;
        this.zywotnosc = zywotnosc;
        System.out.println("NieDomyślny konstruktor klasy Potwor");
    }
}
