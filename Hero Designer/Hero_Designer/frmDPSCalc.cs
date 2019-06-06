﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Base.Display;
using Base.Master_Classes;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using midsControls;

namespace Hero_Designer
{

    public partial class frmDPSCalc : Form
    {
    
        internal virtual CheckBox chkSortByLevel
        {
            get
            {
                return this._chkSortByLevel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.chkSortByLevel_CheckedChanged);
                if (this._chkSortByLevel != null)
                {
                    this._chkSortByLevel.CheckedChanged -= eventHandler;
                }
                this._chkSortByLevel = value;
                if (this._chkSortByLevel != null)
                {
                    this._chkSortByLevel.CheckedChanged += eventHandler;
                }
            }
        }
        internal virtual CheckBox chkDamageBuffs
        {
            get
            {
                return this._chkDamageBuffs;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkDamageBuffs = value;
            }
        }
        internal virtual ColumnHeader chPower
        {
            get
            {
                return this._chPower;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chPower = value;
            }
        }
        internal virtual ColumnHeader chDPA
        {
            get
            {
                return this._chDPA;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chDPA = value;
            }
        }
        internal virtual ColumnHeader chDamage
        {
            get
            {
                return this._chDamage;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chDamage = value;
            }
        }
        internal virtual ColumnHeader chRecharge
        {
            get
            {
                return this._chRecharge;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chRecharge = value;
            }
        }
        internal virtual ColumnHeader chAnimation
        {
            get
            {
                return this._chAnimation;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chAnimation = value;
            }
        }
        internal virtual ColumnHeader chEndurance
        {
            get
            {
                return this._chEndurance;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chEndurance = value;
            }
        }
        internal virtual ColumnHeader chDamageBuff
        {
            get
            {
                return this._chDamageBuff;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chDamageBuff = value;
            }
        }
        internal virtual ColumnHeader chResistanceDebuff
        {
            get
            {
                return this._chResistanceDebuff;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chResistanceDebuff = value;
            }
        }
        internal virtual ColumnHeader chBuildID
        {
            get
            {
                return this._chBuildID;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chBuildID = value;
            }
        }
        internal virtual ImageButton ibClear
        {
            get
            {
                return this._ibClear;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.ibClear_ButtonClicked);
                if (this._ibClear != null)
                {
                    this._ibClear.ButtonClicked -= clickedEventHandler;
                }
                this._ibClear = value;
                if (this._ibClear != null)
                {
                    this._ibClear.ButtonClicked += clickedEventHandler;
                }
            }
        }
        internal virtual ImageButton ibClose
        {
            get
            {
                return this._ibClose;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.ibClose_ButtonClicked);
                if (this._ibClose != null)
                {
                    this._ibClose.ButtonClicked -= clickedEventHandler;
                }
                this._ibClose = value;
                if (this._ibClose != null)
                {
                    this._ibClose.ButtonClicked += clickedEventHandler;
                }
            }
        }
        internal virtual ImageButton ibAutoMode
        {
            get
            {
                return this._ibAutoMode;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.ibAutoMode_ButtonClicked);
                if (this._ibAutoMode != null)
                {
                    this._ibAutoMode.ButtonClicked -= clickedEventHandler;
                }
                this._ibAutoMode = value;
                if (this._ibAutoMode != null)
                {
                    this._ibAutoMode.ButtonClicked += clickedEventHandler;
                }
            }
        }
        internal virtual ImageButton ibTopmost
        {
            get
            {
                return this._ibTopmost;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.ibTopmost_ButtonClicked);
                if (this._ibTopmost != null)
                {
                    this._ibTopmost.ButtonClicked -= clickedEventHandler;
                }
                this._ibTopmost = value;
                if (this._ibTopmost != null)
                {
                    this._ibTopmost.ButtonClicked += clickedEventHandler;
                }
            }
        }
        internal virtual ImageList ilAttackChain
        {
            get
            {
                return this._ilAttackChain;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ilAttackChain = value;
            }
        }
        internal virtual Label lblHeader
        {
            get
            {
                return this._lblHeader;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblHeader = value;
            }
        }
        internal virtual Label lblDPS
        {
            get
            {
                return this._lblDPS;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDPS = value;
            }
        }
        internal virtual Label lblEPS
        {
            get
            {
                return this._lblEPS;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblEPS = value;
            }
        }
        internal virtual Label lblDPSNum
        {
            get
            {
                return this._lblDPSNum;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDPSNum = value;
            }
        }
        internal virtual Label lblEPSNum
        {
            get
            {
                return this._lblEPSNum;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblEPSNum = value;
            }
        }
        internal virtual TextBox tbDPSOutput
        {
            get
            {
                return this._tbDPSOutput;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tbDPSOutput = value;
            }
        }
        internal virtual ListView lvPower
        {
            get
            {
                return this._lvPower;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.lvPower_MouseEnter);
                ItemCheckedEventHandler checkedEventHandler = new ItemCheckedEventHandler(this.lvPower_ItemChecked);
                ListViewItemSelectionChangedEventHandler changedEventHandler = new ListViewItemSelectionChangedEventHandler(this.lvPower_Clicked);
                if (this._lvPower != null)
                {
                    this._lvPower.MouseEnter -= eventHandler;
                    this._lvPower.ItemChecked -= checkedEventHandler;
                    this._lvPower.ItemSelectionChanged -= changedEventHandler;
                }
                this._lvPower = value;
                if (this._lvPower != null)
                {
                    this._lvPower.MouseEnter += eventHandler;
                    this._lvPower.ItemChecked += checkedEventHandler;
                    this._lvPower.ItemSelectionChanged += changedEventHandler;
                }
            }
        }
        internal virtual Panel Panel1
        {
            get
            {
                return this._Panel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Panel1 = value;
            }
        }
        internal virtual Panel Panel2
        {
            get
            {
                return this._Panel2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Panel2 = value;
            }
        }
        internal virtual ToolTip ToolTip1
        {
            get
            {
                return this._ToolTip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolTip1 = value;
            }
        }
        public frmDPSCalc(frmMain iParent)
        {
            base.FormClosed += this.frmDPSCalc_FormClosed;
            base.Load += this.frmDPSCalc_Load;
            this.Loading = true;
            this.InitializeComponent();
            this.myParent = iParent;
            this.bxRecipe = new ExtendedBitmap(I9Gfx.GetRecipeName());
        }
        void chkRecipe_CheckedChanged(object sender, EventArgs e)
        {
        }
        void chkSortByLevel_CheckedChanged(object sender, EventArgs e)
        {
            this.FillPowerList();
        }
        void FillAttackChainWindow(frmDPSCalc.PowerList[] AttackChain)
        {
            int index;
            if (this.chkSortByLevel.Checked)
            {
                index = 0;
                while (AttackChain[index].DPA != 0f)
                {
                    string[] strArray = AttackChain[index].PowerName.Split(new char[]
                    {
                        '-'
                    });
                    AttackChain[index].PowerName = strArray[1];
                    index++;
                }
            }
            string str = AttackChain[0].PowerName;
            float damage = AttackChain[0].Damage;
            float endurance = AttackChain[0].Endurance;
            float animation = AttackChain[0].Animation;
            index = 1;
            while (AttackChain[index].DPA != 0f)
            {
                str += " --> ";
                str += AttackChain[index].PowerName;
                damage += AttackChain[index].Damage;
                animation += AttackChain[index].Animation;
                endurance += AttackChain[index].Endurance;
                index++;
            }
            this.lblDPSNum.Text = (damage / animation).ToString();
            this.lblEPSNum.Text = (endurance / animation).ToString();
            this.tbDPSOutput.Text = str;
        }
        void FillPowerList()
        {
            this.GlobalDamageBuff = 0f;
            this.lvPower.BeginUpdate();
            this.lvPower.Items.Clear();
            this.lvPower.Sorting = SortOrder.None;
            this.lvPower.Items.Add(" - All Powers - ");
            this.lvPower.Items[this.lvPower.Items.Count - 1].Tag = -1;
            int num = MidsContext.Character.CurrentBuild.Powers.Count - 1;
            for (int powerLocation = 0; powerLocation <= num; powerLocation++)
            {
                if (MidsContext.Character.CurrentBuild.Powers[powerLocation].NIDPower > -1)
                {
                    bool flag = false;
                    if (MidsContext.Character.CurrentBuild.Powers[powerLocation].Power.DisplayName == "Rest")
                    {
                        flag = true;
                    }
                    int index = 0;
                    while (index < MidsContext.Character.CurrentBuild.Powers[powerLocation].Power.Effects.Length && !flag)
                    {
                        if (MidsContext.Character.CurrentBuild.Powers[powerLocation].Power.Effects[index].EffectType == Enums.eEffectType.Damage || (MidsContext.Character.CurrentBuild.Powers[powerLocation].Power.Effects[index].EffectType == Enums.eEffectType.Resistance && MidsContext.Character.CurrentBuild.Powers[powerLocation].Power.Effects[index].MagPercent < 0f) || (MidsContext.Character.CurrentBuild.Powers[powerLocation].Power.Effects[index].EffectType == Enums.eEffectType.DamageBuff && MidsContext.Character.CurrentBuild.Powers[powerLocation].Power.Effects[index].Mag > 0f && !MidsContext.Character.CurrentBuild.Powers[powerLocation].StatInclude) || MidsContext.Character.CurrentBuild.Powers[powerLocation].Power.Effects[index].EffectType == Enums.eEffectType.EntCreate)
                        {
                            string text = DatabaseAPI.Database.Power[MidsContext.Character.CurrentBuild.Powers[powerLocation].NIDPower].DisplayName;
                            if (this.chkSortByLevel.Checked)
                            {
                                text = Strings.Format(MidsContext.Character.CurrentBuild.Powers[powerLocation].Level + 1, "00") + " - " + text;
                            }
                            string[] damageData = this.GetDamageData(powerLocation);
                            this.lvPower.Items.Add(text).SubItems.AddRange(damageData);
                            this.GlobalDamageBuff += float.Parse(damageData[5]) * (MidsContext.Character.CurrentBuild.Powers[powerLocation].Power.Effects[index].Duration / float.Parse(damageData[2]));
                            this.lvPower.Items[this.lvPower.Items.Count - 1].Tag = powerLocation;
                            flag = true;
                        }
                        index++;
                    }
                }
            }
            this.lvPower.Sorting = SortOrder.Ascending;
            this.lvPower.Sort();
            if (this.lvPower.Items.Count > 0)
            {
                this.lvPower.Items[0].Selected = true;
                this.lvPower.Items[0].Checked = true;
            }
            this.lvPower.EndUpdate();
        }
        void frmDPSCalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.StoreLocation();
            this.myParent.FloatDPSCalc(false);
        }
        void frmDPSCalc_Load(object sender, EventArgs e)
        {
            this.ibClose.IA = this.myParent.Drawing.pImageAttributes;
            this.ibClose.ImageOff = this.myParent.Drawing.bxPower[2].Bitmap;
            this.ibClose.ImageOn = this.myParent.Drawing.bxPower[3].Bitmap;
            this.ibTopmost.IA = this.myParent.Drawing.pImageAttributes;
            this.ibTopmost.ImageOff = this.myParent.Drawing.bxPower[2].Bitmap;
            this.ibTopmost.ImageOn = this.myParent.Drawing.bxPower[3].Bitmap;
            this.Loading = false;
        }
        void ibClear_ButtonClicked()
        {
            this.ibClear.Checked = true;
            for (int index = 1; index < this.lvPower.Items.Count; index++)
            {
                this.lvPower.Items[index].Checked = false;
            }
            this.lvPower.Items[0].Checked = true;
            this.lvPower.Items[0].Selected = true;
            this.GlobalPowerList = new frmDPSCalc.PowerList[0];
            this.tbDPSOutput.Text = "";
            this.lblDPSNum.Text = " - Null - ";
            this.lblEPSNum.Text = " - Null - ";
            this.ibClear.Checked = false;
            this.lblHeader.ForeColor = Color.FromArgb(192, 192, 255);
            this.lblHeader.Text = "You may select -All Powers- or just the powers you want to consider.";
            if (this.ibAutoMode.TextOff == "Automagical")
            {
                this.CalculateDPS();
            }
        }
        void ibClose_ButtonClicked()
        {
            base.Close();
        }
        void ibAutoMode_ButtonClicked()
        {
            if (this.ibAutoMode.TextOff == "Automagical")
            {
                this.ToolTip1.SetToolTip(this.ibAutoMode, "Click to enable Automagical Mode");
                this.ibAutoMode.TextOff = "Manual";
                this.lvPower.Items[0].Selected = true;
                if (this.GlobalPowerList.Length > 0)
                {
                    string powerName2;
                    if (!this.chkSortByLevel.Checked)
                    {
                        powerName2 = this.GlobalPowerList[0].PowerName;
                    }
                    else
                    {
                        string[] array = this.GlobalPowerList[0].PowerName.Split(new char[]
                        {
                            '-'
                        });
                        powerName2 = array[1];
                    }
                    this.tbDPSOutput.Text = powerName2;
                    for (int num = 1; num < this.GlobalPowerList.Length; num++)
                    {
                        if (!this.chkSortByLevel.Checked)
                        {
                            powerName2 = this.GlobalPowerList[num].PowerName;
                        }
                        else
                        {
                            string[] array = this.GlobalPowerList[num].PowerName.Split(new char[]
                            {
                                '-'
                            });
                            powerName2 = array[1];
                        }
                        TextBox tbDpsOutput = this.tbDPSOutput;
                        tbDpsOutput.Text = tbDpsOutput.Text + " --> " + powerName2;
                    }
                }
                else
                {
                    this.ibClear_ButtonClicked();
                }
                for (int num = 1; num < this.GlobalPowerList.Length; num++)
                {
                }
            }
            else
            {
                this.ibAutoMode.TextOff = "Automagical";
                this.ToolTip1.SetToolTip(this.ibAutoMode, "Click to enable Manual Mode");
            }
            this.CalculateDPS();
        }
        void ibTopmost_ButtonClicked()
        {
            base.TopMost = this.ibTopmost.Checked;
            if (base.TopMost)
            {
                base.BringToFront();
            }
        }
        void lvPower_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Index == 0)
            {
                if (Operators.ConditionalCompareObjectLess(e.Item.Tag, 0, false) && e.Item.Checked)
                {
                    int num = this.lvPower.Items.Count - 1;
                    for (int index = 1; index <= num; index++)
                    {
                        this.lvPower.Items[index].Checked = false;
                    }
                }
            }
            else if (e.Item.Checked)
            {
                this.lvPower.Items[0].Checked = false;
            }
            this.CalculateDPS();
        }
        void lvPower_Clicked(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.ibAutoMode.TextOff == "Manual" && e.Item.Index != 0 && e.Item.Selected)
            {
                e.Item.Checked = true;
                frmDPSCalc.PowerList[] globalPowerList = this.GlobalPowerList;
                this.GlobalPowerList = new frmDPSCalc.PowerList[globalPowerList.Length + 1];
                for (int index = 0; index < globalPowerList.Length; index++)
                {
                    this.GlobalPowerList[index] = globalPowerList[index];
                }
                this.GlobalPowerList[this.GlobalPowerList.Length - 1].PowerName = e.Item.Text;
                string text;
                if (!this.chkSortByLevel.Checked)
                {
                    text = e.Item.Text;
                }
                else
                {
                    string[] array = e.Item.Text.Split(new char[]
                    {
                        '-'
                    });
                    text = array[1];
                }
                if (this.tbDPSOutput.Text == "")
                {
                    this.tbDPSOutput.Text = text;
                }
                else
                {
                    TextBox tbDpsOutput = this.tbDPSOutput;
                    tbDpsOutput.Text = tbDpsOutput.Text + " -->" + text;
                }
                if (e.Item.SubItems[2].Text != "-")
                {
                    this.GlobalPowerList[this.GlobalPowerList.Length - 1].Damage = float.Parse(e.Item.SubItems[2].Text);
                }
                else
                {
                    this.GlobalPowerList[this.GlobalPowerList.Length - 1].Damage = 0f;
                }
                this.GlobalPowerList[this.GlobalPowerList.Length - 1].Endurance = float.Parse(e.Item.SubItems[5].Text);
                this.GlobalPowerList[this.GlobalPowerList.Length - 1].Recharge = float.Parse(e.Item.SubItems[3].Text);
                this.GlobalPowerList[this.GlobalPowerList.Length - 1].DamageBuff = float.Parse(e.Item.SubItems[6].Text);
                this.GlobalPowerList[this.GlobalPowerList.Length - 1].ResistanceDeBuff = float.Parse(e.Item.SubItems[7].Text);
                this.GlobalPowerList[this.GlobalPowerList.Length - 1].Animation = float.Parse(e.Item.SubItems[4].Text);
                this.GlobalPowerList[this.GlobalPowerList.Length - 1].RechargeTimer = 0f;
            }
            this.CalculateDPS();
        }
        void lvPower_MouseEnter(object sender, EventArgs e)
        {
            this.lvPower.Focus();
        }
        static void putInList(ref frmDPSCalc.CountingList[] tl, string item)
        {
            int num = tl.Length - 1;
            for (int index = 0; index <= num; index++)
            {
                if (tl[index].Text == item)
                {
                    frmDPSCalc.CountingList[] array = tl;
                    int num2 = index;
                    array[num2].Count = array[num2].Count + 1;
                    return;
                }
            }
            tl = (frmDPSCalc.CountingList[])Utils.CopyArray(tl, new frmDPSCalc.CountingList[tl.Length + 1]);
            tl[tl.Length - 1].Count = 1;
            tl[tl.Length - 1].Text = item;
        }
        public void SetLocation()
        {
            Rectangle rectangle = default(Rectangle);
            rectangle.X = MainModule.MidsController.SzFrmRecipe.X;
            rectangle.Y = MainModule.MidsController.SzFrmRecipe.Y;
            rectangle.Width = 800;
            rectangle.Height = MainModule.MidsController.SzFrmRecipe.Height;
            if (rectangle.Width < 1)
            {
                rectangle.Width = base.Width;
            }
            if (rectangle.Height < 1)
            {
                rectangle.Height = base.Height;
            }
            if (rectangle.Width < this.MinimumSize.Width)
            {
                rectangle.Width = this.MinimumSize.Width;
            }
            if (rectangle.Height < this.MinimumSize.Height)
            {
                rectangle.Height = this.MinimumSize.Height;
            }
            if (rectangle.X < 1)
            {
                rectangle.X = (int)Math.Round((double)(Screen.PrimaryScreen.Bounds.Width - base.Width) / 2.0);
            }
            if (rectangle.Y < 32)
            {
                rectangle.Y = (int)Math.Round((double)(Screen.PrimaryScreen.Bounds.Height - base.Height) / 2.0);
            }
            base.Top = rectangle.Y;
            base.Left = rectangle.X;
            base.Height = rectangle.Height;
            base.Width = rectangle.Width;
        }
        void StoreLocation()
        {
            if (MainModule.MidsController.IsAppInitialized)
            {
                MainModule.MidsController.SzFrmRecipe.X = base.Left;
                MainModule.MidsController.SzFrmRecipe.Y = base.Top;
                MainModule.MidsController.SzFrmRecipe.Width = base.Width;
                MainModule.MidsController.SzFrmRecipe.Height = base.Height;
            }
        }
        public void UpdateData()
        {
            this.BackColor = this.myParent.BackColor;
            this.ibClose.IA = this.myParent.Drawing.pImageAttributes;
            this.ibClose.ImageOff = this.myParent.Drawing.bxPower[2].Bitmap;
            this.ibClose.ImageOn = this.myParent.Drawing.bxPower[3].Bitmap;
            this.ibTopmost.IA = this.myParent.Drawing.pImageAttributes;
            this.ibTopmost.ImageOff = this.myParent.Drawing.bxPower[2].Bitmap;
            this.ibTopmost.ImageOn = this.myParent.Drawing.bxPower[3].Bitmap;
            this.ibClear.IA = this.myParent.Drawing.pImageAttributes;
            this.ibClear.ImageOff = this.myParent.Drawing.bxPower[2].Bitmap;
            this.ibClear.ImageOn = this.myParent.Drawing.bxPower[3].Bitmap;
            this.ibAutoMode.IA = this.myParent.Drawing.pImageAttributes;
            this.ibAutoMode.ImageOff = this.myParent.Drawing.bxPower[2].Bitmap;
            this.ibAutoMode.ImageOn = this.myParent.Drawing.bxPower[3].Bitmap;
            this.FillPowerList();
        }
        string[] GetDamageData(int powerLocation)
        {
            IPower enhancedPower = MainModule.MidsController.Toon.GetEnhancedPower(powerLocation);
            float damageValue = enhancedPower.FXGetDamageValue();
            float rechargeTime = enhancedPower.RechargeTime;
            float num = (float)(Math.Ceiling((double)(enhancedPower.CastTimeReal / 0.132f)) + 1.0) * 0.132f;
            float endCost = enhancedPower.EndCost;
            Enums.ShortFX effectMag = enhancedPower.GetEffectMag(Enums.eEffectType.DamageBuff, Enums.eToWho.Self, false);
            Enums.ShortFX effectMag2 = enhancedPower.GetEffectMag(Enums.eEffectType.Resistance, Enums.eToWho.Target, false);
            effectMag.Multiply();
            effectMag2.Multiply();
            float num2 = damageValue / num;
            string[] strArray;
            if (damageValue != 0f)
            {
                string[] array = new string[]
                {
                    num2.ToString(),
                    damageValue.ToString(),
                    rechargeTime.ToString(),
                    num.ToString(),
                    endCost.ToString(),
                    effectMag.Sum.ToString(),
                    effectMag2.Sum.ToString(),
                    powerLocation.ToString()
                };
                strArray = array;
            }
            else
            {
                string[] array = new string[]
                {
                    "-",
                    "-",
                    rechargeTime.ToString(),
                    num.ToString(),
                    endCost.ToString(),
                    effectMag.Sum.ToString(),
                    effectMag2.Sum.ToString(),
                    powerLocation.ToString()
                };
                strArray = array;
            }
            return strArray;
        }
        void lvPower_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.lvPower.Sort();
        }
        frmDPSCalc.PowerList[] IncrementRecharge(frmDPSCalc.PowerList[] List, float Time)
        {
            for (int index = 0; index < List.Length; index++)
            {
                int index2 = index;
                List[index2].RechargeTimer = List[index2].RechargeTimer - Time;
            }
            return List;
        }
        void CalculateDPS()
        {
            if (this.ibAutoMode.TextOff == "Automagical")
            {
                frmDPSCalc.PowerList[] array = new frmDPSCalc.PowerList[this.lvPower.Items.Count - 1];
                int length = 0;
                for (int index = 1; index < this.lvPower.Items.Count; index++)
                {
                    if (this.lvPower.Items[0].Checked || this.lvPower.Items[index].Checked)
                    {
                        array[length].PowerName = this.lvPower.Items[index].Text;
                        if (this.lvPower.Items[index].SubItems[1].Text != "-")
                        {
                            array[length].Damage = float.Parse(this.lvPower.Items[index].SubItems[2].Text);
                            if (!this.chkDamageBuffs.Checked)
                            {
                                IPower basePower = MainModule.MidsController.Toon.GetBasePower(int.Parse(this.lvPower.Items[index].SubItems[8].Text), -1);
                                frmDPSCalc.PowerList[] array2 = array;
                                int num9 = length;
                                array2[num9].Damage = array2[num9].Damage + basePower.FXGetDamageValue() * (this.GlobalDamageBuff / 100f);
                            }
                            array[length].DPA = float.Parse(this.lvPower.Items[index].SubItems[1].Text);
                            array[length].HidenDPA = float.Parse(this.lvPower.Items[index].SubItems[1].Text);
                        }
                        array[length].Recharge = float.Parse(this.lvPower.Items[index].SubItems[3].Text);
                        array[length].Animation = float.Parse(this.lvPower.Items[index].SubItems[4].Text);
                        array[length].Endurance = float.Parse(this.lvPower.Items[index].SubItems[5].Text);
                        array[length].DamageBuff = float.Parse(this.lvPower.Items[index].SubItems[6].Text);
                        array[length].ResistanceDeBuff = float.Parse(this.lvPower.Items[index].SubItems[7].Text);
                        array[length].RechargeTimer = -1f;
                        if (array[length].DamageBuff > 0f && array[length].DPA != 0f)
                        {
                            IPower basePower = MainModule.MidsController.Toon.GetBasePower(int.Parse(this.lvPower.Items[index].SubItems[8].Text), -1);
                            array[length].HidenDPA = basePower.FXGetDamageValue();
                            array[length].HidenDPA = array[length].HidenDPA * (array[length].DamageBuff / array[length].Recharge) / array[length].Animation;
                        }
                        length++;
                    }
                }
                if (length < this.lvPower.Items.Count - 1)
                {
                    frmDPSCalc.PowerList[] powerListArray = array;
                    array = new frmDPSCalc.PowerList[length];
                    for (int index = 0; index < length; index++)
                    {
                        array[index] = powerListArray[index];
                    }
                }
                if (array.Length > 1)
                {
                    Array.Sort<frmDPSCalc.PowerList>(array, (frmDPSCalc.PowerList x, frmDPSCalc.PowerList y) => x.HidenDPA.CompareTo(y.HidenDPA));
                    float num10 = array[length - 1].Recharge + 5f;
                    float num = num10;
                    int num2 = length - 1;
                    while (num > 0f && num2 > 0)
                    {
                        num -= array[num2--].Animation;
                    }
                    frmDPSCalc.PowerList[] List = new frmDPSCalc.PowerList[length - num2];
                    int num3 = 0;
                    for (int index = 0; index < length - num2; index++)
                    {
                        if (array[length - 1 - index].Recharge <= 20f)
                        {
                            List[num3++] = array[length - 1 - index];
                        }
                    }
                    float num4 = 0f;
                    for (int index = 0; index < List.Length; index++)
                    {
                        if (num4 < List[index].Recharge)
                        {
                            num4 = List[index].Recharge;
                        }
                    }
                    frmDPSCalc.PowerList[] AttackChain = new frmDPSCalc.PowerList[20];
                    int index2 = 1;
                    int index3 = 1;
                    AttackChain[0] = List[0];
                    float animation = AttackChain[0].Animation;
                    List[0].RechargeTimer = List[0].Recharge;
                    while (animation < num4 + 1f)
                    {
                        for (int index = index2; index >= 0; index--)
                        {
                            if (index2 >= List.Length)
                            {
                                animation += 0.01f;
                                List = this.IncrementRecharge(List, 0.01f);
                            }
                            else if (List[index].RechargeTimer <= 0f)
                            {
                                index2 = index;
                            }
                        }
                        if (index2 >= List.Length)
                        {
                            index2--;
                            animation += 0.01f;
                            List = this.IncrementRecharge(List, 0.01f);
                        }
                        while (List[index2].RechargeTimer > 0f)
                        {
                            index2++;
                            if (index2 >= List.Length)
                            {
                                index2 = 0;
                                animation += 0.01f;
                                List = this.IncrementRecharge(List, 0.01f);
                            }
                        }
                        AttackChain[index3] = List[index2];
                        animation += AttackChain[index3].Animation;
                        List = this.IncrementRecharge(List, AttackChain[index3].Animation);
                        List[index2].RechargeTimer = List[index2].Recharge;
                        index2++;
                        index3++;
                    }
                    this.FillAttackChainWindow(AttackChain);
                }
                else if (array.Length == 1)
                {
                    this.tbDPSOutput.Text = "You cannot make an attack chain from one attack";
                }
                else
                {
                    this.tbDPSOutput.Text = "Come on Kiddo, gotta pick something :)";
                }
            }
            else
            {
                float num5 = 0f;
                float num6 = 0f;
                float num7 = 0f;
                bool flag = true;
                for (int index = 0; index < this.GlobalPowerList.Length; index++)
                {
                    if (this.GlobalPowerList[index].Damage > 0f)
                    {
                        num5 += this.GlobalPowerList[index].Damage;
                        num6 += this.GlobalPowerList[index].Endurance;
                        num7 += this.GlobalPowerList[index].Animation;
                        this.GlobalPowerList[index].RechargeTimer = this.GlobalPowerList[index].Recharge;
                    }
                    float animation = this.GlobalPowerList[index].Animation;
                }
                frmDPSCalc.PowerList[] powerListArray2 = new frmDPSCalc.PowerList[this.GlobalPowerList.Length * 2];
                int num8 = 0;
                for (int index = 0; index < powerListArray2.Length; index++)
                {
                    if (index > this.GlobalPowerList.Length - 1)
                    {
                        num8 = index - (this.GlobalPowerList.Length - 1) - 1;
                    }
                    powerListArray2[index] = this.GlobalPowerList[num8++];
                }
                for (int index = 0; index < powerListArray2.Length; index++)
                {
                    for (int index4 = index + 1; index4 < powerListArray2.Length; index4++)
                    {
                        if (powerListArray2[index].PowerName != powerListArray2[index4].PowerName)
                        {
                            frmDPSCalc.PowerList[] array3 = powerListArray2;
                            int num11 = index;
                            array3[num11].RechargeTimer = array3[num11].RechargeTimer - powerListArray2[index4].Animation;
                        }
                        else if (powerListArray2[index].RechargeTimer > 0f)
                        {
                            flag = false;
                        }
                    }
                }
                for (int index = powerListArray2.Length - 1; index >= 0; index--)
                {
                    for (int index4 = index - 1; index4 >= 0; index4--)
                    {
                        if (powerListArray2[index].PowerName != powerListArray2[index4].PowerName)
                        {
                            frmDPSCalc.PowerList[] array4 = powerListArray2;
                            int num12 = index;
                            array4[num12].RechargeTimer = array4[num12].RechargeTimer - powerListArray2[index4].Animation;
                        }
                        else if (powerListArray2[index].RechargeTimer > 0f)
                        {
                            flag = false;
                        }
                    }
                }
                if (!flag)
                {
                    this.lblHeader.ForeColor = Color.Red;
                    this.lblHeader.Text = "Impossible Chain";
                }
                else
                {
                    this.lblHeader.ForeColor = Color.FromArgb(192, 192, 255);
                    this.lblHeader.Text = "You may select -All Powers- or just the powers you want to consider.";
                }
                this.lblDPSNum.Text = (num5 / num7).ToString();
                this.lblEPSNum.Text = (num6 / num7).ToString();
            }
        }
        [AccessedThroughProperty("chkSortByLevel")]
        CheckBox _chkSortByLevel;
        [AccessedThroughProperty("chkDamageBuffs")]
        CheckBox _chkDamageBuffs;
        [AccessedThroughProperty("chPower")]
        ColumnHeader _chPower;
        [AccessedThroughProperty("chDPA")]
        ColumnHeader _chDPA;
        [AccessedThroughProperty("chDamage")]
        ColumnHeader _chDamage;
        [AccessedThroughProperty("chRecharge")]
        ColumnHeader _chRecharge;
        [AccessedThroughProperty("chAnimation")]
        ColumnHeader _chAnimation;
        [AccessedThroughProperty("chEndurance")]
        ColumnHeader _chEndurance;
        [AccessedThroughProperty("chDamageBuff")]
        ColumnHeader _chDamageBuff;
        [AccessedThroughProperty("chResistanceDebuff")]
        ColumnHeader _chResistanceDebuff;
        [AccessedThroughProperty("chBuildID")]
        ColumnHeader _chBuildID;
        [AccessedThroughProperty("ibClear")]
        ImageButton _ibClear;
        [AccessedThroughProperty("ibClose")]
        ImageButton _ibClose;
        [AccessedThroughProperty("ibAutoMode")]
        ImageButton _ibAutoMode;
        [AccessedThroughProperty("ibTopmost")]
        ImageButton _ibTopmost;
        [AccessedThroughProperty("ilAttackChain")]
        ImageList _ilAttackChain;
        [AccessedThroughProperty("lblHeader")]
        Label _lblHeader;
        [AccessedThroughProperty("lblDPS")]
        Label _lblDPS;
        [AccessedThroughProperty("lblEPS")]
        Label _lblEPS;
        [AccessedThroughProperty("lblDPSNum")]
        Label _lblDPSNum;
        [AccessedThroughProperty("lblEPSNum")]
        Label _lblEPSNum;
        [AccessedThroughProperty("tbDPSOutput")]
        TextBox _tbDPSOutput;
        [AccessedThroughProperty("lvPower")]
        ListView _lvPower;
        [AccessedThroughProperty("Panel1")]
        Panel _Panel1;
        [AccessedThroughProperty("Panel2")]
        Panel _Panel2;
        [AccessedThroughProperty("ToolTip1")]
        ToolTip _ToolTip1;
        protected ExtendedBitmap bxRecipe;
        protected bool Loading;
        protected frmMain myParent;
        float GlobalDamageBuff;
        struct CountingList
        {

            public string Text;
            public int Count;
        }
        public struct PowerList
        {

            public string PowerName;
            public float baseDamage;
            public float Damage;
            public float DPA;
            public float HidenDPA;
            public float Recharge;
            public float Animation;
            public float Endurance;
            public float DamageBuff;
            public float ResistanceDeBuff;
            public float RechargeTimer;
        }
    }
}
