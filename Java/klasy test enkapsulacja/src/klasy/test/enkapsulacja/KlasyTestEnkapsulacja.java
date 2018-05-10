/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package klasy.test.enkapsulacja;

import klasy.test.enkapsulacja.newpackage.NewClass;
        
 class KlasyTestEnkapsulacja {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Publiczna.sprawdzam = 0;
        
        Publiczna.wys();
        
        Publiczna przedmiot = new Publiczna();
        
        NewClass.ulala();
        
        System.out.println(przedmiot.test);
        
        Prywatyzacja pryw = new Prywatyzacja();
    }
    
}

class Prywatyzacja
{
   private int saldo;
   int ile;
}