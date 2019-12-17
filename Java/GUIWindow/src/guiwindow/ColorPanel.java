/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package guiwindow;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
/**
 *
 * @author IsaacMRudnick
 */
public class ColorPanel extends JPanel{
    int x, y;
    public ColorPanel(Color backColor) {
        setBackground(backColor);
        x = 200;
        y = 200;
        addMouseListener(new PanelListener());
    }
    public void paintComponent(Graphics g) {
        //while (true) {
            super.paintComponent(g);
            int scale = 1;
            int roofHeight = 20;
            Color grass = new Color(135, 225, 70);
            Color house = new Color(190, 120, 225);
            Color brown = new Color(200, 150, 75);
            Color windows = new Color(200, 130, 235);
            
            
            g.setColor(grass);
            g.fillRect(0, getHeight()/2, getWidth(), getHeight()/2);
            
            g.setColor(Color.white);
            g.fillOval(10, 70, 250, 100);
            g.fillOval(50, 20, 150, 150);
            g.fillOval(350, 120, 150, 50);
            g.fillOval(390, 100, 75, 50);
            g.fillOval(700, 50, 250, 100);
            g.fillOval(740, 20, 150, 150);
            g.fillOval(900, 220, 150, 50);
            g.fillOval(940, 200, 75, 50);
            
            g.setColor(house);
            g.drawLine(x-40*scale, y+(roofHeight-5)*scale, x+80*scale, y+(roofHeight-150)*scale);
            g.drawLine(x+200*scale, y+(roofHeight-5)*scale, x+80*scale, y+(roofHeight-150)*scale);
            g.drawLine(x-40*scale, y+(roofHeight-5)*scale, x+200*scale, y+(roofHeight-5)*scale);
            
            g.setColor(house);
            g.fillRect(x-5*scale, y-15*scale, 175*scale, 200*scale);
            
            g.setColor(brown);
            g.fillRect(x+60*scale, y+100*scale, 40*scale, 75*scale);
            
            g.setColor(windows);
            g.fillRect(x+15*scale, y+75*scale, 35*scale, 35*scale);
            g.fillRect(x+110*scale, y+75*scale, 35*scale, 35*scale);
            
            
            
            g.setColor(Color.blue);
            Font font = new Font("Courier New", Font.BOLD, 20);
            g.setFont(font);
            g.drawString("Hello World!", x, y);
        //}
        
    }
    
    private class PanelListener extends MouseAdapter {
        public void mousePressed(MouseEvent e) {
            
            x = e.getX()-60;
            y = e.getY()-50;
            
            repaint();
        }
    }
}
