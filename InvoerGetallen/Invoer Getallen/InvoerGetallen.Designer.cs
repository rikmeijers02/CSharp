namespace Invoer_Getallen
{
    partial class InvoerGetallen
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
            this.txbGetal1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerzenden = new System.Windows.Forms.Button();
            this.txbGetal2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbGetal1
            // 
            this.txbGetal1.Location = new System.Drawing.Point(319, 70);
            this.txbGetal1.Name = "txbGetal1";
            this.txbGetal1.Size = new System.Drawing.Size(254, 20);
            this.txbGetal1.TabIndex = 0;
            this.txbGetal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbGetal1.TextChanged += new System.EventHandler(this.txbGetall_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 210);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vul hier een positief getal in:";
            // 
            // btnVerzenden
            // 
            this.btnVerzenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerzenden.Location = new System.Drawing.Point(320, 171);
            this.btnVerzenden.Name = "btnVerzenden";
            this.btnVerzenden.Size = new System.Drawing.Size(253, 40);
            this.btnVerzenden.TabIndex = 4;
            this.btnVerzenden.Text = "Verzend";
            this.btnVerzenden.UseVisualStyleBackColor = true;
            this.btnVerzenden.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbGetal2
            // 
            this.txbGetal2.Location = new System.Drawing.Point(320, 132);
            this.txbGetal2.Name = "txbGetal2";
            this.txbGetal2.Size = new System.Drawing.Size(253, 20);
            this.txbGetal2.TabIndex = 6;
            this.txbGetal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vul hier een negatief getal in:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InvoerGetallen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbGetal2);
            this.Controls.Add(this.btnVerzenden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbGetal1);
            this.Name = "InvoerGetallen";
            this.Text = "InvoerGetallen";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbGetal1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerzenden;
        private System.Windows.Forms.TextBox txbGetal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

