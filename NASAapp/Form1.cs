using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASAapp
{
    public partial class Form1 : Form
    {
        List<Image> img;
        public Objects objects = new Objects();
        public List<RootObject> RootObjects;
        public List<RootObject> added;
        public Functions functions;

        public Form1()
        {
            InitializeComponent();
            RootObjects = new List<RootObject>();
            added = new List<RootObject>();
            functions = new Functions();
            img = new List<Image>();
            objects = functions.ParseJSON("all");
            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e) {

            panelAbout.Visible = true;
            panelAddNewLocation.Visible = false;
            panelAddNewLandslide.Visible = false;
            panelNearby.Visible = false;

            listBox2.Items.Clear();
            listBox4.Items.Clear();
            
            btnAbout.BackColor=System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("133, 191, 68");
            buttonNearby.BackColor = System.Drawing.ColorTranslator.FromHtml("133, 191, 68");
            btnAddNewLandslide.BackColor = System.Drawing.ColorTranslator.FromHtml("133, 191, 68");

        }

        private void buttonCurrentLocation_Click(object sender, EventArgs e)
        {
            panelAddNewLocation.Visible = false;
            panelAbout.Visible = false;
            panelAddNewLandslide.Visible = false;
            panelNearby.Visible = false;

            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("133, 191, 68");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
            buttonNearby.BackColor = System.Drawing.ColorTranslator.FromHtml("133, 191, 68");
            btnAddNewLandslide.BackColor = System.Drawing.ColorTranslator.FromHtml("133, 191, 68");
        }

        private void btnAddNewLandslide_Click(object sender, EventArgs e)
        {
            panelAddNewLandslide.Visible = true;
            panelAbout.Visible = false;
            panelAddNewLocation.Visible = false;
            panelNearby.Visible = false;

            listBox2.Items.Clear();

            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("133, 191, 68");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("133, 191, 68");
            buttonNearby.BackColor = System.Drawing.ColorTranslator.FromHtml("133, 191, 68");
            btnAddNewLandslide.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
        }

        private void buttonAddNewLocation_Click(object sender, EventArgs e)
        {
            panelAddNewLocation.Visible = true;
            panelAbout.Visible = false;
            panelNearby.Visible = false;
            panelAddNewLandslide.Visible = false;
            
            listBox4.Items.Clear();

            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
            buttonNearby.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            btnAddNewLandslide.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");

            
        }

        private void buttonNearby_Click(object sender, EventArgs e)
        {
            panelNearby.Visible = true;
            panelAbout.Visible = false;
            panelAddNewLocation.Visible = false;
            panelAddNewLandslide.Visible = false;

            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            buttonNearby.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
            btnAddNewLandslide.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            
            listBox4.Items.Clear();

            //List<RootObject> p = functions.nearby(RootObjects, 250, 
            //    functions.GetLocation(functions.MyIP()).Split(' ')[0], 
            //    functions.GetLocation(functions.MyIP()).Split(' ')[1]);
            Objects p = functions.ParseJSON("Macedonia");

            foreach (RootObject ro in p.obj) {
                listBox4.Items.Add(ro.ToString());
            }
        }

        private void btnShowLandslidesDetails_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Equals("") && textBox6.Text.Equals("") && textBox7.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Please enter location or latitude and longitude!", "Unsufficient data", MessageBoxButtons.OK);
                //message box
            }
            string latitude;
            string longitude;
            string location = textBox1.Text;
            
            latitude = textBox6.Text;
            longitude = textBox7.Text;
            List<RootObject> RootObjects = functions.nearby(this.RootObjects, 250, latitude, longitude);
            
            added.Add(new RootObject(location, latitude, longitude));
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            pictureBox1.Image = null;
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            checkBox2.Checked = false;

            panelAbout.Visible = true;
            panelAddNewLocation.Visible = false;
            panelAddNewLandslide.Visible = false;
            panelNearby.Visible = false;

            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            buttonNearby.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            btnAddNewLandslide.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelAbout.Visible = true;
            panelAddNewLocation.Visible = false;
            panelAddNewLandslide.Visible = false;
            panelNearby.Visible = false;

            btnAbout.BackColor = System.Drawing.ColorTranslator.FromHtml("#a2ce6c");
            buttonAddNewLocation.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            buttonNearby.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
            btnAddNewLandslide.BackColor = System.Drawing.ColorTranslator.FromHtml("#85bf44");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string place = textBox2.Text.Trim();
            List<RootObject> list = new List<RootObject>();
            List<RootObject> RootObjects = functions.ParseJSON("all").obj;

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                //Message box
                System.Windows.Forms.MessageBox.Show("Please enter location or latitude and longitude!", "Unsufficient data", MessageBoxButtons.OK);
                return;
            }
            else if (textBox2.Text != "" && textBox2.Text != null)
            {
                list = functions.ParseJSON(textBox2.Text).obj;
            }

            foreach (RootObject ro in list)
            {
                listBox2.Items.Add(ro.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG(*.JPG)|*.jpg|PNG(*.png)|*.jpg|JPEG(*.JPEG)|*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK) {
                Image i = Image.FromFile(dialog.FileName);
                img.Add(i);
                pictureBox1.Image = i;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }
    }
}
