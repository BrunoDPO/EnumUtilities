using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnumUtilitiesSample
{
    public partial class frmSample : Form
    {
        public frmSample()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the values as a Dictionary
            cbxEnum.DisplayMember = "Value";
            cbxEnum.ValueMember = "Key";
            var dictionary = EnumUtilities<SampleEnum>.GetDictionary(); // It throws an Exception in case of using other ValueTypes
            //var test = EnumUtilities<int>.GetDictionary(); // it is a valid sentence, but at runtime it throws a TypeInitializationException
            cbxEnum.DataSource = new BindingSource(dictionary, null); // ~ Little trick! ~
        }

        private void cbxEnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;

            // Getting info by selecting an item
            var comboItem = (KeyValuePair<SampleEnum, string>)combo.SelectedItem; // SelectedItem is the KeyValuePair used internally
            lblKey.Text = comboItem.Key.ToString();
            lblValue.Text = comboItem.Value;

            // Getting info by enum
            var realValue = (SampleEnum)combo.SelectedValue; // SelectedValue is the actual enum
            lblDescription.Text = realValue.Description();
            lblToString.Text = realValue.ToString();
            lblCastByte.Text = ((byte)realValue).Description(); // ~ Great side-effect on ValueType! ~
        }
    }
}
