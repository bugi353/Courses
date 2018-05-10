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
public class Szkielet extends Potwor

{
    String typBroni;
    
    @Override
    public void atakuj()
    {
        System.out.println("metoda atakuj klasy szkielet");
    }
    
    public Szkielet()
    {
        System.out.println("Domyślny konstruktor klasy Szkielet");
    }
    
    public Szkielet(double predkoscChodzenia, double zywotnosc)
    {
        super(predkoscChodzenia, zywotnosc);
        
        System.out.println("NieDomyślny konstruktor klasy Szkielet");
    }
    public Szkielet(double predkoscChodzenia, double zywotnosc, String typBroni)
    {
        super(predkoscChodzenia, zywotnosc);
        this.typBroni = typBroni;
        System.out.println("NieDomyślny konstruktor klasy Szkielet z 3arg");
    }
}
