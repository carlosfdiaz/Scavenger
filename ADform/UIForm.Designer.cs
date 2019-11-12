using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scavenger
{

    partial class UIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIForm));
            this.domainLabel = new System.Windows.Forms.Label();
            this.domainTField = new System.Windows.Forms.TextBox();
            this.dValue = new System.Windows.Forms.Label();
            this.displayInfo = new System.Windows.Forms.RichTextBox();
            this.userSearch = new System.Windows.Forms.Button();
            this.userTField = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.compareButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ldapStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // domainLabel
            // 
            this.domainLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.domainLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.domainLabel.Location = new System.Drawing.Point(12, 36);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(84, 25);
            this.domainLabel.TabIndex = 0;
            this.domainLabel.Text = "Domain";
            this.domainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // domainTField
            // 
            this.domainTField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.domainTField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainTField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainTField.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.domainTField.Location = new System.Drawing.Point(12, 64);
            this.domainTField.Name = "domainTField";
            this.domainTField.Size = new System.Drawing.Size(162, 24);
            this.domainTField.TabIndex = 1;
            this.domainTField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.domainTField_KeyDown);
            // 
            // dValue
            // 
            this.dValue.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dValue.ForeColor = System.Drawing.Color.Red;
            this.dValue.Location = new System.Drawing.Point(174, 66);
            this.dValue.Name = "dValue";
            this.dValue.Size = new System.Drawing.Size(21, 24);
            this.dValue.TabIndex = 2;
            this.dValue.Text = "*";
            this.dValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dValue.Visible = false;
            // 
            // displayInfo
            // 
            this.displayInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.displayInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displayInfo.Location = new System.Drawing.Point(12, 158);
            this.displayInfo.Name = "displayInfo";
            this.displayInfo.ReadOnly = true;
            this.displayInfo.Size = new System.Drawing.Size(355, 203);
            this.displayInfo.TabIndex = 4;
            this.displayInfo.Text = "";
            // 
            // userSearch
            // 
            this.userSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(25)))));
            this.userSearch.FlatAppearance.BorderSize = 0;
            this.userSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userSearch.Location = new System.Drawing.Point(180, 93);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(107, 50);
            this.userSearch.TabIndex = 3;
            this.userSearch.Text = "Search User";
            this.userSearch.UseVisualStyleBackColor = false;
            this.userSearch.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // userTField
            // 
            this.userTField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userTField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTField.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userTField.Location = new System.Drawing.Point(12, 119);
            this.userTField.Name = "userTField";
            this.userTField.Size = new System.Drawing.Size(162, 24);
            this.userTField.TabIndex = 2;
            this.userTField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTField_KeyDown);
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userLabel.Location = new System.Drawing.Point(12, 91);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(84, 25);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User ";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.ldapStatus);
            this.panel3.Controls.Add(this.compareButton);
            this.panel3.Controls.Add(this.ExitButton);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Controls.Add(this.panelResult);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.userSearch);
            this.panel3.Controls.Add(this.displayInfo);
            this.panel3.Controls.Add(this.userTField);
            this.panel3.Controls.Add(this.dValue);
            this.panel3.Controls.Add(this.userLabel);
            this.panel3.Controls.Add(this.domainTField);
            this.panel3.Controls.Add(this.domainLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.MinimumSize = new System.Drawing.Size(381, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 373);
            this.panel3.TabIndex = 4;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown_1);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove_1);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp_1);
            // 
            // panelResult
            // 
            this.panelResult.AutoSize = true;
            this.panelResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelResult.Location = new System.Drawing.Point(0, 360);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(0, 0);
            this.panelResult.TabIndex = 12;
            // 
            // compareButton
            // 
            this.compareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.compareButton.FlatAppearance.BorderSize = 0;
            this.compareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compareButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.compareButton.Location = new System.Drawing.Point(197, 0);
            this.compareButton.Margin = new System.Windows.Forms.Padding(2);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(100, 33);
            this.compareButton.TabIndex = 9;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = false;
            this.compareButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.compareButton_MouseClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(352, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(28, 33);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ldapStatus
            // 
            this.ldapStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ldapStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ldapStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldapStatus.ForeColor = System.Drawing.Color.DarkOrange;
            this.ldapStatus.Location = new System.Drawing.Point(297, 0);
            this.ldapStatus.Name = "ldapStatus";
            this.ldapStatus.Size = new System.Drawing.Size(53, 33);
            this.ldapStatus.TabIndex = 10;
            this.ldapStatus.Text = "LDAP";
            this.ldapStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(372, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 36);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(381, 373);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(381, 373);
            this.Name = "UIForm";
            this.Text = "Scavenger";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UIForm_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.TextBox domainTField;
        private Label dValue;
        private RichTextBox displayInfo;
        private Label userLabel;
        private TextBox userTField;
        private Button userSearch;
        private Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label ldapStatus;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private Button ExitButton;
        private Button compareButton;
        private Panel panel1;
        private Panel panelResult;
    }
}

