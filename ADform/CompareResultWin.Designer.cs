namespace Scavenger
{
    partial class CompareResultWin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayInfo3 = new System.Windows.Forms.RichTextBox();
            this.groupsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.groupsLabel);
            this.panel1.Controls.Add(this.displayInfo3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 280);
            this.panel1.TabIndex = 0;
            // 
            // displayInfo3
            // 
            this.displayInfo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.displayInfo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayInfo3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayInfo3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displayInfo3.Location = new System.Drawing.Point(200, 50);
            this.displayInfo3.Name = "displayInfo3";
            this.displayInfo3.ReadOnly = true;
            this.displayInfo3.Size = new System.Drawing.Size(355, 203);
            this.displayInfo3.TabIndex = 5;
            this.displayInfo3.Text = "";
            // 
            // groupsLabel
            // 
            this.groupsLabel.AutoSize = true;
            this.groupsLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupsLabel.Location = new System.Drawing.Point(197, 18);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(148, 20);
            this.groupsLabel.TabIndex = 6;
            this.groupsLabel.Text = "Groups missing for: ";
            // 
            // CompareResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CompareResult";
            this.Size = new System.Drawing.Size(750, 280);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox displayInfo3;
        private System.Windows.Forms.Label groupsLabel;
    }
}
