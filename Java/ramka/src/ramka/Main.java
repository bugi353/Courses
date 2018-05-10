package ramka;

import javax.swing.*;
import java.awt.*; //avt - abstrac window toolkit


public class Main extends JFrame
{

    public Main() 
    {
        /*
        JFrame frame = new JFrame();
        
        frame.setVisible(true);
        frame.setSize(800, 600);
//        frame.setSize(new Dimension (800, 600));

//        frame.setLocation(100,50);  //x - w prawo rośnie, y - w dół rośnie

        frame.setBounds(100, 50, 800, 600); //ustawia położenie i wymiary
        
        frame.setResizable(true);  //odpowiada za zmiany rozmiaru ramki
        
        frame.setIconImage(Toolkit.getDefaultToolkit().getImage("ikona.jpg"));  //Toolkit - narzędzia do operowania z różnymi rzeczami
        
        frame.setTitle("Nowa ramka");
        frame.setDefaultCloseOperation(3); //wybieramy jedną z 4 opcji, 3 - oznacza exit on close
        */
        
        this.setBounds(100, 50, 800, 600);
        this.setDefaultCloseOperation(3);
        this.setVisible(true);
        this.setIconImage(Toolkit.getDefaultToolkit().getImage("ikona.jpg"));
        this.setTitle("Nowa ramka");
//        this.pack();  // służy do szybszego kalkulowania komponentów
    }
    
    public static void main(String[] args) 
    {
        new Main();
    }
    
}
