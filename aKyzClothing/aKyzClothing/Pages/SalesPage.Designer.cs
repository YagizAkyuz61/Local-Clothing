
namespace aKyzClothing.Pages
{
    partial class SalesPage
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
            this.cameraPB = new System.Windows.Forms.PictureBox();
            this.barcodeTXT = new System.Windows.Forms.TextBox();
            this.barcodePB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLABEL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.sBarcodeTXT = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.sPhoneTXT = new System.Windows.Forms.TextBox();
            this.sPnBTN = new System.Windows.Forms.Button();
            this.refleshBTN = new System.Windows.Forms.Button();
            this.pBarcodeTXT = new System.Windows.Forms.TextBox();
            this.customerIdTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cameraCB = new System.Windows.Forms.ComboBox();
            this.cInsertBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.acceptBTN = new System.Windows.Forms.Button();
            this.rejectBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.stopBTN = new System.Windows.Forms.Button();
            this.menuBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraPB
            // 
            this.cameraPB.BackColor = System.Drawing.Color.Gray;
            this.cameraPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraPB.Location = new System.Drawing.Point(12, 60);
            this.cameraPB.Name = "cameraPB";
            this.cameraPB.Size = new System.Drawing.Size(313, 144);
            this.cameraPB.TabIndex = 0;
            this.cameraPB.TabStop = false;
            // 
            // barcodeTXT
            // 
            this.barcodeTXT.Enabled = false;
            this.barcodeTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barcodeTXT.Location = new System.Drawing.Point(40, 210);
            this.barcodeTXT.Name = "barcodeTXT";
            this.barcodeTXT.Size = new System.Drawing.Size(176, 38);
            this.barcodeTXT.TabIndex = 1;
            this.barcodeTXT.TextChanged += new System.EventHandler(this.barcodeTXT_TextChanged);
            // 
            // barcodePB
            // 
            this.barcodePB.BackColor = System.Drawing.Color.White;
            this.barcodePB.Location = new System.Drawing.Point(12, 254);
            this.barcodePB.Name = "barcodePB";
            this.barcodePB.Size = new System.Drawing.Size(239, 98);
            this.barcodePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barcodePB.TabIndex = 2;
            this.barcodePB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 10);
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
            this.dateLABEL.Location = new System.Drawing.Point(793, 9);
            this.dateLABEL.Name = "dateLABEL";
            this.dateLABEL.Size = new System.Drawing.Size(226, 25);
            this.dateLABEL.TabIndex = 16;
            this.dateLABEL.Text = "04.01.2021 - 20:30:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 181);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Barcode";
            // 
            // sBarcodeTXT
            // 
            this.sBarcodeTXT.Location = new System.Drawing.Point(398, 40);
            this.sBarcodeTXT.Name = "sBarcodeTXT";
            this.sBarcodeTXT.Size = new System.Drawing.Size(132, 20);
            this.sBarcodeTXT.TabIndex = 20;
            // 
            // searchBTN
            // 
            this.searchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBTN.Location = new System.Drawing.Point(537, 37);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(92, 23);
            this.searchBTN.TabIndex = 21;
            this.searchBTN.Text = "Search";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(331, 274);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(688, 124);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(330, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone Number";
            // 
            // sPhoneTXT
            // 
            this.sPhoneTXT.Location = new System.Drawing.Point(439, 253);
            this.sPhoneTXT.Name = "sPhoneTXT";
            this.sPhoneTXT.Size = new System.Drawing.Size(132, 20);
            this.sPhoneTXT.TabIndex = 20;
            // 
            // sPnBTN
            // 
            this.sPnBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sPnBTN.Location = new System.Drawing.Point(577, 251);
            this.sPnBTN.Name = "sPnBTN";
            this.sPnBTN.Size = new System.Drawing.Size(92, 23);
            this.sPnBTN.TabIndex = 23;
            this.sPnBTN.Text = "Search";
            this.sPnBTN.UseVisualStyleBackColor = true;
            this.sPnBTN.Click += new System.EventHandler(this.sPnBTN_Click);
            // 
            // refleshBTN
            // 
            this.refleshBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refleshBTN.Location = new System.Drawing.Point(662, 37);
            this.refleshBTN.Name = "refleshBTN";
            this.refleshBTN.Size = new System.Drawing.Size(113, 23);
            this.refleshBTN.TabIndex = 24;
            this.refleshBTN.Text = "List/Reflesh";
            this.refleshBTN.UseVisualStyleBackColor = true;
            this.refleshBTN.Click += new System.EventHandler(this.refleshBTN_Click);
            // 
            // pBarcodeTXT
            // 
            this.pBarcodeTXT.Enabled = false;
            this.pBarcodeTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pBarcodeTXT.Location = new System.Drawing.Point(448, 404);
            this.pBarcodeTXT.Name = "pBarcodeTXT";
            this.pBarcodeTXT.Size = new System.Drawing.Size(128, 23);
            this.pBarcodeTXT.TabIndex = 25;
            // 
            // customerIdTXT
            // 
            this.customerIdTXT.Enabled = false;
            this.customerIdTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerIdTXT.Location = new System.Drawing.Point(673, 404);
            this.customerIdTXT.Name = "customerIdTXT";
            this.customerIdTXT.Size = new System.Drawing.Size(128, 23);
            this.customerIdTXT.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(582, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Customer ID";
            // 
            // cameraCB
            // 
            this.cameraCB.FormattingEnabled = true;
            this.cameraCB.Location = new System.Drawing.Point(12, 38);
            this.cameraCB.Name = "cameraCB";
            this.cameraCB.Size = new System.Drawing.Size(239, 21);
            this.cameraCB.TabIndex = 32;
            // 
            // cInsertBTN
            // 
            this.cInsertBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cInsertBTN.Location = new System.Drawing.Point(333, 433);
            this.cInsertBTN.Name = "cInsertBTN";
            this.cInsertBTN.Size = new System.Drawing.Size(243, 47);
            this.cInsertBTN.TabIndex = 33;
            this.cInsertBTN.Text = "Customer Profile";
            this.cInsertBTN.UseVisualStyleBackColor = true;
            this.cInsertBTN.Click += new System.EventHandler(this.cInsertBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(328, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product Barcode";
            // 
            // acceptBTN
            // 
            this.acceptBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acceptBTN.Location = new System.Drawing.Point(582, 434);
            this.acceptBTN.Name = "acceptBTN";
            this.acceptBTN.Size = new System.Drawing.Size(219, 47);
            this.acceptBTN.TabIndex = 34;
            this.acceptBTN.Text = "Accept";
            this.acceptBTN.UseVisualStyleBackColor = true;
            this.acceptBTN.Click += new System.EventHandler(this.acceptBTN_Click);
            // 
            // rejectBTN
            // 
            this.rejectBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rejectBTN.Location = new System.Drawing.Point(807, 433);
            this.rejectBTN.Name = "rejectBTN";
            this.rejectBTN.Size = new System.Drawing.Size(205, 47);
            this.rejectBTN.TabIndex = 35;
            this.rejectBTN.Text = "Reject";
            this.rejectBTN.UseVisualStyleBackColor = true;
            this.rejectBTN.Click += new System.EventHandler(this.rejectBTN_Click);
            // 
            // startBTN
            // 
            this.startBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startBTN.Location = new System.Drawing.Point(12, 358);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(237, 54);
            this.startBTN.TabIndex = 36;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopBTN.Location = new System.Drawing.Point(12, 418);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(237, 53);
            this.stopBTN.TabIndex = 37;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseVisualStyleBackColor = true;
            this.stopBTN.Click += new System.EventHandler(this.stopBTN_Click);
            // 
            // menuBTN
            // 
            this.menuBTN.BackColor = System.Drawing.Color.White;
            this.menuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuBTN.Location = new System.Drawing.Point(13, 9);
            this.menuBTN.Name = "menuBTN";
            this.menuBTN.Size = new System.Drawing.Size(85, 23);
            this.menuBTN.TabIndex = 38;
            this.menuBTN.Text = "MENU";
            this.menuBTN.UseVisualStyleBackColor = false;
            this.menuBTN.Click += new System.EventHandler(this.menuBTN_Click);
            // 
            // SalesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1024, 492);
            this.Controls.Add(this.menuBTN);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.rejectBTN);
            this.Controls.Add(this.acceptBTN);
            this.Controls.Add(this.cInsertBTN);
            this.Controls.Add(this.cameraCB);
            this.Controls.Add(this.customerIdTXT);
            this.Controls.Add(this.pBarcodeTXT);
            this.Controls.Add(this.refleshBTN);
            this.Controls.Add(this.sPnBTN);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.sPhoneTXT);
            this.Controls.Add(this.sBarcodeTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLABEL);
            this.Controls.Add(this.barcodePB);
            this.Controls.Add(this.barcodeTXT);
            this.Controls.Add(this.cameraPB);
            this.Name = "SalesPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Page - aKyzClothing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesPage_FormClosed);
            this.Load += new System.EventHandler(this.SalesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cameraPB;
        private System.Windows.Forms.TextBox barcodeTXT;
        private System.Windows.Forms.PictureBox barcodePB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLABEL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sBarcodeTXT;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sPhoneTXT;
        private System.Windows.Forms.Button sPnBTN;
        private System.Windows.Forms.Button refleshBTN;
        private System.Windows.Forms.TextBox pBarcodeTXT;
        private System.Windows.Forms.TextBox customerIdTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cameraCB;
        private System.Windows.Forms.Button cInsertBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button acceptBTN;
        private System.Windows.Forms.Button rejectBTN;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.Button menuBTN;
    }
}