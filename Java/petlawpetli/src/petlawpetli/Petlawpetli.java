/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package petlawpetli;

/**
 *
 * @author Piotr
 */
public class Petlawpetli {


        
    
    public static void main(String[] args)
    {
        for(int j = 1; j <= 10; j++)
        {
            if (j==2)
                continue;
            for(int i = 1; i <= 10; i++)
            {
                if(i==2)
                    continue;
                System.out.print(i*j+" ");
            }
            System.out.println("");
            
        }
    }
    
}
