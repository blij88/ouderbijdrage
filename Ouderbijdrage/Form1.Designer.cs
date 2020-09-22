namespace Ouderbijdrage
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
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.firstName2ndP = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.singleParent = new System.Windows.Forms.CheckBox();
            this.InfoDisplay = new System.Windows.Forms.RichTextBox();
            this.lastName2ndP = new System.Windows.Forms.Label();
            this.secondParentFirstName = new System.Windows.Forms.TextBox();
            this.secondParentLastName = new System.Windows.Forms.TextBox();
            this.parentLastName = new System.Windows.Forms.TextBox();
            this.parentFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameChild = new System.Windows.Forms.TextBox();
            this.childName = new System.Windows.Forms.Label();
            this.finalAmount = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.createFamily = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.calcTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(162, 269);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(196, 22);
            this.birthday.TabIndex = 0;
            // 
            // firstName2ndP
            // 
            this.firstName2ndP.AutoSize = true;
            this.firstName2ndP.Location = new System.Drawing.Point(23, 118);
            this.firstName2ndP.Name = "firstName2ndP";
            this.firstName2ndP.Size = new System.Drawing.Size(112, 17);
            this.firstName2ndP.TabIndex = 1;
            this.firstName2ndP.Text = "voornaam ouder";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.Location = new System.Drawing.Point(23, 271);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(104, 17);
            this.dateOfBirth.TabIndex = 3;
            this.dateOfBirth.Text = "geboortedatum";
            // 
            // singleParent
            // 
            this.singleParent.AutoSize = true;
            this.singleParent.Location = new System.Drawing.Point(26, 81);
            this.singleParent.Name = "singleParent";
            this.singleParent.Size = new System.Drawing.Size(160, 21);
            this.singleParent.TabIndex = 4;
            this.singleParent.Text = "alleenstaande ouder";
            this.singleParent.UseVisualStyleBackColor = true;
            this.singleParent.CheckedChanged += new System.EventHandler(this.singleParent_CheckedChanged);
            // 
            // InfoDisplay
            // 
            this.InfoDisplay.Location = new System.Drawing.Point(412, 25);
            this.InfoDisplay.Name = "InfoDisplay";
            this.InfoDisplay.Size = new System.Drawing.Size(360, 361);
            this.InfoDisplay.TabIndex = 5;
            this.InfoDisplay.Text = "";
            // 
            // lastName2ndP
            // 
            this.lastName2ndP.AutoSize = true;
            this.lastName2ndP.Location = new System.Drawing.Point(23, 146);
            this.lastName2ndP.Name = "lastName2ndP";
            this.lastName2ndP.Size = new System.Drawing.Size(124, 17);
            this.lastName2ndP.TabIndex = 6;
            this.lastName2ndP.Text = "achternaam ouder";
            // 
            // secondParentFirstName
            // 
            this.secondParentFirstName.Location = new System.Drawing.Point(162, 118);
            this.secondParentFirstName.Name = "secondParentFirstName";
            this.secondParentFirstName.Size = new System.Drawing.Size(196, 22);
            this.secondParentFirstName.TabIndex = 7;
            // 
            // secondParentLastName
            // 
            this.secondParentLastName.Location = new System.Drawing.Point(162, 146);
            this.secondParentLastName.Name = "secondParentLastName";
            this.secondParentLastName.Size = new System.Drawing.Size(196, 22);
            this.secondParentLastName.TabIndex = 8;
            // 
            // parentLastName
            // 
            this.parentLastName.Location = new System.Drawing.Point(162, 53);
            this.parentLastName.Name = "parentLastName";
            this.parentLastName.Size = new System.Drawing.Size(196, 22);
            this.parentLastName.TabIndex = 14;
            // 
            // parentFirstName
            // 
            this.parentFirstName.Location = new System.Drawing.Point(162, 25);
            this.parentFirstName.Name = "parentFirstName";
            this.parentFirstName.Size = new System.Drawing.Size(196, 22);
            this.parentFirstName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "achternaam ouder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "voornaam ouder";
            // 
            // nameChild
            // 
            this.nameChild.Location = new System.Drawing.Point(162, 241);
            this.nameChild.Name = "nameChild";
            this.nameChild.Size = new System.Drawing.Size(196, 22);
            this.nameChild.TabIndex = 17;
            // 
            // childName
            // 
            this.childName.AutoSize = true;
            this.childName.Location = new System.Drawing.Point(23, 241);
            this.childName.Name = "childName";
            this.childName.Size = new System.Drawing.Size(101, 17);
            this.childName.TabIndex = 15;
            this.childName.Text = "voornaam kind";
            // 
            // finalAmount
            // 
            this.finalAmount.Location = new System.Drawing.Point(561, 403);
            this.finalAmount.Name = "finalAmount";
            this.finalAmount.Size = new System.Drawing.Size(211, 22);
            this.finalAmount.TabIndex = 18;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(409, 406);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(128, 17);
            this.Total.TabIndex = 19;
            this.Total.Text = "verwachte Bijdrage";
            // 
            // createFamily
            // 
            this.createFamily.Location = new System.Drawing.Point(45, 187);
            this.createFamily.Name = "createFamily";
            this.createFamily.Size = new System.Drawing.Size(187, 30);
            this.createFamily.TabIndex = 20;
            this.createFamily.Text = "creeër familie";
            this.createFamily.UseVisualStyleBackColor = true;
            this.createFamily.Click += new System.EventHandler(this.createFamily_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "voeg kind toe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // calcTotal
            // 
            this.calcTotal.Location = new System.Drawing.Point(220, 385);
            this.calcTotal.Name = "calcTotal";
            this.calcTotal.Size = new System.Drawing.Size(138, 38);
            this.calcTotal.TabIndex = 22;
            this.calcTotal.Text = "bereken bedrag";
            this.calcTotal.UseVisualStyleBackColor = true;
            this.calcTotal.Click += new System.EventHandler(this.calcTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcTotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createFamily);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.finalAmount);
            this.Controls.Add(this.nameChild);
            this.Controls.Add(this.childName);
            this.Controls.Add(this.parentLastName);
            this.Controls.Add(this.parentFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondParentLastName);
            this.Controls.Add(this.secondParentFirstName);
            this.Controls.Add(this.lastName2ndP);
            this.Controls.Add(this.InfoDisplay);
            this.Controls.Add(this.singleParent);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.firstName2ndP);
            this.Controls.Add(this.birthday);
            this.Name = "Form1";
            this.Text = "ouderbijdrage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label firstName2ndP;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.CheckBox singleParent;
        private System.Windows.Forms.RichTextBox InfoDisplay;
        private System.Windows.Forms.Label lastName2ndP;
        private System.Windows.Forms.TextBox secondParentFirstName;
        private System.Windows.Forms.TextBox secondParentLastName;
        private System.Windows.Forms.TextBox parentLastName;
        private System.Windows.Forms.TextBox parentFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameChild;
        private System.Windows.Forms.Label childName;
        private System.Windows.Forms.TextBox finalAmount;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button createFamily;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button calcTotal;
    }
}

