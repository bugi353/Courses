/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package użyciefinal;

import java.util.Date;

/**
 *
 * @author Piotr
 */
public class UżycieFinal {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args)
    {
        
        final double PI;
        
        PI = 3.14;
        
        Pracownik p = new Pracownik();
        
        System.out.println(p.dataZatrudnienia);
    }
    
}

abstract class Osoba
{
    
}

class Pracownik extends Osoba
{
    Pracownik()
    {
        this.dataZatrudnienia = new Date();
    }
    Pracownik(Date data)
    {
        this.dataZatrudnienia = data;
    }
    final Date dataZatrudnienia;
}