namespace NASAapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelAbout = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelAddNewLocation = new System.Windows.Forms.Panel();
            this.tbAddNewLocationResult = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelAddNewLandslide = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panelNearby = new System.Windows.Forms.Panel();
            this.textBoxNearbyLandslides = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.buttonNearby = new System.Windows.Forms.Button();
            this.buttonAddNewLocation = new System.Windows.Forms.Button();
            this.btnAddNewLandslide = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelAbout.SuspendLayout();
            this.panelAddNewLocation.SuspendLayout();
            this.panelAddNewLandslide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNearby.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.panelAbout.Controls.Add(this.textBox1);
            this.panelAbout.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAbout.Location = new System.Drawing.Point(240, 12);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(502, 330);
            this.panelAbout.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(36, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 280);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelAddNewLocation
            // 
            this.panelAddNewLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.panelAddNewLocation.Controls.Add(this.tbAddNewLocationResult);
            this.panelAddNewLocation.Controls.Add(this.listBox2);
            this.panelAddNewLocation.Controls.Add(this.textBox8);
            this.panelAddNewLocation.Controls.Add(this.btnOK);
            this.panelAddNewLocation.Controls.Add(this.btnCancel);
            this.panelAddNewLocation.Controls.Add(this.textBox2);
            this.panelAddNewLocation.Location = new System.Drawing.Point(240, 12);
            this.panelAddNewLocation.Name = "panelAddNewLocation";
            this.panelAddNewLocation.Size = new System.Drawing.Size(505, 330);
            this.panelAddNewLocation.TabIndex = 2;
            this.panelAddNewLocation.Visible = false;
            // 
            // tbAddNewLocationResult
            // 
            this.tbAddNewLocationResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.tbAddNewLocationResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddNewLocationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddNewLocationResult.ForeColor = System.Drawing.SystemColors.Window;
            this.tbAddNewLocationResult.Location = new System.Drawing.Point(109, 22);
            this.tbAddNewLocationResult.Margin = new System.Windows.Forms.Padding(0);
            this.tbAddNewLocationResult.Name = "tbAddNewLocationResult";
            this.tbAddNewLocationResult.Size = new System.Drawing.Size(284, 16);
            this.tbAddNewLocationResult.TabIndex = 8;
            this.tbAddNewLocationResult.Text = "Nearby landslides:";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(68)))));
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(109, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(390, 274);
            this.listBox2.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox8.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox8.Location = new System.Drawing.Point(17, 38);
            this.textBox8.Margin = new System.Windows.Forms.Padding(0);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(86, 16);
            this.textBox8.TabIndex = 4;
            this.textBox8.Text = "Add country:";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(13, 229);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 36);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(13, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(17, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panelAddNewLandslide
            // 
            this.panelAddNewLandslide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.panelAddNewLandslide.Controls.Add(this.button1);
            this.panelAddNewLandslide.Controls.Add(this.pictureBox1);
            this.panelAddNewLandslide.Controls.Add(this.checkBox2);
            this.panelAddNewLandslide.Controls.Add(this.textBox13);
            this.panelAddNewLandslide.Controls.Add(this.textBox12);
            this.panelAddNewLandslide.Controls.Add(this.textBox11);
            this.panelAddNewLandslide.Controls.Add(this.btnSubmit);
            this.panelAddNewLandslide.Controls.Add(this.btnDismiss);
            this.panelAddNewLandslide.Controls.Add(this.textBox7);
            this.panelAddNewLandslide.Controls.Add(this.textBox6);
            this.panelAddNewLandslide.Controls.Add(this.textBox5);
            this.panelAddNewLandslide.Location = new System.Drawing.Point(243, 12);
            this.panelAddNewLandslide.Name = "panelAddNewLandslide";
            this.panelAddNewLandslide.Size = new System.Drawing.Size(499, 330);
            this.panelAddNewLandslide.TabIndex = 2;
            this.panelAddNewLandslide.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "UPLOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(185, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.Location = new System.Drawing.Point(18, 176);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Upload photo?";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.ForeColor = System.Drawing.Color.White;
            this.textBox13.Location = new System.Drawing.Point(14, 76);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 13);
            this.textBox13.TabIndex = 8;
            this.textBox13.Text = "Add latitude:";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.ForeColor = System.Drawing.Color.White;
            this.textBox12.Location = new System.Drawing.Point(14, 124);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 13);
            this.textBox12.TabIndex = 7;
            this.textBox12.Text = "Add longitude:";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(14, 25);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 13);
            this.textBox11.TabIndex = 6;
            this.textBox11.Text = "Add location:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(95, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDismiss.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDismiss.Location = new System.Drawing.Point(14, 271);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(75, 23);
            this.btnDismiss.TabIndex = 4;
            this.btnDismiss.Text = "CANCEL";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(14, 150);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 20);
            this.textBox7.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(14, 98);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(145, 20);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(14, 43);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 20);
            this.textBox5.TabIndex = 0;
            // 
            // panelNearby
            // 
            this.panelNearby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.panelNearby.Controls.Add(this.textBoxNearbyLandslides);
            this.panelNearby.Controls.Add(this.listBox4);
            this.panelNearby.Location = new System.Drawing.Point(240, 12);
            this.panelNearby.Name = "panelNearby";
            this.panelNearby.Size = new System.Drawing.Size(508, 330);
            this.panelNearby.TabIndex = 4;
            this.panelNearby.Visible = false;
            // 
            // textBoxNearbyLandslides
            // 
            this.textBoxNearbyLandslides.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBoxNearbyLandslides.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNearbyLandslides.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNearbyLandslides.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxNearbyLandslides.Location = new System.Drawing.Point(3, 14);
            this.textBoxNearbyLandslides.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNearbyLandslides.Name = "textBoxNearbyLandslides";
            this.textBoxNearbyLandslides.Size = new System.Drawing.Size(224, 17);
            this.textBoxNearbyLandslides.TabIndex = 1;
            this.textBoxNearbyLandslides.Text = "Nearby landslides:";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(68)))));
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(3, 46);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(499, 274);
            this.listBox4.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(-3, 71);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(179, 46);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "Information";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // buttonNearby
            // 
            this.buttonNearby.FlatAppearance.BorderSize = 0;
            this.buttonNearby.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.buttonNearby.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.buttonNearby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNearby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonNearby.ForeColor = System.Drawing.Color.White;
            this.buttonNearby.Location = new System.Drawing.Point(-3, 163);
            this.buttonNearby.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNearby.Name = "buttonNearby";
            this.buttonNearby.Size = new System.Drawing.Size(179, 49);
            this.buttonNearby.TabIndex = 2;
            this.buttonNearby.Text = "Nearby landslides";
            this.buttonNearby.UseVisualStyleBackColor = true;
            this.buttonNearby.Click += new System.EventHandler(this.buttonNearby_Click);
            // 
            // buttonAddNewLocation
            // 
            this.buttonAddNewLocation.FlatAppearance.BorderSize = 0;
            this.buttonAddNewLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.buttonAddNewLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.buttonAddNewLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAddNewLocation.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewLocation.Location = new System.Drawing.Point(-3, 117);
            this.buttonAddNewLocation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddNewLocation.Name = "buttonAddNewLocation";
            this.buttonAddNewLocation.Size = new System.Drawing.Size(179, 46);
            this.buttonAddNewLocation.TabIndex = 3;
            this.buttonAddNewLocation.Text = "Add new location";
            this.buttonAddNewLocation.UseVisualStyleBackColor = true;
            this.buttonAddNewLocation.Click += new System.EventHandler(this.buttonAddNewLocation_Click);
            // 
            // btnAddNewLandslide
            // 
            this.btnAddNewLandslide.FlatAppearance.BorderSize = 0;
            this.btnAddNewLandslide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.btnAddNewLandslide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.btnAddNewLandslide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLandslide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAddNewLandslide.ForeColor = System.Drawing.Color.White;
            this.btnAddNewLandslide.Location = new System.Drawing.Point(-3, 212);
            this.btnAddNewLandslide.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewLandslide.Name = "btnAddNewLandslide";
            this.btnAddNewLandslide.Size = new System.Drawing.Size(179, 46);
            this.btnAddNewLandslide.TabIndex = 4;
            this.btnAddNewLandslide.Text = "Add new observation";
            this.btnAddNewLandslide.UseVisualStyleBackColor = true;
            this.btnAddNewLandslide.Click += new System.EventHandler(this.btnAddNewLandslide_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(760, 354);
            this.Controls.Add(this.btnAddNewLandslide);
            this.Controls.Add(this.buttonAddNewLocation);
            this.Controls.Add(this.buttonNearby);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.panelAddNewLocation);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelAddNewLandslide);
            this.Controls.Add(this.panelNearby);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Be Informed, Save Yourself!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            this.panelAddNewLocation.ResumeLayout(false);
            this.panelAddNewLocation.PerformLayout();
            this.panelAddNewLandslide.ResumeLayout(false);
            this.panelAddNewLandslide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNearby.ResumeLayout(false);
            this.panelNearby.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Panel panelAddNewLocation;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelAddNewLandslide;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panelNearby;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button buttonNearby;
        private System.Windows.Forms.Button buttonAddNewLocation;
        private System.Windows.Forms.Button btnAddNewLandslide;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.TextBox tbAddNewLocationResult;
        private System.Windows.Forms.TextBox textBoxNearbyLandslides;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

