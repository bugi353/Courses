/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkginstanceof;

import java.util.Date;

public class Instanceof {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        long start, stop;
        
        start = System.currentTimeMillis();
        
        Osoba [] osoba = new Osoba[4];
        osoba[0] = new Pracownik("Arkadiusz", "Włodarczyk", 1000000);
        osoba[1] = new Student("Alus", "Matikus");
        
        for (int i =0; i<osoba.length; i++)
        {
            if (osoba[i] instanceof Pracownik)
            ((Pracownik)osoba[i]).pobierzOpis();
            else
                break;
        }
        
        stop = System.currentTimeMillis();
        System.out.println(stop-start);
        
    }
    
}

abstract class Osoba
{
    String imie;
    String nazwisko;
    
    Osoba (String imie, String nazwisko)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
    }
    
    abstract void pobierzOpis();
}

class Pracownik extends Osoba
{
    double wynagrodzenie;
    
    Pracownik(String imie, String nazwisko, double wynagrodzenie)
    {
        super(imie, nazwisko);
        this.wynagrodzenie = wynagrodzenie;
    }
    
    void pobierzOpis()
    {
        System.out.println("Jestem pracownikiem");
        System.out.println("Moje imie to: " + imie);
        System.out.println("Moje nazwisko to: " + nazwisko);
        System.out.println("Zarabiam: "+ wynagrodzenie);
    }
}
class Student extends Osoba
{
    Student(String imie, String nazwisko)
    {
        super(imie, nazwisko);
    }
    void pobierzOpis()
    {
        System.out.println("Jestem studentem");
        System.out.println("Moje imie to: " + imie);
        System.out.println("Moje nazwisko to: " + nazwisko);
    }
}