/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package french.flag;
import javax.swing.*;
import java.awt.*;
/**
 *
 * @author IsaacMRudnick
 */
public class FrenchFlag {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        JFrame GUI = new JFrame();
        Color aColor = new Color(200, 128, 255);
        
        JPanel Lpanel = new JPanel();
        JPanel Cpanel = new JPanel();
        JPanel Rpanel = new JPanel();
        Lpanel.setBackground(Color.blue);
        Cpanel.setBackground(Color.white);
        Rpanel.setBackground(Color.red);
        Container pane = GUI.getContentPane();
        pane.setLayout(new GridLayout(1, 3));
        pane.add(Lpanel);
        pane.add(Cpanel);
        pane.add(Rpanel);
        
        GUI.setTitle("French Flag");
        GUI.setSize(400,400);
        GUI.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        GUI.setVisible(true);
    }
}