namespace Leeftijdchecker1
{
    partial class LeeftijdChecker1
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
            this.components = new System.ComponentModel.Container();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxMeisje = new System.Windows.Forms.RadioButton();
            this.checkBoxJongen = new System.Windows.Forms.RadioButton();
            this.dtpSchoolFeest = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbAge
            // 
            this.txbAge.Location = new System.Drawing.Point(231, 66);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(36, 20);
            this.txbAge.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(298, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBoxMeisje
            // 
            this.checkBoxMeisje.AutoSize = true;
            this.checkBoxMeisje.Location = new System.Drawing.Point(298, 67);
            this.checkBoxMeisje.Name = "checkBoxMeisje";
            this.checkBoxMeisje.Size = new System.Drawing.Size(55, 17);
            this.checkBoxMeisje.TabIndex = 2;
            this.checkBoxMeisje.TabStop = true;
            this.checkBoxMeisje.Text = "Meisje";
            this.checkBoxMeisje.UseVisualStyleBackColor = true;
            this.checkBoxMeisje.CheckedChanged += new System.EventHandler(this.checkBoxMeisje_CheckedChanged);
            // 
            // checkBoxJongen
            // 
            this.checkBoxJongen.AutoSize = true;
            this.checkBoxJongen.Location = new System.Drawing.Point(298, 92);
            this.checkBoxJongen.Name = "checkBoxJongen";
            this.checkBoxJongen.Size = new System.Drawing.Size(60, 17);
            this.checkBoxJongen.TabIndex = 3;
            this.checkBoxJongen.TabStop = true;
            this.checkBoxJongen.Text = "Jongen";
            this.checkBoxJongen.UseVisualStyleBackColor = true;
            // 
            // dtpSchoolFeest
            // 
            this.dtpSchoolFeest.Location = new System.Drawing.Point(61, 92);
            this.dtpSchoolFeest.MaxDate = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.dtpSchoolFeest.MinDate = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.dtpSchoolFeest.Name = "dtpSchoolFeest";
            this.dtpSchoolFeest.Size = new System.Drawing.Size(206, 20);
            this.dtpSchoolFeest.TabIndex = 4;
            this.dtpSchoolFeest.Value = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.dtpSchoolFeest.Visible = false;
            this.dtpSchoolFeest.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(298, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "CHECK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Leeftijd:";
            // 
            // LeeftijdChecker1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpSchoolFeest);
            this.Controls.Add(this.checkBoxJongen);
            this.Controls.Add(this.checkBoxMeisje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbAge);
            this.Name = "LeeftijdChecker1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeeftijdChecker";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton checkBoxJongen;
        private System.Windows.Forms.RadioButton checkBoxMeisje;
        private System.Windows.Forms.DateTimePicker dtpSchoolFeest;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}

