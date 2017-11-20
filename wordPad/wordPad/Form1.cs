using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordPad
{
    public partial class Form1 : Form
    {
        Boolean fileChanged;
        string currentFile = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox.Height = this.Height - 80;
            richTextBox.Width = this.Width - 30;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            fileChanged = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fileChanged)
            {
                richTextBox.Text = "";
            }
            else
            {
                DialogResult userAnswer = MessageBox.Show("Do you want to save your work?", "Save File?", MessageBoxButtons.YesNoCancel);

                if(userAnswer == DialogResult.No)
                {
                    richTextBox.Text = "";
                    fileChanged = false;
                }else if(userAnswer == DialogResult.Yes)
                {
                    saveFileDialog.ShowDialog();

                    if (saveFileDialog.FileName != "")
                    {
                        saveFileDialog.OverwritePrompt = true;
                        richTextBox.SaveFile(saveFileDialog.FileName);
                        fileChanged = false;
                        richTextBox.Text = "";
                    }
                    else
                    {
                        return;
                    }
                }else if(userAnswer == DialogResult.Cancel)
                {
                    return;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fileChanged)
            {
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    richTextBox.LoadFile(openFileDialog.FileName);
                    currentFile += openFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }
            else
            {
                {
                    DialogResult userAnswer = MessageBox.Show("Do you want to save your work?", "Save File?", MessageBoxButtons.YesNoCancel);

                    if (userAnswer == DialogResult.No)
                    {
                        openFileDialog.ShowDialog();

                        if (openFileDialog.FileName != "")
                        {
                            richTextBox.LoadFile(openFileDialog.FileName);
                            currentFile += openFileDialog.FileName;
                            fileChanged = false;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (userAnswer == DialogResult.Yes)
                    {
                        saveFileDialog.ShowDialog();

                        if (saveFileDialog.FileName != "")
                        {
                            saveFileDialog.OverwritePrompt = true;
                            richTextBox.SaveFile(saveFileDialog.FileName);
                            fileChanged = false;

                            openFileDialog.ShowDialog();

                            if (openFileDialog.FileName != "")
                            {
                                richTextBox.LoadFile(openFileDialog.FileName);
                                currentFile += openFileDialog.FileName;
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (userAnswer == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != "")
            {
                saveFileDialog.OverwritePrompt = true;
                richTextBox.SaveFile(saveFileDialog.FileName);
                fileChanged = false;
            }
            else
            {
                return;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileChanged)
            {
                DialogResult userAnswer = MessageBox.Show("Do you want to save your work?", "Save File?", MessageBoxButtons.YesNoCancel);

                if (userAnswer == DialogResult.No)
                {
                    Application.Exit();
                }
                else if (userAnswer == DialogResult.Yes)
                {
                    saveFileDialog.ShowDialog();

                    if (saveFileDialog.FileName != "")
                    {
                        saveFileDialog.OverwritePrompt = true;
                        richTextBox.SaveFile(saveFileDialog.FileName);
                        Application.Exit();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (userAnswer == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(currentFile == "")
            {
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    richTextBox.SaveFile(saveFileDialog.FileName);
                    fileChanged = false;
                }
                else
                {
                    return;
                }
            }
            else
            {
                richTextBox.SaveFile(currentFile);
                fileChanged = false;
            }
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            fontDialog.Font = richTextBox.Font;
            fontDialog.ShowDialog();
            richTextBox.SelectionFont = fontDialog.Font;
            richTextBox.SelectionColor = fontDialog.Color;
        }
    }
}
