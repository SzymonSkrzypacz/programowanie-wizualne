package calculator;

import org.mariuszgromada.math.mxparser.Expression;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;


public class Itemy extends JPanel implements ActionListener {




    private JButton buttonZero;
    private JButton buttonOne;
    private JButton buttonTwo;
    private JButton buttonThree;
    private JButton buttonFour;
    private JButton buttonFive;
    private JButton buttonSix;
    private JButton buttonSeven;
    private JButton buttonEight;
    private JButton butttonNine;
    private JButton buttonAdd;
    private JButton buttonSubstract;
    private JButton buttonMultiply;
    private JButton buttonDivision;
    private JButton buttonDot;
    private JButton buttonOpenBracket;
    private JButton buttonCloseBracket;
    private JButton buttonEqual;
    private JButton buttonC;
    private JButton buttonCall;
    private JTextField textField;



    public Itemy()
    {


        JPanel panel1 = new JPanel();
        panel1.setPreferredSize(new Dimension(350,350));

        buttonZero = new JButton("0");
        buttonOne = new JButton("1");
        buttonTwo = new JButton("2");
        buttonThree = new JButton("3");
        buttonFour = new JButton("4");
        buttonFive = new JButton("5");
        buttonSix = new JButton("6");
        buttonSeven = new JButton("7");
        buttonEight = new JButton("8");
        butttonNine = new JButton("9");
        buttonAdd = new JButton("+");
        buttonSubstract = new JButton("-");
        buttonMultiply = new JButton("*");
        buttonDivision = new JButton("/");
        buttonDot = new JButton(".");
        buttonOpenBracket = new JButton("(");
        buttonCloseBracket = new JButton(")");
        buttonEqual = new JButton("=");
        buttonC = new JButton("Delete");
        textField = new JTextField();
        textField.setPreferredSize(new Dimension(350,70));



        buttonZero.addActionListener(this);
        buttonOne.addActionListener(this);
        buttonTwo.addActionListener(this);
        buttonThree.addActionListener(this);
        buttonFour.addActionListener(this);
        buttonFive.addActionListener(this);
        buttonSix.addActionListener(this);
        buttonSeven.addActionListener(this);
        buttonEight.addActionListener(this);
        butttonNine.addActionListener(this);
        buttonAdd.addActionListener(this);
        buttonSubstract.addActionListener(this);
        buttonEqual.addActionListener(this);
        buttonMultiply.addActionListener(this);
        buttonDivision.addActionListener(this);
        buttonDot.addActionListener(this);
        buttonOpenBracket.addActionListener(this);
        buttonCloseBracket.addActionListener(this);
        buttonC.addActionListener(this);


        add(textField);

        panel1.setLayout(new GridLayout(5,4,5,5));
        panel1.add(buttonC);
        panel1.add(buttonOpenBracket);
        panel1.add(buttonCloseBracket);
        panel1.add(buttonMultiply);
        panel1.add(buttonOne);
        panel1.add(buttonTwo);
        panel1.add(buttonThree);
        panel1.add(buttonDivision);
        panel1.add(buttonFour);
        panel1.add(buttonFive);
        panel1.add(buttonSix);
        panel1.add(buttonAdd);
        panel1.add(buttonSeven);
        panel1.add(buttonEight);
        panel1.add(butttonNine);
        panel1.add(buttonSubstract);
        panel1.add(buttonZero);
        panel1.add(buttonDot);
        panel1.add(buttonEqual);


        add(panel1);


    }

    @Override
    public void actionPerformed(ActionEvent e) {

        if(e.getSource() == buttonZero) {
            textField.setText(textField.getText().concat("0"));
        } else if(e.getSource() == buttonOne) {
            textField.setText(textField.getText().concat("1"));
        } else if (e.getSource() == buttonTwo) {
            textField.setText(textField.getText().concat("2"));
        } else if (e.getSource() == buttonThree) {
            textField.setText(textField.getText().concat("3"));
        } else if (e.getSource() == buttonFour) {
            textField.setText(textField.getText().concat("4"));
        } else if (e.getSource() == buttonFive) {
            textField.setText(textField.getText().concat("5"));
        } else if (e.getSource() == buttonSix) {
            textField.setText(textField.getText().concat("6"));
        } else if (e.getSource() == buttonSeven) {
            textField.setText(textField.getText().concat("7"));
        } else if (e.getSource() == buttonEight) {
            textField.setText(textField.getText().concat("8"));
        } else if (e.getSource() == butttonNine) {
            textField.setText(textField.getText().concat("9"));
        } else if (e.getSource()==buttonAdd){
            textField.setText(textField.getText().concat("+"));
        } else if (e.getSource()==buttonSubstract){
            textField.setText(textField.getText().concat("-"));
        }else if (e.getSource()==buttonMultiply){
            textField.setText(textField.getText().concat("*"));
        }else if (e.getSource()==buttonDivision){
            textField.setText(textField.getText().concat("/"));
        }else if (e.getSource()==buttonDot){
            textField.setText(textField.getText().concat("."));
        }else if (e.getSource()==buttonOpenBracket){
            textField.setText(textField.getText().concat("("));
        }else if (e.getSource()==buttonCloseBracket){
            textField.setText(textField.getText().concat(")"));
        }else if (e.getSource()==buttonC){
            int numberOfCharsToRemove = 1;
            String current = textField.getText();
            String currentMinus = current.substring(0,current.length()-numberOfCharsToRemove);
            textField.setText(currentMinus);
        } else if(e.getSource()==buttonEqual){
            Expression exp = new Expression(textField.getText());
            String temp2 = Double.toString(exp.calculate());
            textField.setText(temp2);
        }


    }
}
