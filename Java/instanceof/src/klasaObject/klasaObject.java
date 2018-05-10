/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package klasaObject;

/**
 *
 * @author Piotr
 */
public class klasaObject {
    public static void main(String[] args) 
    {
        Object a = new Punkt(4, 10);
        Object b = new Punkt(4, 10);
        if(a.equals(b))
            System.out.println("Racja milordzie");
        
        Object[] punkty = new Punkt[4];
        punkty[0] = new Punkt(2,4);
        punkty[1] = new Punkt(4,4);
        punkty[2] = new Punkt(8,4);
        punkty[3] = new Punkt(2,24);
        
        for(Object pkt :punkty)
        {
            System.out.println(pkt);
        }
        
        System.out.println(a);
    }
}

class Punkt 
{
    private int x;
    private int y;
    
    Punkt(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    int getX()
    {
        return x;
    }
    int getY()
    {
        return y;
    }
    @Override
    public boolean equals(Object o)
    {
        if(o == null)               //warunek zabezpieczający ze względu na mogące się pojawić błędy
            return false;      
        if(this == o)
            return true;
        if(this.getClass() != o.getClass())         //sprawdzamy czy nie została przesłana inna klasa
            return false;
        
        Punkt przyslany = (Punkt)o;
        
        return this.x == przyslany.x && this.y == przyslany.y;
            
    }
    
    @Override
    public String toString()        //ta funkcja wrzuca return do tego co wyswietla sie podczas wyswietlania obiektu
    {
        return getX() + " " + getY();
    }
}