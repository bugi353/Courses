/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package butelka;

/**
 *
 * @author Piotr
 */
public class Butelka {
    private double ileLitrow;
    
    Butelka(double ileLitrow)
    {
        this.ileLitrow = ileLitrow;
    }
    
    double getIleLitrow()
    {
        return ileLitrow;
    }
    void wlej (double ilosc)
    {
        this.ileLitrow += ilosc;
    }
    void wylej (double ilosc)
    {
        if(ilosc<ileLitrow)
            this.ileLitrow -= ilosc;
        else
            this.ileLitrow -= this.ileLitrow;
    }
    void przelej (double ilosc, Butelka gdziePrzelac)
    {
        
        if (ilosc > this.ileLitrow)
        {
            ilosc = this.ileLitrow;
            this.wylej(ilosc);
            gdziePrzelac.wlej(ilosc);
        }
        else
        {
            this.wylej(ilosc);
            gdziePrzelac.wlej(ilosc);
        }
    }
            
            
            
    public static void main(String[] args) {
        
       Butelka [] butelka = new Butelka[50];
       
       for (int i = 0; i<= 49; i++)
       {
           butelka[i] = new Butelka(0.1*i);
           System.out.println(butelka[i].getIleLitrow());
       }
       
       butelka[3].przelej(2, butelka[10]);
       System.out.println(butelka[3].getIleLitrow());
       System.out.println(butelka[10].getIleLitrow());
    }
    
}
