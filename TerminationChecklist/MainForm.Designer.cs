namespace TerminationChecklist {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.cbCUCB = new System.Windows.Forms.CheckBox();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.cbDigitalTest = new System.Windows.Forms.CheckBox();
            this.cbDigitalProd = new System.Windows.Forms.CheckBox();
            this.cbLFI = new System.Windows.Forms.CheckBox();
            this.gbEnv = new System.Windows.Forms.GroupBox();
            this.tbUName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.tbDisc = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbAction.SuspendLayout();
            this.gbEnv.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 138);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 167);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(476, 255);
            this.rtbOutput.TabIndex = 2;
            this.rtbOutput.Text = "";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(12, 428);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 3;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(6, 19);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(69, 17);
            this.rbAdd.TabIndex = 4;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add User";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(6, 42);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(90, 17);
            this.rbDelete.TabIndex = 5;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Remove User";
            this.rbDelete.UseVisualStyleBackColor = true;
            // 
            // cbCUCB
            // 
            this.cbCUCB.AutoSize = true;
            this.cbCUCB.Location = new System.Drawing.Point(6, 19);
            this.cbCUCB.Name = "cbCUCB";
            this.cbCUCB.Size = new System.Drawing.Size(58, 17);
            this.cbCUCB.TabIndex = 6;
            this.cbCUCB.Text = "CU-CB";
            this.cbCUCB.UseVisualStyleBackColor = true;
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.rbAdd);
            this.gbAction.Controls.Add(this.rbDelete);
            this.gbAction.Location = new System.Drawing.Point(372, 12);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(116, 67);
            this.gbAction.TabIndex = 7;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Action";
            // 
            // cbDigitalTest
            // 
            this.cbDigitalTest.AutoSize = true;
            this.cbDigitalTest.Location = new System.Drawing.Point(6, 43);
            this.cbDigitalTest.Name = "cbDigitalTest";
            this.cbDigitalTest.Size = new System.Drawing.Size(79, 17);
            this.cbDigitalTest.TabIndex = 8;
            this.cbDigitalTest.Text = "Digital Test";
            this.cbDigitalTest.UseVisualStyleBackColor = true;
            // 
            // cbDigitalProd
            // 
            this.cbDigitalProd.AutoSize = true;
            this.cbDigitalProd.Location = new System.Drawing.Point(6, 67);
            this.cbDigitalProd.Name = "cbDigitalProd";
            this.cbDigitalProd.Size = new System.Drawing.Size(109, 17);
            this.cbDigitalProd.TabIndex = 9;
            this.cbDigitalProd.Text = "Digital Production";
            this.cbDigitalProd.UseVisualStyleBackColor = true;
            // 
            // cbLFI
            // 
            this.cbLFI.AutoSize = true;
            this.cbLFI.Location = new System.Drawing.Point(6, 91);
            this.cbLFI.Name = "cbLFI";
            this.cbLFI.Size = new System.Drawing.Size(65, 17);
            this.cbLFI.TabIndex = 10;
            this.cbLFI.Text = "Large FI";
            this.cbLFI.UseVisualStyleBackColor = true;
            // 
            // gbEnv
            // 
            this.gbEnv.Controls.Add(this.cbLFI);
            this.gbEnv.Controls.Add(this.cbDigitalProd);
            this.gbEnv.Controls.Add(this.cbDigitalTest);
            this.gbEnv.Controls.Add(this.cbCUCB);
            this.gbEnv.Location = new System.Drawing.Point(242, 12);
            this.gbEnv.Name = "gbEnv";
            this.gbEnv.Size = new System.Drawing.Size(124, 110);
            this.gbEnv.TabIndex = 11;
            this.gbEnv.TabStop = false;
            this.gbEnv.Text = "Environment";
            // 
            // tbUName
            // 
            this.tbUName.Location = new System.Drawing.Point(80, 12);
            this.tbUName.Name = "tbUName";
            this.tbUName.Size = new System.Drawing.Size(145, 20);
            this.tbUName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "User Name:";
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Location = new System.Drawing.Point(11, 45);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(63, 13);
            this.lblDisc.TabIndex = 15;
            this.lblDisc.Text = "Description:";
            // 
            // tbDisc
            // 
            this.tbDisc.Location = new System.Drawing.Point(80, 38);
            this.tbDisc.Name = "tbDisc";
            this.tbDisc.Size = new System.Drawing.Size(145, 20);
            this.tbDisc.TabIndex = 14;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(11, 72);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(65, 13);
            this.lblDept.TabIndex = 17;
            this.lblDept.Text = "Department:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.tbDisc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbUName);
            this.Controls.Add(this.gbEnv);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            this.gbEnv.ResumeLayout(false);
            this.gbEnv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.CheckBox cbCUCB;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.CheckBox cbDigitalTest;
        private System.Windows.Forms.CheckBox cbDigitalProd;
        private System.Windows.Forms.CheckBox cbLFI;
        private System.Windows.Forms.GroupBox gbEnv;
        private System.Windows.Forms.TextBox tbUName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.TextBox tbDisc;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox textBox2;
    }
}

