namespace Signup_Form
{
    partial class CREATE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CREATE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fname = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.first_Name_input = new System.Windows.Forms.TextBox();
            this.Last_Name_input = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.Label();
            this.dob_input = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.read = new System.Windows.Forms.LinkLabel();
            this.genderInput = new System.Windows.Forms.Label();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.otherRadio = new System.Windows.Forms.RadioButton();
            this.onSubmit = new System.Windows.Forms.Button();
            this.LOGIN = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.signup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(45, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(489, 448);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.BackColor = System.Drawing.SystemColors.Window;
            this.Fname.Location = new System.Drawing.Point(134, 193);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(57, 13);
            this.Fname.TabIndex = 0;
            this.Fname.Text = "First Name";
            this.Fname.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.BackColor = System.Drawing.SystemColors.Window;
            this.Lname.Location = new System.Drawing.Point(134, 229);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(58, 13);
            this.Lname.TabIndex = 1;
            this.Lname.Text = "Last Name";
            this.Lname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // first_Name_input
            // 
            this.first_Name_input.Location = new System.Drawing.Point(207, 188);
            this.first_Name_input.Name = "first_Name_input";
            this.first_Name_input.Size = new System.Drawing.Size(164, 20);
            this.first_Name_input.TabIndex = 2;
            this.first_Name_input.TextChanged += new System.EventHandler(this.first_Name_input_TextChanged);
            // 
            // Last_Name_input
            // 
            this.Last_Name_input.Location = new System.Drawing.Point(207, 222);
            this.Last_Name_input.Name = "Last_Name_input";
            this.Last_Name_input.Size = new System.Drawing.Size(164, 20);
            this.Last_Name_input.TabIndex = 3;
            this.Last_Name_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.BackColor = System.Drawing.SystemColors.Window;
            this.dob.Location = new System.Drawing.Point(135, 261);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(65, 13);
            this.dob.TabIndex = 4;
            this.dob.Text = "Date of birth";
            this.dob.Click += new System.EventHandler(this.dob_Click);
            // 
            // dob_input
            // 
            this.dob_input.AccessibleName = " ";
            this.dob_input.Location = new System.Drawing.Point(207, 255);
            this.dob_input.Name = "dob_input";
            this.dob_input.Size = new System.Drawing.Size(164, 20);
            this.dob_input.TabIndex = 5;
            this.dob_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "‪D:\\vStudio project\\Signup Form\\pngwing.com.png";
            this.pictureBox1.Location = new System.Drawing.Point(253, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // read
            // 
            this.read.AutoSize = true;
            this.read.BackColor = System.Drawing.SystemColors.Window;
            this.read.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read.Location = new System.Drawing.Point(336, 400);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(98, 15);
            this.read.TabIndex = 7;
            this.read.TabStop = true;
            this.read.Text = "   ReadMore....";
            this.read.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // genderInput
            // 
            this.genderInput.AutoSize = true;
            this.genderInput.BackColor = System.Drawing.SystemColors.Window;
            this.genderInput.Location = new System.Drawing.Point(135, 294);
            this.genderInput.Name = "genderInput";
            this.genderInput.Size = new System.Drawing.Size(42, 13);
            this.genderInput.TabIndex = 8;
            this.genderInput.Text = "Gender";
            this.genderInput.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.BackColor = System.Drawing.SystemColors.Window;
            this.maleRadio.Location = new System.Drawing.Point(219, 294);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(48, 17);
            this.maleRadio.TabIndex = 9;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = false;
            this.maleRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.BackColor = System.Drawing.SystemColors.Window;
            this.femaleRadio.Location = new System.Drawing.Point(282, 294);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 10;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = false;
            this.femaleRadio.CheckedChanged += new System.EventHandler(this.femaleRadio_CheckedChanged);
            // 
            // otherRadio
            // 
            this.otherRadio.AutoSize = true;
            this.otherRadio.BackColor = System.Drawing.SystemColors.Window;
            this.otherRadio.Location = new System.Drawing.Point(368, 294);
            this.otherRadio.Name = "otherRadio";
            this.otherRadio.Size = new System.Drawing.Size(51, 17);
            this.otherRadio.TabIndex = 11;
            this.otherRadio.TabStop = true;
            this.otherRadio.Text = "Other";
            this.otherRadio.UseVisualStyleBackColor = false;
            this.otherRadio.CheckedChanged += new System.EventHandler(this.otherRadio_CheckedChanged);
            // 
            // onSubmit
            // 
            this.onSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.onSubmit.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onSubmit.Location = new System.Drawing.Point(258, 339);
            this.onSubmit.Name = "onSubmit";
            this.onSubmit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.onSubmit.Size = new System.Drawing.Size(59, 32);
            this.onSubmit.TabIndex = 12;
            this.onSubmit.Text = "Submit";
            this.onSubmit.UseVisualStyleBackColor = false;
            this.onSubmit.Click += new System.EventHandler(this.onSubmit_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.BackColor = System.Drawing.SystemColors.Window;
            this.LOGIN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(187, 399);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(43, 15);
            this.LOGIN.TabIndex = 13;
            this.LOGIN.TabStop = true;
            this.LOGIN.Text = "Login";
            this.LOGIN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginPage_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(203, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Create Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.BackColor = System.Drawing.SystemColors.Control;
            this.signup.Controls.Add(this.label1);
            this.signup.Controls.Add(this.LOGIN);
            this.signup.Controls.Add(this.onSubmit);
            this.signup.Controls.Add(this.otherRadio);
            this.signup.Controls.Add(this.femaleRadio);
            this.signup.Controls.Add(this.maleRadio);
            this.signup.Controls.Add(this.genderInput);
            this.signup.Controls.Add(this.read);
            this.signup.Controls.Add(this.pictureBox1);
            this.signup.Controls.Add(this.dob_input);
            this.signup.Controls.Add(this.dob);
            this.signup.Controls.Add(this.Last_Name_input);
            this.signup.Controls.Add(this.first_Name_input);
            this.signup.Controls.Add(this.Lname);
            this.signup.Controls.Add(this.Fname);
            this.signup.Controls.Add(this.groupBox1);
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup.Location = new System.Drawing.Point(12, 3);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(1278, 734);
            this.signup.TabIndex = 0;
            this.signup.TabStop = false;
            this.signup.Text = "SignUp";
            this.signup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CREATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 503);
            this.Controls.Add(this.signup);
            this.Name = "CREATE";
            this.Text = "Create Account ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.signup.ResumeLayout(false);
            this.signup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.TextBox first_Name_input;
        private System.Windows.Forms.TextBox Last_Name_input;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.TextBox dob_input;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel read;
        private System.Windows.Forms.Label genderInput;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton otherRadio;
        private System.Windows.Forms.Button onSubmit;
        private System.Windows.Forms.LinkLabel LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox signup;
    }
}

