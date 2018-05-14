﻿namespace IfcExport
{
    partial class FrmExporter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIFC = new System.Windows.Forms.TextBox();
            this.btnBrowseIFC = new System.Windows.Forms.Button();
            this.btnConvertToObj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source BIM File (IFC Format):";
            // 
            // txtIFC
            // 
            this.txtIFC.Location = new System.Drawing.Point(172, 15);
            this.txtIFC.Name = "txtIFC";
            this.txtIFC.Size = new System.Drawing.Size(392, 20);
            this.txtIFC.TabIndex = 1;
            // 
            // btnBrowseIFC
            // 
            this.btnBrowseIFC.Location = new System.Drawing.Point(582, 13);
            this.btnBrowseIFC.Name = "btnBrowseIFC";
            this.btnBrowseIFC.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseIFC.TabIndex = 2;
            this.btnBrowseIFC.Text = "Browse";
            this.btnBrowseIFC.UseVisualStyleBackColor = true;
            this.btnBrowseIFC.Click += new System.EventHandler(this.btnBrowseIFC_Click);
            // 
            // btnConvertToObj
            // 
            this.btnConvertToObj.Location = new System.Drawing.Point(24, 61);
            this.btnConvertToObj.Name = "btnConvertToObj";
            this.btnConvertToObj.Size = new System.Drawing.Size(153, 23);
            this.btnConvertToObj.TabIndex = 3;
            this.btnConvertToObj.Text = "Convert to OBJ";
            this.btnConvertToObj.UseVisualStyleBackColor = true;
            this.btnConvertToObj.Click += new System.EventHandler(this.btnConvertToObj_Click);
            // 
            // FrmExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 204);
            this.Controls.Add(this.btnConvertToObj);
            this.Controls.Add(this.btnBrowseIFC);
            this.Controls.Add(this.txtIFC);
            this.Controls.Add(this.label1);
            this.Name = "FrmExporter";
            this.Text = "IFC Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIFC;
        private System.Windows.Forms.Button btnBrowseIFC;
        private System.Windows.Forms.Button btnConvertToObj;
    }
}
