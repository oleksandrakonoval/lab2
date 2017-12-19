﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhone;

namespace MobilePhomeWFA
{
    public partial class Form1 : Form
    {
        SimCorpMobile MyMobile;
      
        private IOutput output;

        public Form1()
        {
            InitializeComponent();
            MyMobile = new MobilePhone.SimCorpMobile();
            
                
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            output = new WFAOutput(textBox1);

            MyMobile.PlaybackComponent = HeadsetFactory.GetPlayback((headsetTypik)checkedListBox1.SelectedIndex, output);
            MyMobile.PlaybackComponent.Play(textBox1);

            MyMobile.SimCardItem = SimCardFactory.GetSimCard((SimCardTypeik)checkedListBox2.SelectedIndex, output);
            MyMobile.SimCardItem.Call(textBox1);

            MyMobile.ChargerComponenet = ChargerFactory.GetCharger((ChargerTypik)checkedListBox3.SelectedIndex, output);
            MyMobile.ChargerComponenet.Charge(textBox1);
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
                checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            }
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox2.CheckedItems.Count > 0)
            {
                checkedListBox2.ItemCheck -= checkedListBox2_ItemCheck;
                checkedListBox2.SetItemChecked(checkedListBox2.CheckedIndices[0], false);
                checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            }
        }

        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox3.CheckedItems.Count > 0)
            {
                checkedListBox3.ItemCheck -= checkedListBox3_ItemCheck;
                checkedListBox3.SetItemChecked(checkedListBox3.CheckedIndices[0], false);
                checkedListBox3.ItemCheck += checkedListBox3_ItemCheck;
            }
        }
    }
}
