package com.theawesomecoder61;

import javax.swing.*;
import javax.swing.filechooser.FileNameExtensionFilter;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.*;
import java.util.ArrayList;

public class mg {
    private JButton inFolderBtn;
    private JPanel panel;
    private JTextField inFolderTF;
    private JButton outFolderBtn;
    private JTextField outFolderTF;
    private JButton processBtn;
    private JButton gmadBtn;
    private JTextField gmadTF;
    private JList gmasList;
    private JTextArea logTA;

    private static MenuBar menuBar;
    private Menu fileMenu;
    private MenuItem quitMI;
    private Menu helpMenu;
    private MenuItem htuMI;
    private MenuItem abouttMI;

    private String gmadPath = System.getProperty("user.home");
    private String inFolder = System.getProperty("user.home");
    private String outFolder = System.getProperty("user.home");
    private ArrayList<String> gmas = new ArrayList<>();

    public mg() {
        // menu
        menuBar = new MenuBar();
        fileMenu = new Menu("File");
        quitMI = new MenuItem("Quit");
        quitMI.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                System.exit(0);
            }
        });
        fileMenu.add(quitMI);
        menuBar.add(fileMenu);

        helpMenu = new Menu("Help");
        htuMI = new MenuItem("How To Use");
        htuMI.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                JOptionPane.showMessageDialog(null, "1. Click on 'Locate gmad' and find gmad.\ngmad should be in your Garry's Mod bin folder (steamapps/common/GarrysMod/bin).\n2. Click on 'Locate Input Folder' and locate the folder with the gma files you wish to extract.\n3. Click on 'Locate Output Folder' and locate the folder where you want the gma files to extract.\n4. Lastly, click on 'Extract All gma Files' and be patient as massgmad extracts the gma files.", "How To Use", JOptionPane.INFORMATION_MESSAGE);
            }
        });
        helpMenu.add(htuMI);
        abouttMI = new MenuItem("About");
        abouttMI.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                JOptionPane.showMessageDialog(null, "massgmad | version 2.0\ncreated by theawesomecoder61", "About", JOptionPane.INFORMATION_MESSAGE);
            }
        });
        helpMenu.add(abouttMI);
        menuBar.add(helpMenu);

        // buttons
        gmadBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                JFileChooser fc = new JFileChooser();
                fc.setCurrentDirectory(new File(gmadPath));
                fc.setMultiSelectionEnabled(false);
                fc.setDialogTitle("Locate a folder with gmas");
                if (System.getProperty("os.name").startsWith("Windows")) {
                    fc.setDialogTitle("Locate gmad.exe");
                    FileNameExtensionFilter filter = new FileNameExtensionFilter("Executable files", "exe", "exe");
                    fc.setFileFilter(filter);
                } else {
                    fc.setDialogTitle("Locate gmad");
                }
                fc.setFileSelectionMode(JFileChooser.FILES_ONLY);
                int result = fc.showOpenDialog(panel);
                if (result == JFileChooser.APPROVE_OPTION) {
                    File sf = fc.getSelectedFile();
                    if (sf.getAbsolutePath().contains("gmad")) {
                        gmadPath = sf.getAbsolutePath();
                        gmadTF.setText(gmadPath);
                        writeLog("gmad Path: " + gmadPath);
                    }
                }
            }
        });
        inFolderBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                JFileChooser fc = new JFileChooser();
                fc.setCurrentDirectory(new File(inFolder));
                fc.setMultiSelectionEnabled(false);
                fc.setAcceptAllFileFilterUsed(false);
                fc.setDialogTitle("Select the input folder");
                fc.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
                int result = fc.showOpenDialog(panel);
                if (result == JFileChooser.APPROVE_OPTION) {
                    String ap = fc.getSelectedFile().getAbsolutePath();
                    String[] files = new File(ap).list();
                    DefaultListModel dlm = new DefaultListModel();
                    for (String f : files) {
                        if (f.contains(".gma")) {
                            dlm.addElement(f);
                            if (System.getProperty("os.name").startsWith("Windows")) {
                                gmas.add(ap + "\\" + f);
                            } else {
                                gmas.add(ap + "/" + f);
                            }
                        }
                    }
                    gmasList.setModel(dlm);
                    inFolder = ap;
                    inFolderTF.setText(inFolder);
                    writeLog("Input folder: " + inFolder);
                    writeLog("Found " + gmas.toArray().length + " gma files");
                    System.out.println(gmas);
                }
            }
        });
        outFolderBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                JFileChooser fc = new JFileChooser();
                fc.setCurrentDirectory(new File(outFolder)); //System.getProperty("user.home")));
                fc.setMultiSelectionEnabled(false);
                fc.setAcceptAllFileFilterUsed(false);
                fc.setDialogTitle("Select the output folder");
                fc.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
                int result = fc.showOpenDialog(panel);
                if (result == JFileChooser.APPROVE_OPTION) {
                    String ap = fc.getSelectedFile().getAbsolutePath();
                    outFolder = ap;
                    outFolderTF.setText(outFolder);
                    writeLog("Output folder: " + outFolder);
                }
            }
        });
        processBtn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (gmadPath == "") {
                    JOptionPane.showMessageDialog(null, "You have not located gmad.");
                }
                if (inFolder == "") {
                    JOptionPane.showMessageDialog(null, "You have not specified an input folder.");
                }
                if (outFolder == "") {
                    JOptionPane.showMessageDialog(null, "You have not specified an output folder.");
                }
                if (gmadPath != "" && inFolder != "" && outFolder != "") {
                    for (int i = 0; i < gmas.toArray().length; i++) {
                        String gp = gmas.get(i);
                        System.out.println(extractGMA(gp));
                    }
                }
            }
        });
    }

    private String execCmd(String command) {
        StringBuffer output = new StringBuffer();
        Process p;
        try {
            p = Runtime.getRuntime().exec("cmd /c " + command); // Windows
            p.waitFor();
            BufferedReader reader = new BufferedReader(new InputStreamReader(p.getInputStream()));
            String line;
            while ((line = reader.readLine()) != null) {
                output.append(line + "\n");
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return output.toString();
    }

    private void writeLog(String t) {
        logTA.setText(logTA.getText() + "\n" + t);
    }

    private int extractGMA(String gp) {
        File f = new File(gp);
        String gn = f.getName().substring(0, f.getName().lastIndexOf('.'));
        String newOutFolder = outFolder + "\\" + gn;
        String[] command = {"CMD", "/C", "\"" + gmadPath + "\" extract -file \"" + gp + "\" -out " + newOutFolder.replace(" ", "\\ ") + ""};
        ProcessBuilder pb = new ProcessBuilder(command);
        Process process = null;
        try {
            process = pb.start();
        } catch (IOException e1) {
            e1.printStackTrace();
        }
        //Read out dir output
        InputStream is = process.getInputStream();
        InputStreamReader isr = new InputStreamReader(is);
        BufferedReader br = new BufferedReader(isr);
        String line;
//                    System.out.printf("Output of running %s is:\n", Arrays.toString(command));
        try {
            while ((line = br.readLine()) != null) {
                writeLog(line);
            }
        } catch (IOException e1) {
            e1.printStackTrace();
        }
        //Wait to get exit value
        int exitValue = 0;
        try {
            exitValue = process.waitFor();
        } catch (InterruptedException e2) {
            e2.printStackTrace();
        }
        return exitValue;
    }

    public static void main(String[] args) {
        System.setProperty("apple.laf.useScreenMenuBar", "true");
        JFrame jf = new JFrame("massgmad");
        jf.setContentPane(new mg().panel);
        jf.setMenuBar(menuBar);
        jf.setPreferredSize(new Dimension(900, 550));
        jf.setResizable(true);
        jf.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        jf.pack();
        jf.setLocationRelativeTo(null);
        jf.setVisible(true);
    }

    {
// GUI initializer generated by IntelliJ IDEA GUI Designer
// >>> IMPORTANT!! <<<
// DO NOT EDIT OR ADD ANY CODE HERE!
        $$$setupUI$$$();
    }

    /**
     * Method generated by IntelliJ IDEA GUI Designer
     * >>> IMPORTANT!! <<<
     * DO NOT edit this method OR call it in your code!
     *
     * @noinspection ALL
     */
    private void $$$setupUI$$$() {
        panel = new JPanel();
        panel.setLayout(new com.intellij.uiDesigner.core.GridLayoutManager(6, 2, new Insets(0, 0, 0, 0), -1, -1));
        inFolderBtn = new JButton();
        inFolderBtn.setLabel("Locate Input Folder");
        inFolderBtn.setText("Locate Input Folder");
        panel.add(inFolderBtn, new com.intellij.uiDesigner.core.GridConstraints(1, 1, 1, 1, com.intellij.uiDesigner.core.GridConstraints.ANCHOR_CENTER, com.intellij.uiDesigner.core.GridConstraints.FILL_HORIZONTAL, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, null, null, null, 0, false));
        inFolderTF = new JTextField();
        inFolderTF.setEditable(false);
        inFolderTF.setText("locate input folder -->");
        panel.add(inFolderTF, new com.intellij.uiDesigner.core.GridConstraints(1, 0, 1, 1, com.intellij.uiDesigner.core.GridConstraints.ANCHOR_WEST, com.intellij.uiDesigner.core.GridConstraints.FILL_HORIZONTAL, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, null, new Dimension(338, 37), null, 0, false));
        outFolderTF = new JTextField();
        outFolderTF.setEditable(false);
        outFolderTF.setText("locate output folder -->");
        panel.add(outFolderTF, new com.intellij.uiDesigner.core.GridConstraints(2, 0, 1, 1, com.intellij.uiDesigner.core.GridConstraints.ANCHOR_WEST, com.intellij.uiDesigner.core.GridConstraints.FILL_HORIZONTAL, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, null, new Dimension(338, 37), null, 0, false));
        outFolderBtn = new JButton();
        outFolderBtn.setLabel("Locate Output Folder");
        outFolderBtn.setText("Locate Output Folder");
        panel.add(outFolderBtn, new com.intellij.uiDesigner.core.GridConstraints(2, 1, 1, 1, com.intellij.uiDesigner.core.GridConstraints.ANCHOR_CENTER, com.intellij.uiDesigner.core.GridConstraints.FILL_HORIZONTAL, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, null, null, null, 0, false));
        gmadBtn = new JButton();
        gmadBtn.setLabel("Locate gmad");
        gmadBtn.setText("Locate gmad");
        gmadBtn.setVerticalTextPosition(0);
        panel.add(gmadBtn, new com.intellij.uiDesigner.core.GridConstraints(0, 1, 1, 1, com.intellij.uiDesigner.core.GridConstraints.ANCHOR_CENTER, com.intellij.uiDesigner.core.GridConstraints.FILL_HORIZONTAL, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, null, null, null, 0, false));
        gmadTF = new JTextField();
        gmadTF.setEditable(false);
        gmadTF.setText("locate gmad -->");
        panel.add(gmadTF, new com.intellij.uiDesigner.core.GridConstraints(0, 0, 1, 1, com.intellij.uiDesigner.core.GridConstraints.ANCHOR_WEST, com.intellij.uiDesigner.core.GridConstraints.FILL_HORIZONTAL, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, null, new Dimension(338, 37), null, 0, false));
        final JLabel label1 = new JLabel();
        label1.setText("Found gma Files");
        panel.add(label1, new com.intellij.uiDesigner.core.GridConstraints(4, 0, 1, 1, com.intellij.uiDesigner.core.GridConstraints.ANCHOR_WEST, com.intellij.uiDesigner.core.GridConstraints.FILL_NONE, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, null, new Dimension(338, 86), null, 0, false));
        processBtn = new JButton();
        processBtn.setText("Extract All gma Files");
        panel.add(processBtn, new com.intellij.uiDesigner.core.GridConstraints(3, 0, 1, 1, com.intellij.uiDesigner.core.GridConstraints.ANCHOR_CENTER, com.intellij.uiDesigner.core.GridConstraints.FILL_HORIZONTAL, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_FIXED, null, new Dimension(338, 49), null, 0, false));
        final JScrollPane scrollPane1 = new JScrollPane();
        panel.add(scrollPane1, new com.intellij.uiDesigner.core.GridConstraints(5, 0, 1, 1, com.intellij.uiDesigner.core.GridConstraints.ANCHOR_CENTER, com.intellij.uiDesigner.core.GridConstraints.FILL_BOTH, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_CAN_SHRINK | com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_WANT_GROW, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_CAN_SHRINK | com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_WANT_GROW, null, new Dimension(338, 200), null, 0, false));
        logTA = new JTextArea();
        logTA.setEditable(false);
        logTA.setLineWrap(true);
        logTA.setText("massgmad | version 2.0\nThis is an output log.");
        scrollPane1.setViewportView(logTA);
        final JScrollPane scrollPane2 = new JScrollPane();
        panel.add(scrollPane2, new com.intellij.uiDesigner.core.GridConstraints(4, 1, 1, 1, com.intellij.uiDesigner.core.GridConstraints.ANCHOR_CENTER, com.intellij.uiDesigner.core.GridConstraints.FILL_BOTH, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_CAN_SHRINK | com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_WANT_GROW, com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_CAN_SHRINK | com.intellij.uiDesigner.core.GridConstraints.SIZEPOLICY_WANT_GROW, null, null, null, 0, false));
        gmasList = new JList();
        scrollPane2.setViewportView(gmasList);
    }

    /**
     * @noinspection ALL
     */
    public JComponent $$$getRootComponent$$$() {
        return panel;
    }
}
