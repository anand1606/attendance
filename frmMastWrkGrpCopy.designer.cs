﻿namespace Attendance.Forms
{
    partial class frmMastWrkGrpCopy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCompName = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompCode = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtWrkGrpCode = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpUserRights = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCopyFromWrkGrp = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWrkGrpCode.Properties)).BeginInit();
            this.grpUserRights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCopyFromWrkGrp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCopyFromWrkGrp);
            this.groupBox1.Controls.Add(this.txtCompName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCompCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtWrkGrpCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(150, 16);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Properties.ReadOnly = true;
            this.txtCompName.Size = new System.Drawing.Size(180, 20);
            this.txtCompName.TabIndex = 1;
            this.txtCompName.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "CompCode";
            // 
            // txtCompCode
            // 
            this.txtCompCode.Location = new System.Drawing.Point(102, 16);
            this.txtCompCode.Name = "txtCompCode";
            this.txtCompCode.Size = new System.Drawing.Size(42, 20);
            this.txtCompCode.TabIndex = 0;
            this.txtCompCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompCode_KeyDown);
            this.txtCompCode.Validated += new System.EventHandler(this.txtCompCode_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "New WrkGrp";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(102, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Mask.EditMask = "\\p{Lu}+";
            this.txtDescription.Properties.Mask.ShowPlaceHolders = false;
            this.txtDescription.Size = new System.Drawing.Size(228, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtWrkGrpCode
            // 
            this.txtWrkGrpCode.Location = new System.Drawing.Point(102, 44);
            this.txtWrkGrpCode.Name = "txtWrkGrpCode";
            this.txtWrkGrpCode.Properties.Mask.EditMask = "\\w{3,10}";
            this.txtWrkGrpCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtWrkGrpCode.Properties.Mask.ShowPlaceHolders = false;
            this.txtWrkGrpCode.Size = new System.Drawing.Size(228, 20);
            this.txtWrkGrpCode.TabIndex = 2;
            this.txtWrkGrpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWrkGrpCode_KeyDown);
            this.txtWrkGrpCode.Validated += new System.EventHandler(this.txtWrkGrpCode_Validated);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAdd.Location = new System.Drawing.Point(6, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "C&reate";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpUserRights
            // 
            this.grpUserRights.Controls.Add(this.btnClose);
            this.grpUserRights.Controls.Add(this.btnCancel);
            this.grpUserRights.Controls.Add(this.btnAdd);
            this.grpUserRights.Location = new System.Drawing.Point(8, 224);
            this.grpUserRights.Name = "grpUserRights";
            this.grpUserRights.Size = new System.Drawing.Size(410, 52);
            this.grpUserRights.TabIndex = 2;
            this.grpUserRights.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Cornsilk;
            this.btnClose.Location = new System.Drawing.Point(329, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Clos&e";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCancel.Location = new System.Drawing.Point(249, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Copy From WrkGrp";
            // 
            // txtCopyFromWrkGrp
            // 
            this.txtCopyFromWrkGrp.Location = new System.Drawing.Point(150, 96);
            this.txtCopyFromWrkGrp.Name = "txtCopyFromWrkGrp";
            this.txtCopyFromWrkGrp.Properties.Mask.EditMask = "\\w{3,10}";
            this.txtCopyFromWrkGrp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCopyFromWrkGrp.Properties.Mask.ShowPlaceHolders = false;
            this.txtCopyFromWrkGrp.Properties.ReadOnly = true;
            this.txtCopyFromWrkGrp.Size = new System.Drawing.Size(180, 20);
            this.txtCopyFromWrkGrp.TabIndex = 9;
            this.txtCopyFromWrkGrp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopyFromWrkGrp_KeyDown);
            this.txtCopyFromWrkGrp.Validated += new System.EventHandler(this.txtCopyFromWrkGrp_Validated);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 66);
            this.label5.TabIndex = 11;
            this.label5.Text = "This utility create copy of specified wrkgrp with all realted masters (Dept/Stati" +
    "on/Section/Cat/Desg/Grade/EmpType/LeaveType/Units) With WrkGrp Special Rights";
            // 
            // frmMastWrkGrpCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 288);
            this.Controls.Add(this.grpUserRights);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMastWrkGrpCopy";
            this.Text = "WorkGrp Copier";
            this.Load += new System.EventHandler(this.frmMastWrkGrpCopy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWrkGrpCode.Properties)).EndInit();
            this.grpUserRights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCopyFromWrkGrp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtWrkGrpCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtCompCode;
        private DevExpress.XtraEditors.TextEdit txtCompName;
        private System.Windows.Forms.GroupBox grpUserRights;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtCopyFromWrkGrp;
        private System.Windows.Forms.Label label5;
    }
}