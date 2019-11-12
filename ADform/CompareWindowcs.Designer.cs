namespace Scavenger
{
    partial class CompareWindowcs
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
            this.panelCompare = new System.Windows.Forms.Panel();
            this.userSearch2 = new System.Windows.Forms.Button();
            this.userTField2 = new System.Windows.Forms.TextBox();
            this.userLabel2 = new System.Windows.Forms.Label();
            this.displayInfo2 = new System.Windows.Forms.RichTextBox();
            this.panelCompare.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCompare
            // 
            this.panelCompare.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelCompare.Controls.Add(this.userSearch2);
            this.panelCompare.Controls.Add(this.userTField2);
            this.panelCompare.Controls.Add(this.userLabel2);
            this.panelCompare.Controls.Add(this.displayInfo2);
            this.panelCompare.Location = new System.Drawing.Point(0, 0);
            this.panelCompare.Margin = new System.Windows.Forms.Padding(4);
            this.panelCompare.Name = "panelCompare";
            this.panelCompare.Size = new System.Drawing.Size(508, 459);
            this.panelCompare.TabIndex = 5;
            // 
            // userSearch2
            // 
            this.userSearch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(25)))));
            this.userSearch2.FlatAppearance.BorderSize = 0;
            this.userSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userSearch2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearch2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userSearch2.Location = new System.Drawing.Point(240, 114);
            this.userSearch2.Margin = new System.Windows.Forms.Padding(4);
            this.userSearch2.Name = "userSearch2";
            this.userSearch2.Size = new System.Drawing.Size(143, 62);
            this.userSearch2.TabIndex = 3;
            this.userSearch2.Text = "Search User";
            this.userSearch2.UseVisualStyleBackColor = false;
            this.userSearch2.Click += new System.EventHandler(this.userSearch2_Click);
            // 
            // userTField2
            // 
            this.userTField2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userTField2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTField2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userTField2.Location = new System.Drawing.Point(16, 146);
            this.userTField2.Margin = new System.Windows.Forms.Padding(4);
            this.userTField2.Name = "userTField2";
            this.userTField2.Size = new System.Drawing.Size(215, 29);
            this.userTField2.TabIndex = 2;
            // 
            // userLabel2
            // 
            this.userLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userLabel2.Location = new System.Drawing.Point(16, 112);
            this.userLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel2.Name = "userLabel2";
            this.userLabel2.Size = new System.Drawing.Size(112, 31);
            this.userLabel2.TabIndex = 0;
            this.userLabel2.Text = "User 2";
            this.userLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // displayInfo2
            // 
            this.displayInfo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.displayInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayInfo2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayInfo2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displayInfo2.Location = new System.Drawing.Point(16, 194);
            this.displayInfo2.Margin = new System.Windows.Forms.Padding(4);
            this.displayInfo2.Name = "displayInfo2";
            this.displayInfo2.ReadOnly = true;
            this.displayInfo2.Size = new System.Drawing.Size(473, 250);
            this.displayInfo2.TabIndex = 4;
            this.displayInfo2.Text = "";
            // 
            // CompareWindowcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCompare);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompareWindowcs";
            this.Size = new System.Drawing.Size(508, 459);
            this.panelCompare.ResumeLayout(false);
            this.panelCompare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCompare;
        private System.Windows.Forms.Button userSearch2;
        private System.Windows.Forms.RichTextBox displayInfo2;
        private System.Windows.Forms.TextBox userTField2;
        private System.Windows.Forms.Label userLabel2;
    }
}
