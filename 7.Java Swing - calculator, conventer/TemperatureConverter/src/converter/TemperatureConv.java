package converter;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.*;
import javax.swing.*;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;


public class TemperatureConv extends JFrame implements ActionListener {
    int callCount = 0;
    JTextField celsius = new JTextField();
    JTextField fahren = new JTextField();
    JTextField kelvin = new JTextField();
    ImageIcon icon;
    JButton save = new JButton("Save");
    JButton openbtn = new JButton("Open file");
    File output = new File("output.txt");

    DocumentListener dl = new DocumentListener() {
        public void insertUpdate(DocumentEvent e) {
            Convert(e);
        }

        public void removeUpdate(DocumentEvent e) {
        }

        public void changedUpdate(DocumentEvent e) {
        }
    };

    public TemperatureConv() {

        super("Converter");
        icon = new ImageIcon ("icon.png");
        setIconImage(icon.getImage());
        setSize(300, 300);
        setLayout(new GridLayout(4, 2));
        setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        JLabel l_celsius = new JLabel("Celsius");
        JLabel l_fahren = new JLabel("Fahrenheit");
        JLabel l_kelvin = new JLabel("Kelvin");
        Container cp = getContentPane();

        JMenuBar menubar = new JMenuBar();
        JMenu menufile = new JMenu("File");
        JMenuItem newfile = new JMenuItem(new AbstractAction("New") {
            @Override
            public void actionPerformed(ActionEvent e) {
                dispose();
                new TemperatureConv();
            }
        });

        JMenuItem saveresults = new JMenuItem(new AbstractAction("Save results") {
            @Override
            public void actionPerformed(ActionEvent e) {
                saveFile();
            }
        });

        JMenuItem openresults = new JMenuItem(new AbstractAction("Open saved results") {
            @Override
            public void actionPerformed(ActionEvent e) {
                openFile();
            }
        });

        JMenuItem close = new JMenuItem(new AbstractAction("Close") {
            @Override
            public void actionPerformed(ActionEvent e) {
                dispose();
            }
        });

        JMenu colors = new JMenu("Colors");
        JMenuItem changebackground = new JMenuItem(new AbstractAction("Change color of background"){
            @Override
            public void actionPerformed(ActionEvent e){
                Color c = JColorChooser.showDialog(null, "Choose a color", Color.WHITE);
                cp.setBackground(c);
            }
        });

        JMenuItem changeforeground = new JMenuItem(new AbstractAction("Change color of font"){
            @Override
            public void actionPerformed(ActionEvent e){
                Color c = JColorChooser.showDialog(null, "Choose a color", Color.WHITE);
                l_celsius.setForeground(c);
                l_fahren.setForeground(c);
                l_kelvin.setForeground(c);
                save.setForeground(c);
                openbtn.setForeground(c);
            }
        });

        JMenuItem changebuttons = new JMenuItem(new AbstractAction("Change color of buttons"){
            @Override
            public void actionPerformed(ActionEvent e){
                Color c = JColorChooser.showDialog(null, "Choose a color", Color.WHITE);
                save.setBackground(c);
                openbtn.setBackground(c);
            }
        });

        JMenu about= new JMenu("Help");
        JMenuItem help = new JMenuItem(new AbstractAction("About converter"){
            @Override
            public void actionPerformed(ActionEvent ev) {
                JOptionPane.showMessageDialog(
                        TemperatureConv.this, "This is a simple temperature converter. Just write in field a value and this program will convert the value to Celsius, Fahrenheit, Kelvin. "
                        , "Help",
                        JOptionPane.INFORMATION_MESSAGE);
            }
        });

        JMenuItem aboutapp = new JMenuItem(new AbstractAction("About application"){
            @Override
            public void actionPerformed(ActionEvent ev) {
                JOptionPane.showMessageDialog(
                        TemperatureConv.this, "Authors: Ewelina Lasowy & Szymon Skrzypacz\n Program version: 1.00."
                        , "About application",
                        JOptionPane.INFORMATION_MESSAGE);
            }
        });

        cp.add(l_celsius);
        cp.add(celsius);
        cp.add(l_fahren);
        cp.add(fahren);
        cp.add(l_kelvin);
        cp.add(kelvin);
        cp.add(save);
        cp.add(openbtn);
        menufile.add(newfile);
        menufile.add(saveresults);
        menufile.add(openresults);
        menufile.add(close);
        menubar.add(menufile);
        colors.add(changebackground);
        colors.add(changeforeground);
        colors.add(changebuttons);
        menubar.add(colors);
        about.add(help);
        about.add(aboutapp);
        menubar.add(about);
        setJMenuBar(menubar);
        celsius.getDocument().putProperty("owner", (Object) celsius);
        fahren.getDocument().putProperty("owner", (Object) fahren);
        kelvin.getDocument().putProperty("owner", (Object) kelvin);
        celsius.getDocument().addDocumentListener(dl);
        fahren.getDocument().addDocumentListener(dl);
        kelvin.getDocument().addDocumentListener(dl);
        save.addActionListener(this);
       openbtn.addActionListener(this);
        setVisible(true);
    }

