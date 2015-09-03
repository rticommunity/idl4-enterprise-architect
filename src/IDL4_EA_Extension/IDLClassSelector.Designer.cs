namespace IDL4_EA_Extension
{
    partial class IDLClassSelector
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
            this.treeViewModelElements = new System.Windows.Forms.TreeView();
            this.textBoxIDLOutput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewModelElements
            // 
            this.treeViewModelElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewModelElements.CheckBoxes = true;
            this.treeViewModelElements.Location = new System.Drawing.Point(3, 3);
            this.treeViewModelElements.Name = "treeViewModelElements";
            this.treeViewModelElements.Size = new System.Drawing.Size(225, 478);
            this.treeViewModelElements.TabIndex = 0;
            this.treeViewModelElements.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewModelElements_AfterCheck);
            this.treeViewModelElements.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewModelElements_AfterSelect);
            // 
            // textBoxIDLOutput
            // 
            this.textBoxIDLOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIDLOutput.Location = new System.Drawing.Point(234, 3);
            this.textBoxIDLOutput.Multiline = true;
            this.textBoxIDLOutput.Name = "textBoxIDLOutput";
            this.textBoxIDLOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIDLOutput.Size = new System.Drawing.Size(389, 478);
            this.textBoxIDLOutput.TabIndex = 0;
            this.textBoxIDLOutput.TextChanged += new System.EventHandler(this.textBoxIDLOutput_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.91275F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.08725F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxIDLOutput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGenerate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.treeViewModelElements, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 521);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(373, 487);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 31);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save IDL...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGenerate.Location = new System.Drawing.Point(66, 487);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(98, 31);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Generate IDL";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // IDLClassSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IDLClassSelector";
            this.Text = "IDLClassSelector";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewModelElements;
        private System.Windows.Forms.TextBox textBoxIDLOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}