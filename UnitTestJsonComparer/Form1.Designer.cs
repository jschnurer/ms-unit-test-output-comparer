namespace UnitTestJsonComparer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblExpected = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtExpected = new UnitTestJsonComparer.SyncTextBox();
            this.txtActual = new UnitTestJsonComparer.SyncTextBox();
            this.lblAssertionMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(102, 15);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Paste Test Output:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(120, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 23);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            // 
            // lblExpected
            // 
            this.lblExpected.AutoSize = true;
            this.lblExpected.Location = new System.Drawing.Point(226, 9);
            this.lblExpected.Name = "lblExpected";
            this.lblExpected.Size = new System.Drawing.Size(177, 15);
            this.lblExpected.TabIndex = 2;
            this.lblExpected.Text = "Expected on left, Actual on right";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(0, 68);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtExpected);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtActual);
            this.splitContainer1.Size = new System.Drawing.Size(789, 453);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // txtExpected
            // 
            this.txtExpected.Buddy = this.txtActual;
            this.txtExpected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpected.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExpected.Location = new System.Drawing.Point(0, 0);
            this.txtExpected.Multiline = true;
            this.txtExpected.Name = "txtExpected";
            this.txtExpected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExpected.Size = new System.Drawing.Size(390, 453);
            this.txtExpected.TabIndex = 0;
            // 
            // txtActual
            // 
            this.txtActual.Buddy = this.txtExpected;
            this.txtActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtActual.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtActual.Location = new System.Drawing.Point(0, 0);
            this.txtActual.Multiline = true;
            this.txtActual.Name = "txtActual";
            this.txtActual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActual.Size = new System.Drawing.Size(395, 453);
            this.txtActual.TabIndex = 0;
            // 
            // lblAssertionMessage
            // 
            this.lblAssertionMessage.Location = new System.Drawing.Point(12, 32);
            this.lblAssertionMessage.Name = "lblAssertionMessage";
            this.lblAssertionMessage.Size = new System.Drawing.Size(765, 33);
            this.lblAssertionMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 521);
            this.Controls.Add(this.lblAssertionMessage);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblExpected);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Unit Test Output Comparer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblExpected;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private SyncTextBox txtActual;
        private SyncTextBox txtExpected;
        private System.Windows.Forms.Label lblAssertionMessage;
    }
}

