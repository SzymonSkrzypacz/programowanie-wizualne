package calculator;

import javax.swing.*;
import java.awt.event.ActionEvent;

public class Calculator extends JFrame {

    public Calculator(){

        super("Kalkulator Java Swing");

        setDefaultCloseOperation(EXIT_ON_CLOSE);

        JMenuBar menuBar = new JMenuBar();
        JMenu fileMenu = new JMenu("File");
        JMenuItem newfile = new JMenuItem(new AbstractAction("New") {
            @Override
            public void actionPerformed(ActionEvent e) {
                dispose();
                new Calculator();
            }
        });
        JMenuItem close = new JMenuItem(new AbstractAction("Close") {
            @Override
            public void actionPerformed(ActionEvent e) {
                dispose();
            }
        });


        fileMenu.add(newfile);
        fileMenu.add(close);
        menuBar.add(fileMenu);


        add(new Itemy());

        setSize(370,500);
        setLocation(500,350);
        setResizable(false);
        setJMenuBar(menuBar);
        setVisible(true);
    }
}
