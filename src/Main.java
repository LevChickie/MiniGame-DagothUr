import javax.imageio.ImageIO;
import javax.swing.*;
import javax.swing.border.Border;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

public class Main {

    public static void main(String[] args)
    {
        JFrame frame = new JFrame();
        Toolkit t = Toolkit.getDefaultToolkit();
        JButton changePosition;
        BufferedImage background;
        Image character;
        System.out.println("Fut");
        JLabel label,picture, picture2, picture3,picture4,picture5, picture6;
        label = new JLabel("Dagoth-Ur");
        picture = new JLabel();
        picture2 = new JLabel();
        picture3 = new JLabel();
        picture4 = new JLabel();
        picture5 = new JLabel();
        picture6 = new JLabel();

        label.setBounds(600,600,10,10);
        changePosition = new JButton("Change");
        changePosition.setBounds(500,300,30,30);
        character = t.getImage("src\\DagothDie.png");

        picture.setIcon(new ImageIcon("src\\DagothIdle2.png"));
        picture2.setIcon(new ImageIcon("src\\DagothJump.png"));
        picture3.setIcon(new ImageIcon("src\\DagothAttack.png"));
        picture4.setIcon(new ImageIcon("src\\DagothStep2.png"));
        picture5.setIcon(new ImageIcon("src\\DagothStep1.png"));
        picture6.setIcon(new ImageIcon("src\\DagothDie2.png"));


        frame.add(picture,BorderLayout.WEST);
        frame.add(picture2,BorderLayout.NORTH);
        frame.add(picture3,BorderLayout.CENTER);
        frame.add(picture4,BorderLayout.WEST);
        frame.add(picture5,BorderLayout.CENTER);
        frame.add(picture6,BorderLayout.NORTH);
        frame.add(label, BorderLayout.SOUTH);
        frame.add(changePosition, BorderLayout.EAST);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}

