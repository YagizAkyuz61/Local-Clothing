
namespace aKyzClothing.Pages
{
    partial class MenuPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateLABEL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hpBTN = new System.Windows.Forms.Button();
            this.spBTN = new System.Windows.Forms.Button();
            this.stockPageBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "aKyzClothing";
            // 
            // dateLABEL
            // 
            this.dateLABEL.AutoSize = true;
            this.dateLABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLABEL.ForeColor = System.Drawing.Color.White;
            this.dateLABEL.Location = new System.Drawing.Point(10, 253);
            this.dateLABEL.Name = "dateLABEL";
            this.dateLABEL.Size = new System.Drawing.Size(226, 25);
            this.dateLABEL.TabIndex = 16;
            this.dateLABEL.Text = "04.01.2021 - 20:30:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hpBTN
            // 
            this.hpBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hpBTN.Location = new System.Drawing.Point(14, 52);
            this.hpBTN.Name = "hpBTN";
            this.hpBTN.Size = new System.Drawing.Size(214, 57);
            this.hpBTN.TabIndex = 18;
            this.hpBTN.Text = "Home Page";
            this.hpBTN.UseVisualStyleBackColor = true;
            this.hpBTN.Click += new System.EventHandler(this.hpBTN_Click);
            // 
            // spBTN
            // 
            this.spBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.spBTN.Location = new System.Drawing.Point(14, 115);
            this.spBTN.Name = "spBTN";
            this.spBTN.Size = new System.Drawing.Size(214, 57);
            this.spBTN.TabIndex = 19;
            this.spBTN.Text = "Sales Page";
            this.spBTN.UseVisualStyleBackColor = true;
            this.spBTN.Click += new System.EventHandler(this.spBTN_Click);
            // 
            // stockPageBTN
            // 
            this.stockPageBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockPageBTN.Location = new System.Drawing.Point(14, 178);
            this.stockPageBTN.Name = "stockPageBTN";
            this.stockPageBTN.Size = new System.Drawing.Size(214, 57);
            this.stockPageBTN.TabIndex = 20;
            this.stockPageBTN.Text = "Stock Page";
            this.stockPageBTN.UseVisualStyleBackColor = true;
            this.stockPageBTN.Click += new System.EventHandler(this.stockPageBTN_Click);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(240, 291);
            this.Controls.Add(this.stockPageBTN);
            this.Controls.Add(this.spBTN);
            this.Controls.Add(this.hpBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLABEL);
            this.Name = "MenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Page";
            this.Load += new System.EventHandler(this.MenuPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLABEL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button hpBTN;
        private System.Windows.Forms.Button spBTN;
        private System.Windows.Forms.Button stockPageBTN;
    }
}