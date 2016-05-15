namespace LoLPower.UI
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.btntest = new System.Windows.Forms.Button();
            this.dgvCurrentPlayerIno = new System.Windows.Forms.DataGridView();
            this.dgvCurrentParticipants = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPlayerIno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.AutoSize = true;
            this.lblStatusMessage.Location = new System.Drawing.Point(59, 13);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(0, 13);
            this.lblStatusMessage.TabIndex = 1;
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(16, 352);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(75, 23);
            this.btntest.TabIndex = 2;
            this.btntest.Text = "test";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // dgvCurrentPlayerIno
            // 
            this.dgvCurrentPlayerIno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentPlayerIno.Location = new System.Drawing.Point(12, 29);
            this.dgvCurrentPlayerIno.Name = "dgvCurrentPlayerIno";
            this.dgvCurrentPlayerIno.Size = new System.Drawing.Size(235, 116);
            this.dgvCurrentPlayerIno.TabIndex = 3;
            // 
            // dgvCurrentParticipants
            // 
            this.dgvCurrentParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurrentParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentParticipants.Location = new System.Drawing.Point(254, 29);
            this.dgvCurrentParticipants.Name = "dgvCurrentParticipants";
            this.dgvCurrentParticipants.Size = new System.Drawing.Size(414, 312);
            this.dgvCurrentParticipants.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 387);
            this.Controls.Add(this.dgvCurrentParticipants);
            this.Controls.Add(this.dgvCurrentPlayerIno);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.lblStatusMessage);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentPlayerIno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusMessage;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.DataGridView dgvCurrentPlayerIno;
        private System.Windows.Forms.DataGridView dgvCurrentParticipants;
    }
}

