/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package klasyanonimowe;

/**
 *
 * @author Piotr
 */
public class KlasyAnonimowe {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args)
    {
//        ZachowaniePoWcisnieciu z = new ZachowaniePoWcisnieciu() 
//        {
//            @Override
//            public void akcja() 
//            {
//                System.out.println("jestem z klasy anonimowej");
//            }
//        };
        
        Przycisk p = new Przycisk();
        
        p.dodajAkcje(new ZachowaniePoWcisnieciu() {
            @Override
            public void akcja() {
                System.out.println("jestem z klasy anonimowej");
            }
        });
    }
    
}

interface ZachowaniePoWcisnieciu
{
    void akcja();
}

class Przycisk
{

    void dodajAkcje(ZachowaniePoWcisnieciu z)
    {
        z.akcja();
    }
    
}