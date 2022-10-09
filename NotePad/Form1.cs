using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa creado por Miranda Nava, block de notas para el guardado de texto ", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir archivo
            Stream stm;
            OpenFileDialog ofd= new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((stm = ofd.OpenFile())!=null){
                    string str = ofd.FileName;
                    string ftxt = File.ReadAllText(str);
                    richTextBox1.Text = ftxt;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guardar archivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de texto(*.txt)|*.txt|Archivo de C#(*.cs)|*.cs";
            sfd.ShowDialog();
            File.WriteAllText(sfd.FileName,richTextBox1.Text);
            MessageBox.Show("Archivo de texto guardado exitosamente.");
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            richTextBox1.ForeColor = Color.Red;
            rojoToolStripMenuItem.Checked = true;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            richTextBox1.ForeColor = Color.Green;
            verdeToolStripMenuItem.Checked = true;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            richTextBox1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void naranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            richTextBox1.ForeColor = Color.Orange;
            naranjaToolStripMenuItem.Checked = true;
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            richTextBox1.ForeColor = Color.Aqua;
            aquaToolStripMenuItem.Checked = true;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            richTextBox1.ForeColor = Color.Black;
            negroToolStripMenuItem.Checked = true;  
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            richTextBox1.ForeColor= Color.Yellow;
            amarilloToolStripMenuItem.Checked = true;   
        }

        private void borrarColor()
        {
            rojoToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked= false;
            azulToolStripMenuItem.Checked = false;
            naranjaToolStripMenuItem.Checked = false;
            negroToolStripMenuItem.Checked = false;
            amarilloToolStripMenuItem.Checked = false;
            aquaToolStripMenuItem.Checked = false;
            blancoToolStripMenuItem.Checked = false;
            negroToolStripMenuItem1.Checked = false;
            azulToolStripMenuItem1.Checked = false;
        }

        private void negroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            borrarColor();
            richTextBox1.BackColor = Color.Black;
            negroToolStripMenuItem1.Checked = true;
        }

        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            borrarColor();
            richTextBox1.BackColor = Color.Blue;
            azulToolStripMenuItem1.Checked = true;
        }

        private void blancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarColor();
            richTextBox1.BackColor = Color.White;
            blancoToolStripMenuItem.Checked = true;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 2;
        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
