namespace Naam
{
    partial class Naam
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
            this.txtboxNaam = new System.Windows.Forms.TextBox();
            this.btnVerzenden = new System.Windows.Forms.Button();
            this.lblNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxNaam
            // 
            this.txtboxNaam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxNaam.Location = new System.Drawing.Point(315, 155);
            this.txtboxNaam.MinimumSize = new System.Drawing.Size(0, 10);
            this.txtboxNaam.Name = "txtboxNaam";
            this.txtboxNaam.Size = new System.Drawing.Size(231, 20);
            this.txtboxNaam.TabIndex = 0;
            this.txtboxNaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxNaam.TextChanged += new System.EventHandler(this.txtboxNaam_TextChanged);
            // 
            // btnVerzenden
            // 
            this.btnVerzenden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerzenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerzenden.Location = new System.Drawing.Point(315, 198);
            this.btnVerzenden.Name = "btnVerzenden";
            this.btnVerzenden.Size = new System.Drawing.Size(232, 49);
            this.btnVerzenden.TabIndex = 1;
            this.btnVerzenden.Text = "Verzenden";
            this.btnVerzenden.UseVisualStyleBackColor = true;
            this.btnVerzenden.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(339, 95);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(182, 24);
            this.lblNaam.TabIndex = 2;
            this.lblNaam.Text = "Vul hier uw naam in:";
            // 
            // Naam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnVerzenden);
            this.Controls.Add(this.txtboxNaam);
            this.Name = "Naam";
            this.Text = "Naam";
            this.Load += new System.EventHandler(this.Naam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNaam;
        private System.Windows.Forms.Button btnVerzenden;
        private System.Windows.Forms.Label lblNaam;
    }
}

