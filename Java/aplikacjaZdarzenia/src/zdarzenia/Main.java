package zdarzenia;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Main extends JFrame
{
    public Main()
    {
        super("Zdarzenia");
        this.setBounds(300, 300, 300, 200);
        
        initComponents();
        
        
        this.setDefaultCloseOperation(3);
    }
    
    public void initComponents()
    {
        kolorCzerwony = new JButton("czerwony");
        kolorNiebieski = new JButton("niebieski");
        kolorZolty = new JButton("żółty");
        
        kolorCzerwony.addActionListener(new sluchaczKolorow(Color.RED));
        kolorNiebieski.addActionListener(new sluchaczKolorow(Color.BLUE));
        kolorZolty.addActionListener(new sluchaczKolorow(Color.YELLOW));
        
        panel.add(kolorCzerwony);
        panel.add(kolorNiebieski);
        panel.add(kolorZolty);
        
        budujButton("zielony", Color.GREEN);
        budujButton("fioletowy", Color.MAGENTA);
        
        this.getContentPane().add(panel);
        
        
       
    }
    
    public void budujButton(String nazwa, Color k)      
    {
        JButton przycisk = new JButton(nazwa);
        przycisk.addActionListener(new ActionListener()     //użyta została anonimowa klasa
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                panel.setBackground(k);
            }
        });
        
        panel.add(przycisk);
    }
    
    private class sluchaczKolorow implements ActionListener
    {
        public sluchaczKolorow (Color k)
        {
            this.kolor = k;
        }
        
        @Override
        public void actionPerformed(ActionEvent ae) 
        {
            panel.setBackground(kolor);
        }
        
        Color kolor;
    }
    
    
    JPanel panel = new JPanel();
    JButton kolorCzerwony;
    JButton kolorNiebieski;
    JButton kolorZolty;
    
    public static void main (String[] args)
    {
        new Main().setVisible(true);
    }
}

