package centrowanieramki;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ComponentListener;

public class Main extends JFrame
{

    public Main()
    {
        int szer = Toolkit.getDefaultToolkit().getScreenSize().width;
        int wys = Toolkit.getDefaultToolkit().getScreenSize().height;
        
        this.setDefaultCloseOperation(3);
        
        this.setSize(szer/2, wys/2);
//        this.setLocation(szer/4, wys/4);
        
        int szerRamki = this.getSize().width;
        int wysRamki = this.getSize().height;
        
        this.setLocation((szer-szerRamki)/2, (wys-wysRamki)/2);
        
        initComponents();
//        this.pack();
        
        
    }
    
    public void initComponents()
    {
        gora = new JButton("Góra!");
        dol = new JButton("Dół!");
        lewo = new JButton("Lewo!");
        prawo = new JButton("Prawo!");
        centrum = new JButton("Centrum!");
        
        
        Container kontener = this.getContentPane();
        
//        kontener.add(gora, BorderLayout.PAGE_START);
//        kontener.add(dol, BorderLayout.PAGE_END);
//        kontener.add(lewo, BorderLayout.LINE_START);
//        kontener.add(prawo, BorderLayout.LINE_END);
//        kontener.add(centrum, BorderLayout.CENTER);

//        kontener.setBackground(Color.red);

          centrum.setBounds(0, 0, 100, 40);
          gora.setBounds(100, 0, 100, 40);
          dol.setBounds(200, 0, 100, 40);
          prawo.setBounds(300, 0, 100, 40);
          lewo.setBounds(400, 0, 100, 40);
          kontener.setLayout(null);
          kontener.add(centrum);
          kontener.add(gora);
          kontener.add(dol);
          kontener.add(prawo);
          kontener.add(lewo);
    }
    
    JButton gora;
    JButton dol;
    JButton lewo;
    JButton prawo;
    JButton centrum;
    
    
    
    
    
    public static void main(String[] args)
    {
        new Main().setVisible(true);
        
    }
    
}



