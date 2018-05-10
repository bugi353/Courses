package przelaczniki;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


public class Main extends JFrame {

    public Main()
    {
        
        
        initComponents();
        
        
        
        
    }
    
    public void initComponents()
    {
        this.setTitle("Grupy Przełączników Radio");
        this.setBounds(300, 300, 300, 200);
        panel2.add(etykieta);
        
//        JRadioButton malyprzelacznik = new JRadioButton("Mały", false);
//        JRadioButton sredniprzelacznik = new JRadioButton("Średni");
//        
//        malyprzelacznik.addActionListener((ActionEvent ae) -> {
//            etykieta.setFont(new Font("Monospaced", Font.BOLD, 15));
//        });
//        
//        groupSize.add(malyprzelacznik);
//        groupSize.add(sredniprzelacznik);
//        
//        panel.add(malyprzelacznik);
//        panel.add(sredniprzelacznik);

        zbudujPrzelacznikRozmiar("Maly", 15);
        zbudujPrzelacznikRozmiar("Sredni", 25);
        zbudujPrzelacznikRozmiar("Duzyy", 35);
        zbudujPrzelacznikKolor("Czerwony", Color.RED);
        zbudujPrzelacznikKolor("Niebieski", Color.BLUE);
        zbudujPrzelacznikKolor("Zielony", Color.GREEN);
        
        this.getContentPane().add(panel, BorderLayout.NORTH);
        this.getContentPane().add(panel2, BorderLayout.SOUTH);
        this.getContentPane().add(panel3, BorderLayout.CENTER);
        
        
        this.setDefaultCloseOperation(3);
    }
    
    public void zbudujPrzelacznikRozmiar (String nazwa,final int rozmiar)
    {
        JRadioButton przelacznik = new JRadioButton(nazwa);
        
        
        przelacznik.addActionListener((ActionEvent ae) -> {
            etykieta.setFont(new Font("Monospaced", Font.PLAIN, rozmiar));
        });
        groupSize.add(przelacznik);
        panel.add(przelacznik);
    }
    
    public void zbudujPrzelacznikKolor (String nazwa,final Color k)
    {
        JRadioButton przelacznik = new JRadioButton(nazwa);
        
        przelacznik.addActionListener((ActionEvent ae) -> {
            etykieta.setForeground(k);
        });
        groupColor.add(przelacznik);
        panel3.add(przelacznik);
    }
    
    JPanel panel = new JPanel();
    JPanel panel2 = new JPanel();
    JPanel panel3 = new JPanel();
    JLabel etykieta = new JLabel("coś");
    ButtonGroup groupSize = new ButtonGroup();
    ButtonGroup groupColor = new ButtonGroup();
    
    
 
    public static void main(String[] args) 
    {
        new Main().setVisible(true);
        
    }
    
}