    public void Convert(DocumentEvent de) {
        if (callCount != 0) {
            callCount = (callCount + 1) % 3;
            return;
        }
        callCount = (callCount + 1) % 3;
        JTextField txt = (JTextField) de.getDocument().getProperty("owner");
        try {
            if (!txt.getText().equals("") && txt.getText() != null) {
                float src = Float.parseFloat(txt.getText());
                if (txt.equals(celsius)) {

                    fahren.setText(ConvertFunctions.CtoF(src));
                    kelvin.setText(ConvertFunctions.CtoK(src));

                } else if (txt.equals(fahren)) {

                    celsius.setText(ConvertFunctions.FtoC(src));
                    kelvin.setText(ConvertFunctions.FtoK(src));

                } else if (txt.equals(kelvin)) {

                    celsius.setText(ConvertFunctions.KtoC(src));
                    fahren.setText(ConvertFunctions.KtoF(src));
                }
            }
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, "Bad input!");
        }
    }

    @Override
    public void actionPerformed(ActionEvent e) {


        if (e.getSource()==save)
        {
            saveFile();
        }

        else if(e.getSource()==openbtn)
        {
            openFile();
        }


    }

    public void saveFile()
    {
        FileWriter fw = null;

        try {
            if (!output.exists()) {
                JOptionPane.showMessageDialog(
                        TemperatureConv.this, "File doesn't exist. Making new file... "
                        , "Information",
                        JOptionPane.INFORMATION_MESSAGE);
                output.createNewFile();
            }


            FileWriter fileWriter = new FileWriter(output, true);

            BufferedWriter bw = new BufferedWriter(fileWriter);
            bw.write("Celsius: ");
            bw.write(celsius.getText());
            bw.newLine();
            bw.write("Fahrenheit: ");
            bw.write(fahren.getText());
            bw.newLine();
            bw.write("Kelvin: ");
            bw.write(kelvin.getText());
            bw.newLine();
            bw.newLine();
            bw.close();

            JOptionPane.showMessageDialog(
                    TemperatureConv.this, "Saved to the file."
                    , "Success",
                    JOptionPane.INFORMATION_MESSAGE);
        } catch(IOException e1) {
            JOptionPane.showMessageDialog(
                    TemperatureConv.this, "Some error occured."
                    , "Error",
                    JOptionPane.INFORMATION_MESSAGE);
        }


    }

    public void openFile()
    {

        if (!output.exists()) {
            JOptionPane.showMessageDialog(
                    TemperatureConv.this, "File doesn't exist. "
                    , "Information",
                    JOptionPane.INFORMATION_MESSAGE);
        }
        else if (Desktop.isDesktopSupported()) {
            try {
                Desktop.getDesktop().open(output);
            } catch (IOException ex) {

                JOptionPane.showMessageDialog(
                        TemperatureConv.this, "Some error occured."
                        , "Error",
                        JOptionPane.INFORMATION_MESSAGE);
            }
        }
    }
}