namespace Webbrowser
{
    partial class Webbrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Webbrowser));
            this.btnWeb1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnWeb2 = new System.Windows.Forms.Button();
            this.btnWeb3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeb1
            // 
            this.btnWeb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeb1.Location = new System.Drawing.Point(12, 376);
            this.btnWeb1.Name = "btnWeb1";
            this.btnWeb1.Size = new System.Drawing.Size(207, 62);
            this.btnWeb1.TabIndex = 0;
            this.btnWeb1.Text = "YOUTUBE.COM";
            this.btnWeb1.UseVisualStyleBackColor = true;
            this.btnWeb1.Click += new System.EventHandler(this.btnWeb1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 346);
            this.webBrowser1.TabIndex = 1;
            // 
            // btnWeb2
            // 
            this.btnWeb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeb2.Location = new System.Drawing.Point(301, 376);
            this.btnWeb2.Name = "btnWeb2";
            this.btnWeb2.Size = new System.Drawing.Size(207, 62);
            this.btnWeb2.TabIndex = 2;
            this.btnWeb2.Text = "NU.NL";
            this.btnWeb2.UseVisualStyleBackColor = true;
            this.btnWeb2.Click += new System.EventHandler(this.btnWeb2_Click);
            // 
            // btnWeb3
            // 
            this.btnWeb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeb3.Location = new System.Drawing.Point(581, 376);
            this.btnWeb3.Name = "btnWeb3";
            this.btnWeb3.Size = new System.Drawing.Size(207, 62);
            this.btnWeb3.TabIndex = 3;
            this.btnWeb3.Text = "BUIENRADAR.NL";
            this.btnWeb3.UseVisualStyleBackColor = true;
            this.btnWeb3.Click += new System.EventHandler(this.btnWeb3_Click);
            // 
            // Webbrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWeb3);
            this.Controls.Add(this.btnWeb2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnWeb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Webbrowser";
            this.Text = "Webbrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWeb1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnWeb2;
        private System.Windows.Forms.Button btnWeb3;
    }
}

