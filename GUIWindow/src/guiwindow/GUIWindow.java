/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package guiwindow;
import javax.swing.*;
import java.awt.*;
/**
 *
 * @author IsaacMRudnick
 */
public class GUIWindow {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        JFrame GUI = new JFrame();
//        Color aColor = new Color(200, 128, 255);
//        Color myColor = new Color(200, 128, 255);
        GUI.setTitle("My First GUI");
        GUI.setSize(1000,1000);
        GUI.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        Color sky = new Color(155, 195, 240);
        ColorPanel panel = new ColorPanel(sky);
        Container pane = GUI.getContentPane();
        pane.add(panel);
        
        GUI.setVisible(true);
    }
    
}
//        JPanel panel1 = new JPanel();
//        panel1.setBackground(aColor);
//        Container pane = GUI.getContentPane();
//        pane.add(panel1);

//        JPanel Npanel = new JPanel();
//        JPanel Epanel = new JPanel();
//        JPanel Spanel = new JPanel();
//        JPanel Wpanel = new JPanel();
//        JPanel Cpanel = new JPanel();
//        Npanel.setBackground(Color.red);
//        Epanel.setBackground(Color.yellow);
//        Spanel.setBackground(Color.green);
//        Wpanel.setBackground(Color.blue);
//        Cpanel.setBackground(aColor);
//        Container pane = GUI.getContentPane();
//        pane.add(Npanel, BorderLayout.NORTH);
//        pane.add(Epanel, BorderLayout.EAST);
//        pane.add(Spanel, BorderLayout.SOUTH);
//        pane.add(Wpanel, BorderLayout.WEST);
//        pane.add(Cpanel, BorderLayout.CENTER);

//        JPanel Epanel = new JPanel();
//        JPanel Spanel = new JPanel();
//        JPanel Wpanel = new JPanel();
//        JPanel Cpanel = new JPanel();
//        Npanel.setBackground(Color.red);
//        Epanel.setBackground(Color.yellow);
//        Spanel.setBackground(Color.green);
//        Wpanel.setBackground(Color.blue);
//        Cpanel.setBackground(aColor);
//        Container pane = GUI.getContentPane();
//        pane.setLayout(new GridLayout(2, 2));
//        pane.add(Npanel);
//        pane.add(Epanel);
//        pane.add(Spanel);
//        pane.add(Wpanel);