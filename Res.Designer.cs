namespace CatsDogs
{
    partial class Res
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateIbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientnametbl = new System.Windows.Forms.MaskedTextBox();
            this.clientpetnametbl = new System.Windows.Forms.MaskedTextBox();
            this.clientidtbl = new System.Windows.Forms.MaskedTextBox();
            this.ReservationInformation = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
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
            this.panel1.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(165, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            // 
            // clientnametbl
            // 
            this.clientnametbl.ForeColor = System.Drawing.Color.Green;
            this.clientnametbl.Location = new System.Drawing.Point(27, 197);
            this.clientnametbl.Name = "clientnametbl";
            this.clientnametbl.Size = new System.Drawing.Size(238, 22);
            this.clientnametbl.TabIndex = 5;
            this.clientnametbl.Text = "ClientName";
            this.clientnametbl.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.clientnametbl_MaskInputRejected);
            // 
            // clientpetnametbl
            // 
            this.clientpetnametbl.ForeColor = System.Drawing.Color.Green;
            this.clientpetnametbl.Location = new System.Drawing.Point(27, 255);
            this.clientpetnametbl.Name = "clientpetnametbl";
            this.clientpetnametbl.Size = new System.Drawing.Size(238, 22);
            this.clientpetnametbl.TabIndex = 4;
            this.clientpetnametbl.Text = "ClientPetName";
            this.clientpetnametbl.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.clientpetnametbl_MaskInputRejected);
            // 
            // clientidtbl
            // 
            this.clientidtbl.ForeColor = System.Drawing.Color.Green;
            this.clientidtbl.Location = new System.Drawing.Point(27, 143);
            this.clientidtbl.Name = "clientidtbl";
            this.clientidtbl.Size = new System.Drawing.Size(238, 22);
            this.clientidtbl.TabIndex = 6;
            this.clientidtbl.Text = "ClientId";
            this.clientidtbl.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.clientidtbl_MaskInputRejected);
            // 
            // ReservationInformation
            // 
            this.ReservationInformation.Location = new System.Drawing.Point(27, 309);
            this.ReservationInformation.Name = "ReservationInformation";
            this.ReservationInformation.Size = new System.Drawing.Size(238, 22);
            this.ReservationInformation.TabIndex = 7;
            // 
            // Res
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReservationInformation);
            this.Controls.Add(this.clientnametbl);
            this.Controls.Add(this.clientpetnametbl);
            this.Controls.Add(this.clientidtbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Res";
            this.Text = "Res";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DateIbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox clientnametbl;
        private System.Windows.Forms.MaskedTextBox clientpetnametbl;
        private System.Windows.Forms.MaskedTextBox clientidtbl;
        private System.Windows.Forms.DateTimePicker ReservationInformation;
    }
}