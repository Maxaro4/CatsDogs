namespace CatsDogs
{
    partial class ClientInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateIbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientpetnametbl = new System.Windows.Forms.MaskedTextBox();
            this.clientnametbl = new System.Windows.Forms.MaskedTextBox();
            this.clientidtbl = new System.Windows.Forms.MaskedTextBox();
            this.ClientGridview = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.clientphonetbl = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Editbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.DateIbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // DateIbl
            // 
            this.DateIbl.AutoSize = true;
            this.DateIbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateIbl.Location = new System.Drawing.Point(620, 68);
            this.DateIbl.Name = "DateIbl";
            this.DateIbl.Size = new System.Drawing.Size(74, 32);
            this.DateIbl.TabIndex = 1;
            this.DateIbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(236, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Information";
            // 
            // clientpetnametbl
            // 
            this.clientpetnametbl.ForeColor = System.Drawing.Color.Green;
            this.clientpetnametbl.Location = new System.Drawing.Point(513, 248);
            this.clientpetnametbl.Name = "clientpetnametbl";
            this.clientpetnametbl.Size = new System.Drawing.Size(238, 22);
            this.clientpetnametbl.TabIndex = 1;
            this.clientpetnametbl.Text = "ClientPetName";
            this.clientpetnametbl.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.clientpetnametbl_MaskInputRejected);
            // 
            // clientnametbl
            // 
            this.clientnametbl.ForeColor = System.Drawing.Color.Green;
            this.clientnametbl.Location = new System.Drawing.Point(513, 190);
            this.clientnametbl.Name = "clientnametbl";
            this.clientnametbl.Size = new System.Drawing.Size(238, 22);
            this.clientnametbl.TabIndex = 2;
            this.clientnametbl.Text = "ClientName";
            this.clientnametbl.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.clientnametbl_MaskInputRejected);
            // 
            // clientidtbl
            // 
            this.clientidtbl.ForeColor = System.Drawing.Color.Green;
            this.clientidtbl.Location = new System.Drawing.Point(513, 136);
            this.clientidtbl.Name = "clientidtbl";
            this.clientidtbl.Size = new System.Drawing.Size(238, 22);
            this.clientidtbl.TabIndex = 3;
            this.clientidtbl.Text = "ClientId";
            this.clientidtbl.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.clientidtbl_MaskInputRejected);
            // 
            // ClientGridview
            // 
            this.ClientGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridview.Location = new System.Drawing.Point(12, 136);
            this.ClientGridview.Name = "ClientGridview";
            this.ClientGridview.RowHeadersWidth = 51;
            this.ClientGridview.RowTemplate.Height = 24;
            this.ClientGridview.Size = new System.Drawing.Size(444, 262);
            this.ClientGridview.TabIndex = 4;
            this.ClientGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridview_CellContentClick);
            // 
            // AddBtn
            // 
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.Color.Green;
            this.AddBtn.Location = new System.Drawing.Point(513, 350);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 35);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.ForeColor = System.Drawing.Color.Green;
            this.Deletebtn.Location = new System.Drawing.Point(675, 350);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 35);
            this.Deletebtn.TabIndex = 7;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // clientphonetbl
            // 
            this.clientphonetbl.ForeColor = System.Drawing.Color.Green;
            this.clientphonetbl.Location = new System.Drawing.Point(513, 307);
            this.clientphonetbl.Name = "clientphonetbl";
            this.clientphonetbl.Size = new System.Drawing.Size(237, 22);
            this.clientphonetbl.TabIndex = 10;
            this.clientphonetbl.Text = "ClientPhone";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Editbtn
            // 
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbtn.ForeColor = System.Drawing.Color.Green;
            this.Editbtn.Location = new System.Drawing.Point(594, 350);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(75, 35);
            this.Editbtn.TabIndex = 11;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.clientphonetbl);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ClientGridview);
            this.Controls.Add(this.clientnametbl);
            this.Controls.Add(this.clientpetnametbl);
            this.Controls.Add(this.clientidtbl);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientInfo";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox clientpetnametbl;
        private System.Windows.Forms.MaskedTextBox clientnametbl;
        private System.Windows.Forms.MaskedTextBox clientidtbl;
        private System.Windows.Forms.DataGridView ClientGridview;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.MaskedTextBox clientphonetbl;
        private System.Windows.Forms.Label DateIbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Editbtn;
    }
}