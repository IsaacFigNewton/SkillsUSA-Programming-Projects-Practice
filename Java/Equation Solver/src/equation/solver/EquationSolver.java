/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package equation.solver;

/**
 * This program evaluates arithmetic expressions
 */
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.util.StringTokenizer;

public class EquationSolver extends JApplet
        implements ActionListener {

    private JTextField question;
    private JTextField answer;
    private static final String ARROW = "==> ";

    public void init() {
        question = new JTextField(40);
        question.setFont(new Font("Monospaced", Font.BOLD, 14));
        question.setBackground(Color.white);
        question.setForeground(Color.blue);
        question.addActionListener(this);
        question.setText("Equation Solver");
        Container c = getContentPane();
        c.setLayout(new FlowLayout());
        c.add(question);

        answer = new JTextField(40);
        answer.setFont(new Font("Monospaced", Font.BOLD, 14));
        answer.setBackground(Color.white);
        answer.setForeground(Color.blue);
        answer.addActionListener(this);
        answer.setText("");
        Container d = getContentPane();
        d.setLayout(new FlowLayout());
        d.add(answer);

// Select the whole display text:
        question.selectAll();

// Prepare for typing:
        question.requestFocus();
    }

    public void actionPerformed(ActionEvent e) {
// Skip if display has any selected text:
        if (question.getSelectedText() != null) {
            return;
        }

        String text = question.getText();
        answer.setText(process(text));
        question.selectAll();
        System.out.println("");
    }

    private String process(String s) {
        String term1, var, op, term2, equals, term3;

        s = s.trim();

        for (int i = 0; i < s.length(); i++) {
            char ch = s.charAt(i);
            if ((ch == '+') || (ch == '-') || (ch == '*') || (ch == '/') || (ch == '%') || (ch == '^')) {
                s = s.substring(0, i) + " " + s.charAt(i) + " " + s.substring(i + 1);
                System.out.println(s);
                break;
            }
        }
        
        for (int i = 0; i < s.length(); i++) {
            char ch = s.charAt(i);
            if (ch == '=') {
                s = s.substring(0, i) + " " + s.charAt(i) + " " + s.substring(i + 1);
                System.out.println(s);
                break;
            }
        }
//        for (int i = 0; i < s.length(); i++) {
//            char ch = s.charAt(i);
//            if (ch == 'x') {
//                s = s.substring(0, i - 1) + " " + s.charAt(i) + " " + s.substring(i + 1);
//                System.out.println(s);
//                break;
//            }
//        }

        StringTokenizer terms = new StringTokenizer(s);

        if (terms.countTokens() == 3) {
            term1 = terms.nextToken();
            op = terms.nextToken();
            term2 = terms.nextToken();
            return evaluate(term1, op, term2);
        } else if (terms.countTokens() == 5) {
            var = terms.nextToken();
            op = terms.nextToken();
            term2 = terms.nextToken();
            equals = terms.nextToken();
            term3 = terms.nextToken();
            return evaluate(var, op, term2, equals, term3);
        } else if (terms.countTokens() == 6) {
            term1 = terms.nextToken();
            var = terms.nextToken();
            op = terms.nextToken();
            term2 = terms.nextToken();
            equals = terms.nextToken();
            term3 = terms.nextToken();
            return evaluate(term1, var, op, term2, equals, term3);
        } else {
            return ARROW + "Syntax error";
        }
    }

    /**
     * Evaluates an arithmetic expression in the form "a +/- b" and returns the
     * result in the form "= c" or an error message.
     */
    private String evaluate(String term1, String op, String term2) {
        String result;

        if (op.length() != 1) {
            return ARROW + "Syntax error";
        }

        char opSign = op.charAt(0);
        int a = Integer.parseInt(term1);
        int b = Integer.parseInt(term2);

        switch (opSign) {
            case '+':
                result = "= " + (a + b);
                break;

            case '-':
                result = "= " + (a - b);
                break;

            case '*':
                result = "= " + (a * b);
                break;

            case '/':
                if (b != 0) {
                    result = "= " + (a / b);
                } else {
                    result = ARROW + "Cannot divide by 0.";
                }
                break;

            case '%':
                if (b != 0) {
                    result = "= " + (a % b);
                } else {
                    result = ARROW + "Cannot divide by 0.";
                }
                break;

            case '^':
                result = "= " + (int) (Math.pow((double) a, (double) b));
                break;

            default:
                result = ARROW + "Invalid operation";
                break;
        }
        return result;
    }

    private String evaluate(String var, String op, String term2, String equals, String term3) {
        String result;

        if (op.length() != 1) {
            return ARROW + "Syntax error";
        }

        char opSign = op.charAt(0);
        int a = Integer.parseInt(term2);
        int b = Integer.parseInt(term3);

        switch (opSign) {
            case '+':
                result = "x = " + (b - a);
                break;

            case '-':
                result = "x = " + (b + a);
                break;

            case '*':
                if (a != 0) {
                    result = "x = " + (b / a);
                } else {
                    result = ARROW + "Cannot divide by 0.";
                }
                break;

            case '/':
                if (b != 0) {
                    result = "x = " + (b * a);
                } else {
                    result = ARROW + "Cannot divide by 0.";
                }
                break;

            default:
                result = ARROW + "Invalid operation";
                break;
        }
        return result;
    }

    private String evaluate(String term1, String var, String op, String term2, String equals, String term3) {
        String result;

        if (op.length() != 1) {
            return ARROW + "Syntax error";
        }

        char opSign = op.charAt(0);
        int a = Integer.parseInt(term2);
        int b = Integer.parseInt(term3);
        int c = Integer.parseInt(term1);

        switch (opSign) {
            case '+':
                result = "x = " + ((b - a) / c);
                break;

            case '-':
                result = "x = " + ((b + a) / c);
                break;

            case '*':
                if (a != 0) {
                    result = "x = " + ((b / a) / c);
                } else {
                    result = ARROW + "Cannot divide by 0.";
                }
                break;

            case '/':
                if (b != 0) {
                    result = "x = " + ((b * a) / c);
                } else {
                    result = ARROW + "Cannot divide by 0.";
                }
                break;

            default:
                result = ARROW + "Invalid operation";
                break;
        }
        return result;
    }
}
