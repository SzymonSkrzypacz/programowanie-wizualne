package java_awt;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Mouse_Event extends Frame implements MouseListener {
    Label label;
    Button button;
    Button button1;
    Checkbox checkboxMouseClicked;
    Checkbox checkboxMouseEntered;
    Checkbox checkboxMouseExited;
    Checkbox checkboxMousePressed;
    Checkbox checkboxMouseReleased;


    boolean if_paint=false;
    boolean if_clean=false;
    Mouse_Event(){
        addMouseListener(this);
        label=new Label();
        button = new Button("Pojawiam się!");
        button1 = new Button ("Znikam!");
        checkboxMouseClicked = new Checkbox("Mouse clicked");
        checkboxMouseEntered = new Checkbox("Mouse entered");
        checkboxMouseExited = new Checkbox("Mouse exited");
        checkboxMousePressed = new Checkbox("Mouse pressed");
        checkboxMouseReleased = new Checkbox("Mouse released");

        label.setBounds(20,50,100,20);
        button.setBounds(70,80,100,20);
        button1.setBounds(170,80,100,20);
        checkboxMouseClicked.setBounds(20,170,100,20);
        checkboxMouseEntered.setBounds(20,190,100,20);
        checkboxMouseExited.setBounds(20,210,115,20);
        checkboxMousePressed.setBounds(20,230,125,20);
        checkboxMouseReleased.setBounds(20,250,110,20);


        button.addActionListener(new AbstractAction() {
            public void actionPerformed(ActionEvent e){

                if_paint=true;

                repaint();

            }
        });

        button1.addActionListener(new AbstractAction() {
            public void actionPerformed(ActionEvent e){

                if_clean=true;
                repaint();

            }
        });

        add(label);
        add(button);
        add(button1);
        add(checkboxMouseClicked);
        add(checkboxMouseEntered);
        add(checkboxMouseExited);
        add(checkboxMousePressed);
        add(checkboxMouseReleased);

        addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                dispose();
            }
        });

        setSize(350,350);
        setLayout(null);
        setVisible(true);


    }
    public void mouseClicked(MouseEvent e) {
        label.setText("Mouse Clicked");
        checkboxMouseClicked.setState(true);
    }
    public void mouseEntered(MouseEvent e) {
        label.setText("Mouse Entered");
        checkboxMouseEntered.setState(true);
    }
    public void mouseExited(MouseEvent e) {
        label.setText("Mouse Exited");
        checkboxMouseExited.setState(true);
    }
    public void mousePressed(MouseEvent e) {
        label.setText("Mouse Pressed");
        checkboxMousePressed.setState(true);
    }
    public void mouseReleased(MouseEvent e) {
        label.setText("Mouse Released");
        checkboxMouseReleased.setState(true);
    }

    public void paint(Graphics g) {

        if (if_paint)
        {
            g.setColor( new Color(14, 44, 120));
            g.fillOval( 130, 110, 70, 50 );
        }
        if (if_clean)
        {
            {
                g.setColor( new Color( 255, 255, 255));
                g.fillOval( 130, 110, 70, 50 );
            }
        }

        if_paint=false;
        if_clean=false;

    }

}
