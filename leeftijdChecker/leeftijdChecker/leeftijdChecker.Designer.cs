namespace leeftijdChecker
{
    partial class leeftijdChecker
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
            this.btnAlcohol = new System.Windows.Forms.Button();
            this.lblAlcohol = new System.Windows.Forms.Label();
            this.bornDatePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.schoolfeestDatePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBoxM = new System.Windows.Forms.CheckBox();
            this.checkBoxJ = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAlcohol
            // 
            this.btnAlcohol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlcohol.Location = new System.Drawing.Point(53, 51);
            this.btnAlcohol.Name = "btnAlcohol";
            this.btnAlcohol.Size = new System.Drawing.Size(200, 23);
            this.btnAlcohol.TabIndex = 0;
            this.btnAlcohol.Text = "Wanneer mag ik drinken?";
            this.btnAlcohol.UseVisualStyleBackColor = true;
            this.btnAlcohol.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAlcohol
            // 
            this.lblAlcohol.AutoSize = true;
            this.lblAlcohol.Location = new System.Drawing.Point(12, 9);
            this.lblAlcohol.Name = "lblAlcohol";
            this.lblAlcohol.Size = new System.Drawing.Size(317, 13);
            this.lblAlcohol.TabIndex = 1;
            this.lblAlcohol.Text = "Selecteer je geboortedatum om te weten wanneer je mag drinken:";
            // 
            // bornDatePicker
            // 
            this.bornDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bornDatePicker.Location = new System.Drawing.Point(53, 25);
            this.bornDatePicker.Name = "bornDatePicker";
            this.bornDatePicker.Size = new System.Drawing.Size(200, 20);
            this.bornDatePicker.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(53, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mag ik drinken met het schoolfeest?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // schoolfeestDatePicker
            // 
            this.schoolfeestDatePicker.Location = new System.Drawing.Point(413, 54);
            this.schoolfeestDatePicker.MaxDate = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            this.schoolfeestDatePicker.MinDate = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            this.schoolfeestDatePicker.Name = "schoolfeestDatePicker";
            this.schoolfeestDatePicker.Size = new System.Drawing.Size(200, 20);
            this.schoolfeestDatePicker.TabIndex = 6;
            this.schoolfeestDatePicker.Value = new System.DateTime(2021, 4, 17, 0, 0, 0, 0);
            this.schoolfeestDatePicker.Visible = false;
            // 
            // checkBoxM
            // 
            this.checkBoxM.AutoSize = true;
            this.checkBoxM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxM.Location = new System.Drawing.Point(259, 28);
            this.checkBoxM.Name = "checkBoxM";
            this.checkBoxM.Size = new System.Drawing.Size(56, 17);
            this.checkBoxM.TabIndex = 7;
            this.checkBoxM.Text = "Meisje";
            this.checkBoxM.UseVisualStyleBackColor = true;
            this.checkBoxM.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged);
            // 
            // checkBoxJ
            // 
            this.checkBoxJ.AutoSize = true;
            this.checkBoxJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxJ.Location = new System.Drawing.Point(259, 51);
            this.checkBoxJ.Name = "checkBoxJ";
            this.checkBoxJ.Size = new System.Drawing.Size(61, 17);
            this.checkBoxJ.TabIndex = 8;
            this.checkBoxJ.Text = "Jongen";
            this.checkBoxJ.UseVisualStyleBackColor = true;
            this.checkBoxJ.CheckedChanged += new System.EventHandler(this.checkBoxJ_CheckedChanged);
            // 
            // leeftijdChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 212);
            this.Controls.Add(this.checkBoxJ);
            this.Controls.Add(this.checkBoxM);
            this.Controls.Add(this.schoolfeestDatePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bornDatePicker);
            this.Controls.Add(this.lblAlcohol);
            this.Controls.Add(this.btnAlcohol);
            this.Name = "leeftijdChecker";
            this.ShowIcon = false;
            this.Text = "leeftijdChecker";
            this.Load += new System.EventHandler(this.leeftijdChecker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlcohol;
        private System.Windows.Forms.Label lblAlcohol;
        private System.Windows.Forms.DateTimePicker bornDatePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker schoolfeestDatePicker;
        private System.Windows.Forms.CheckBox checkBoxM;
        private System.Windows.Forms.CheckBox checkBoxJ;
    }
}

