﻿
using System.Windows.Forms;

namespace CabinetMgr
{
    partial class FormLatticePermissionManage
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.uiButtonCancel = new Sunny.UI.UIButton();
            this.uiButtonSave = new Sunny.UI.UIButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.uiTreeViewLatticeInfo = new Sunny.UI.UITreeView();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.uiButtonCancel);
            this.panelTop.Controls.Add(this.uiButtonSave);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 35);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1018, 107);
            this.panelTop.TabIndex = 1;
            // 
            // uiButtonCancel
            // 
            this.uiButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonCancel.Location = new System.Drawing.Point(313, 21);
            this.uiButtonCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonCancel.Name = "uiButtonCancel";
            this.uiButtonCancel.Radius = 30;
            this.uiButtonCancel.Size = new System.Drawing.Size(100, 35);
            this.uiButtonCancel.TabIndex = 4;
            this.uiButtonCancel.Text = "取消";
            this.uiButtonCancel.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonCancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonCancel.Click += new System.EventHandler(this.uiButtonCancel_Click);
            // 
            // uiButtonSave
            // 
            this.uiButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonSave.Location = new System.Drawing.Point(107, 21);
            this.uiButtonSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonSave.Name = "uiButtonSave";
            this.uiButtonSave.Radius = 30;
            this.uiButtonSave.Size = new System.Drawing.Size(100, 35);
            this.uiButtonSave.TabIndex = 3;
            this.uiButtonSave.Text = "保存";
            this.uiButtonSave.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonSave.Click += new System.EventHandler(this.uiButtonSave_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.uiTreeViewLatticeInfo);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 142);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1018, 458);
            this.panelBottom.TabIndex = 2;
            // 
            // uiTreeViewLatticeInfo
            // 
            this.uiTreeViewLatticeInfo.CheckBoxes = true;
            this.uiTreeViewLatticeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTreeViewLatticeInfo.FillColor = System.Drawing.Color.White;
            this.uiTreeViewLatticeInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTreeViewLatticeInfo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiTreeViewLatticeInfo.Location = new System.Drawing.Point(0, 0);
            this.uiTreeViewLatticeInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTreeViewLatticeInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTreeViewLatticeInfo.Name = "uiTreeViewLatticeInfo";
            this.uiTreeViewLatticeInfo.ShowLines = true;
            this.uiTreeViewLatticeInfo.ShowText = false;
            this.uiTreeViewLatticeInfo.Size = new System.Drawing.Size(1018, 458);
            this.uiTreeViewLatticeInfo.TabIndex = 0;
            this.uiTreeViewLatticeInfo.Text = "uiTreeViewLatticeInfo";
            this.uiTreeViewLatticeInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTreeViewLatticeInfo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FormLatticePermissionManage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1018, 600);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLatticePermissionManage";
            this.Text = "FormRoleManage";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1018, 1585);
            this.Load += new System.EventHandler(this.FormLatticePermissionManage_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private Sunny.UI.UIButton uiButtonSave;
        private Sunny.UI.UIButton uiButtonCancel;
        private Sunny.UI.UITreeView uiTreeViewLatticeInfo;
    }
}