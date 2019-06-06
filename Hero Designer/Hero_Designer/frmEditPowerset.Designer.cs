﻿namespace Hero_Designer
{

    public partial class frmEditPowerset : global::System.Windows.Forms.Form
    {

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        [global::System.Diagnostics.DebuggerStepThrough]
        void InitializeComponent()
        {
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Hero_Designer.frmEditPowerset));
            this.txtName = new global::System.Windows.Forms.TextBox();
            this.Label1 = new global::System.Windows.Forms.Label();
            this.cbAT = new global::System.Windows.Forms.ComboBox();
            this.Label2 = new global::System.Windows.Forms.Label();
            this.Label3 = new global::System.Windows.Forms.Label();
            this.cbSetType = new global::System.Windows.Forms.ComboBox();
            this.btnIcon = new global::System.Windows.Forms.Button();
            this.picIcon = new global::System.Windows.Forms.PictureBox();
            this.lvPowers = new global::System.Windows.Forms.ListView();
            this.ColumnHeader3 = new global::System.Windows.Forms.ColumnHeader();
            this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
            this.Label4 = new global::System.Windows.Forms.Label();
            this.btnClose = new global::System.Windows.Forms.Button();
            this.btnClearIcon = new global::System.Windows.Forms.Button();
            this.ImagePicker = new global::System.Windows.Forms.OpenFileDialog();
            this.lblNameUnique = new global::System.Windows.Forms.Label();
            this.lblNameFull = new global::System.Windows.Forms.Label();
            this.cbNameGroup = new global::System.Windows.Forms.ComboBox();
            this.Label22 = new global::System.Windows.Forms.Label();
            this.txtNameSet = new global::System.Windows.Forms.TextBox();
            this.Label33 = new global::System.Windows.Forms.Label();
            this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
            this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
            this.btnCancel = new global::System.Windows.Forms.Button();
            this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
            this.txtDesc = new global::System.Windows.Forms.TextBox();
            this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
            this.chkNoTrunk = new global::System.Windows.Forms.CheckBox();
            this.cbTrunkSet = new global::System.Windows.Forms.ComboBox();
            this.cbTrunkGroup = new global::System.Windows.Forms.ComboBox();
            this.Label5 = new global::System.Windows.Forms.Label();
            this.Label31 = new global::System.Windows.Forms.Label();
            this.gbLink = new global::System.Windows.Forms.GroupBox();
            this.chkNoLink = new global::System.Windows.Forms.CheckBox();
            this.cbLinkSet = new global::System.Windows.Forms.ComboBox();
            this.cbLinkGroup = new global::System.Windows.Forms.ComboBox();
            this.Label6 = new global::System.Windows.Forms.Label();
            this.Label7 = new global::System.Windows.Forms.Label();
            this.GroupBox5 = new global::System.Windows.Forms.GroupBox();
            this.lvMutexSets = new global::System.Windows.Forms.ListBox();
            this.Label8 = new global::System.Windows.Forms.Label();
            this.cbMutexGroup = new global::System.Windows.Forms.ComboBox();
            ((global::System.ComponentModel.ISupportInitialize)this.picIcon).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.gbLink.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            base.SuspendLayout();
            global::System.Drawing.Point point = new global::System.Drawing.Point(110, 16);
            this.txtName.Location = point;
            this.txtName.Name = "txtName";
            global::System.Drawing.Size size = new global::System.Drawing.Size(196, 20);
            this.txtName.Size = size;
            this.txtName.TabIndex = 0;
            this.txtName.Text = "TextBox1";
            point = new global::System.Drawing.Point(6, 16);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            size = new global::System.Drawing.Size(100, 20);
            this.Label1.Size = size;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Display Name:";
            this.Label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.cbAT.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            point = new global::System.Drawing.Point(403, 122);
            this.cbAT.Location = point;
            this.cbAT.Name = "cbAT";
            size = new global::System.Drawing.Size(124, 22);
            this.cbAT.Size = size;
            this.cbAT.TabIndex = 2;
            point = new global::System.Drawing.Point(336, 122);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            size = new global::System.Drawing.Size(63, 20);
            this.Label2.Size = size;
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Archetype:";
            this.Label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(336, 150);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            size = new global::System.Drawing.Size(63, 20);
            this.Label3.Size = size;
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Set Type:";
            this.Label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.cbSetType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            point = new global::System.Drawing.Point(403, 150);
            this.cbSetType.Location = point;
            this.cbSetType.Name = "cbSetType";
            size = new global::System.Drawing.Size(124, 22);
            this.cbSetType.Size = size;
            this.cbSetType.TabIndex = 4;
            point = new global::System.Drawing.Point(6, 52);
            this.btnIcon.Location = point;
            this.btnIcon.Name = "btnIcon";
            size = new global::System.Drawing.Size(179, 20);
            this.btnIcon.Size = size;
            this.btnIcon.TabIndex = 6;
            this.btnIcon.Text = "Select Icon";
            this.picIcon.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
            point = new global::System.Drawing.Point(85, 22);
            this.picIcon.Location = point;
            this.picIcon.Name = "picIcon";
            size = new global::System.Drawing.Size(20, 20);
            this.picIcon.Size = size;
            this.picIcon.TabIndex = 7;
            this.picIcon.TabStop = false;
            this.lvPowers.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
            {
                this.ColumnHeader3,
                this.ColumnHeader1,
                this.ColumnHeader2
            });
            this.lvPowers.FullRowSelect = true;
            this.lvPowers.HideSelection = false;
            point = new global::System.Drawing.Point(12, 448);
            this.lvPowers.Location = point;
            this.lvPowers.MultiSelect = false;
            this.lvPowers.Name = "lvPowers";
            size = new global::System.Drawing.Size(515, 121);
            this.lvPowers.Size = size;
            this.lvPowers.TabIndex = 8;
            this.lvPowers.UseCompatibleStateImageBehavior = false;
            this.lvPowers.View = global::System.Windows.Forms.View.Details;
            this.ColumnHeader3.Text = "Level";
            this.ColumnHeader3.Width = 47;
            this.ColumnHeader1.Text = "Power";
            this.ColumnHeader1.Width = 124;
            this.ColumnHeader2.Text = "Short Description";
            this.ColumnHeader2.Width = 313;
            point = new global::System.Drawing.Point(9, 425);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            size = new global::System.Drawing.Size(100, 20);
            this.Label4.Size = size;
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Powers:";
            this.Label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.DialogResult = global::System.Windows.Forms.DialogResult.OK;
            point = new global::System.Drawing.Point(452, 575);
            this.btnClose.Location = point;
            this.btnClose.Name = "btnClose";
            size = new global::System.Drawing.Size(75, 36);
            this.btnClose.Size = size;
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "OK";
            point = new global::System.Drawing.Point(6, 76);
            this.btnClearIcon.Location = point;
            this.btnClearIcon.Name = "btnClearIcon";
            size = new global::System.Drawing.Size(179, 20);
            this.btnClearIcon.Size = size;
            this.btnClearIcon.TabIndex = 16;
            this.btnClearIcon.Text = "Clear Icon";
            this.ImagePicker.Filter = "PNG Images|*.png";
            this.ImagePicker.Title = "Select Image File";
            point = new global::System.Drawing.Point(10, 131);
            this.lblNameUnique.Location = point;
            this.lblNameUnique.Name = "lblNameUnique";
            size = new global::System.Drawing.Size(296, 20);
            this.lblNameUnique.Size = size;
            this.lblNameUnique.TabIndex = 25;
            this.lblNameUnique.Text = "This name is unique.";
            this.lblNameUnique.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameFull.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
            point = new global::System.Drawing.Point(13, 95);
            this.lblNameFull.Location = point;
            this.lblNameFull.Name = "lblNameFull";
            size = new global::System.Drawing.Size(293, 32);
            this.lblNameFull.Size = size;
            this.lblNameFull.TabIndex = 24;
            this.lblNameFull.Text = "Group_Name.Powerset_Name";
            this.lblNameFull.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
            this.cbNameGroup.FormattingEnabled = true;
            point = new global::System.Drawing.Point(110, 44);
            this.cbNameGroup.Location = point;
            this.cbNameGroup.Name = "cbNameGroup";
            size = new global::System.Drawing.Size(196, 22);
            this.cbNameGroup.Size = size;
            this.cbNameGroup.TabIndex = 20;
            point = new global::System.Drawing.Point(10, 44);
            this.Label22.Location = point;
            this.Label22.Name = "Label22";
            size = new global::System.Drawing.Size(96, 20);
            this.Label22.Size = size;
            this.Label22.TabIndex = 22;
            this.Label22.Text = "Group:";
            this.Label22.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(110, 72);
            this.txtNameSet.Location = point;
            this.txtNameSet.Name = "txtNameSet";
            size = new global::System.Drawing.Size(196, 20);
            this.txtNameSet.Size = size;
            this.txtNameSet.TabIndex = 21;
            this.txtNameSet.Text = "PowerName";
            point = new global::System.Drawing.Point(3, 72);
            this.Label33.Location = point;
            this.Label33.Name = "Label33";
            size = new global::System.Drawing.Size(103, 20);
            this.Label33.Size = size;
            this.Label33.TabIndex = 23;
            this.Label33.Text = "Powerset Name:";
            this.Label33.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.GroupBox1.Controls.Add(this.lblNameUnique);
            this.GroupBox1.Controls.Add(this.lblNameFull);
            this.GroupBox1.Controls.Add(this.cbNameGroup);
            this.GroupBox1.Controls.Add(this.Label22);
            this.GroupBox1.Controls.Add(this.txtNameSet);
            this.GroupBox1.Controls.Add(this.Label33);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtName);
            point = new global::System.Drawing.Point(12, 12);
            this.GroupBox1.Location = point;
            this.GroupBox1.Name = "GroupBox1";
            size = new global::System.Drawing.Size(318, 160);
            this.GroupBox1.Size = size;
            this.GroupBox1.TabIndex = 26;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Powerset Name";
            this.GroupBox2.Controls.Add(this.btnClearIcon);
            this.GroupBox2.Controls.Add(this.picIcon);
            this.GroupBox2.Controls.Add(this.btnIcon);
            point = new global::System.Drawing.Point(336, 12);
            this.GroupBox2.Location = point;
            this.GroupBox2.Name = "GroupBox2";
            size = new global::System.Drawing.Size(191, 102);
            this.GroupBox2.Size = size;
            this.GroupBox2.TabIndex = 27;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Icon";
            this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.OK;
            point = new global::System.Drawing.Point(371, 575);
            this.btnCancel.Location = point;
            this.btnCancel.Name = "btnCancel";
            size = new global::System.Drawing.Size(75, 36);
            this.btnCancel.Size = size;
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.GroupBox3.Controls.Add(this.txtDesc);
            point = new global::System.Drawing.Point(12, 178);
            this.GroupBox3.Location = point;
            this.GroupBox3.Name = "GroupBox3";
            size = new global::System.Drawing.Size(515, 80);
            this.GroupBox3.Size = size;
            this.GroupBox3.TabIndex = 29;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Description";
            point = new global::System.Drawing.Point(6, 19);
            this.txtDesc.Location = point;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
            size = new global::System.Drawing.Size(503, 55);
            this.txtDesc.Size = size;
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Text = "TextBox1";
            this.GroupBox4.Controls.Add(this.chkNoTrunk);
            this.GroupBox4.Controls.Add(this.cbTrunkSet);
            this.GroupBox4.Controls.Add(this.cbTrunkGroup);
            this.GroupBox4.Controls.Add(this.Label5);
            this.GroupBox4.Controls.Add(this.Label31);
            point = new global::System.Drawing.Point(12, 264);
            this.GroupBox4.Location = point;
            this.GroupBox4.Name = "GroupBox4";
            size = new global::System.Drawing.Size(515, 75);
            this.GroupBox4.Size = size;
            this.GroupBox4.TabIndex = 30;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Trunk Set:";
            point = new global::System.Drawing.Point(279, 16);
            this.chkNoTrunk.Location = point;
            this.chkNoTrunk.Name = "chkNoTrunk";
            size = new global::System.Drawing.Size(210, 50);
            this.chkNoTrunk.Size = size;
            this.chkNoTrunk.TabIndex = 17;
            this.chkNoTrunk.Text = "This power has no Trunk set";
            this.chkNoTrunk.UseVisualStyleBackColor = true;
            this.cbTrunkSet.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrunkSet.FormattingEnabled = true;
            point = new global::System.Drawing.Point(68, 44);
            this.cbTrunkSet.Location = point;
            this.cbTrunkSet.Name = "cbTrunkSet";
            size = new global::System.Drawing.Size(196, 22);
            this.cbTrunkSet.Size = size;
            this.cbTrunkSet.TabIndex = 14;
            this.cbTrunkGroup.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrunkGroup.FormattingEnabled = true;
            point = new global::System.Drawing.Point(68, 16);
            this.cbTrunkGroup.Location = point;
            this.cbTrunkGroup.Name = "cbTrunkGroup";
            size = new global::System.Drawing.Size(196, 22);
            this.cbTrunkGroup.Size = size;
            this.cbTrunkGroup.TabIndex = 13;
            point = new global::System.Drawing.Point(10, 16);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            size = new global::System.Drawing.Size(54, 20);
            this.Label5.Size = size;
            this.Label5.TabIndex = 15;
            this.Label5.Text = "Group:";
            this.Label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(13, 44);
            this.Label31.Location = point;
            this.Label31.Name = "Label31";
            size = new global::System.Drawing.Size(49, 20);
            this.Label31.Size = size;
            this.Label31.TabIndex = 16;
            this.Label31.Text = "Set:";
            this.Label31.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.gbLink.Controls.Add(this.chkNoLink);
            this.gbLink.Controls.Add(this.cbLinkSet);
            this.gbLink.Controls.Add(this.cbLinkGroup);
            this.gbLink.Controls.Add(this.Label6);
            this.gbLink.Controls.Add(this.Label7);
            point = new global::System.Drawing.Point(12, 345);
            this.gbLink.Location = point;
            this.gbLink.Name = "gbLink";
            size = new global::System.Drawing.Size(515, 75);
            this.gbLink.Size = size;
            this.gbLink.TabIndex = 31;
            this.gbLink.TabStop = false;
            this.gbLink.Text = "Linked Secondary";
            point = new global::System.Drawing.Point(279, 16);
            this.chkNoLink.Location = point;
            this.chkNoLink.Name = "chkNoLink";
            size = new global::System.Drawing.Size(210, 50);
            this.chkNoLink.Size = size;
            this.chkNoLink.TabIndex = 17;
            this.chkNoLink.Text = "No link";
            this.chkNoLink.UseVisualStyleBackColor = true;
            this.cbLinkSet.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLinkSet.FormattingEnabled = true;
            point = new global::System.Drawing.Point(68, 44);
            this.cbLinkSet.Location = point;
            this.cbLinkSet.Name = "cbLinkSet";
            size = new global::System.Drawing.Size(196, 22);
            this.cbLinkSet.Size = size;
            this.cbLinkSet.TabIndex = 14;
            this.cbLinkGroup.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLinkGroup.FormattingEnabled = true;
            point = new global::System.Drawing.Point(68, 16);
            this.cbLinkGroup.Location = point;
            this.cbLinkGroup.Name = "cbLinkGroup";
            size = new global::System.Drawing.Size(196, 22);
            this.cbLinkGroup.Size = size;
            this.cbLinkGroup.TabIndex = 13;
            point = new global::System.Drawing.Point(10, 16);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            size = new global::System.Drawing.Size(54, 20);
            this.Label6.Size = size;
            this.Label6.TabIndex = 15;
            this.Label6.Text = "Group:";
            this.Label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(13, 44);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            size = new global::System.Drawing.Size(49, 20);
            this.Label7.Size = size;
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Set:";
            this.Label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.GroupBox5.Controls.Add(this.lvMutexSets);
            this.GroupBox5.Controls.Add(this.Label8);
            this.GroupBox5.Controls.Add(this.cbMutexGroup);
            point = new global::System.Drawing.Point(533, 12);
            this.GroupBox5.Location = point;
            this.GroupBox5.Name = "GroupBox5";
            size = new global::System.Drawing.Size(253, 327);
            this.GroupBox5.Size = size;
            this.GroupBox5.TabIndex = 32;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Mutually Exclusive Sets";
            this.lvMutexSets.ItemHeight = 14;
            point = new global::System.Drawing.Point(9, 72);
            this.lvMutexSets.Location = point;
            this.lvMutexSets.Name = "lvMutexSets";
            this.lvMutexSets.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiSimple;
            size = new global::System.Drawing.Size(238, 242);
            this.lvMutexSets.Size = size;
            this.lvMutexSets.TabIndex = 111;
            point = new global::System.Drawing.Point(6, 16);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            size = new global::System.Drawing.Size(100, 20);
            this.Label8.Size = size;
            this.Label8.TabIndex = 22;
            this.Label8.Text = "Group (Only one):";
            this.Label8.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.cbMutexGroup.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMutexGroup.FormattingEnabled = true;
            point = new global::System.Drawing.Point(9, 44);
            this.cbMutexGroup.Location = point;
            this.cbMutexGroup.Name = "cbMutexGroup";
            size = new global::System.Drawing.Size(238, 22);
            this.cbMutexGroup.Size = size;
            this.cbMutexGroup.TabIndex = 21;
            size = new global::System.Drawing.Size(5, 13);
            this.AutoScaleBaseSize = size;
            size = new global::System.Drawing.Size(798, 621);
            base.ClientSize = size;
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.gbLink);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.btnCancel);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.btnClose);
            base.Controls.Add(this.Label4);
            base.Controls.Add(this.lvPowers);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.cbSetType);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.cbAT);
            this.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmEditPowerset";
            base.ShowInTaskbar = false;
            base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Powerset (Group_Name.Set_Name)";
            ((global::System.ComponentModel.ISupportInitialize)this.picIcon).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.gbLink.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            base.ResumeLayout(false);
        }
        global::System.ComponentModel.IContainer components;
    }
}
