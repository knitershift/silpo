using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class FormShop : Form
    {
        public FormShop()
        {
            InitializeComponent();
        }

        private void FormShop_Load(object sender, EventArgs e)
        {

            string[] firstHalf = { "1", "name", "country", "producer", };
            string[] secondHalf = { "amount", "suma" };
            ListViewItem lv = new ListViewItem(firstHalf);
            lv.SubItems.Add("price");
            lv.SubItems.AddRange(secondHalf);

             
            lv.SubItems.Add("to buy");
             listView_Product.Items.Add(lv);

            NumericUpDownColumn upDown = new NumericUpDownColumn();

            DataGridViewRow row = new DataGridViewRow();

            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            cell1.Value = '1';
            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
            cell2.Value = "name";
            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
            cell3.Value = "country";
            DataGridViewCell cell4 = new DataGridViewTextBoxCell();
            cell4.Value = "producer";
            DataGridViewCell cell5 = new DataGridViewTextBoxCell();
            cell5.Value = "price";
            DataGridViewCell cell6 = new DataGridViewTextBoxCell();
            cell6.Value = upDown;
            DataGridViewCell cell7 = new DataGridViewTextBoxCell();
            cell7.Value = "price";
            DataGridViewCheckBoxCell checkBox = new DataGridViewCheckBoxCell(false) {
                TrueValue = 1,
                FalseValue = 0
            };

            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            row.Cells.Add(cell3);
            row.Cells.Add(cell4);
            row.Cells.Add(cell5);
            row.Cells.Add(cell6);
            row.Cells.Add(cell7);
            row.Cells.Add(checkBox);

            dataGridView1.Rows.Add(row);

        }
    }

    public class NumericUpDownColumn : DataGridViewColumn
    {
        public NumericUpDownColumn() : base(new NumericUpDownCell())
        {
        }

        public NumericUpDownColumn(DataGridViewCell cell)
            : base(cell)
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get { return base.CellTemplate; }

            set
            {
                // Ensure that the cell used for the template is a NumericUpDownCell.
                if ((value != null) && !value.GetType().IsAssignableFrom(typeof(NumericUpDownCell)))
                {
                    throw new InvalidCastException("Must be a NumericUpDownCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    /// <summary>
    /// An auxilary class to NumericUpDownColumn that carries out the cell editing.
    /// </summary>
    public class NumericUpDownCell : DataGridViewTextBoxCell
    {
        public NumericUpDownCell()
        {
            this.Style.Format = "#";
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            NumericUpDownEditingControl ctl = (NumericUpDownEditingControl)DataGridView.EditingControl;
            ctl.Value = Convert.ToDecimal(this.Value);
        }

        public override Type EditType
        {
            // Return the type of the editing contol that NumericUpDownCell uses.
            get { return typeof(NumericUpDownEditingControl); }
        }

        public override Type ValueType
        {
            // Return the type of the value that NumericUpDownCell contains.
            get { return typeof(int); }
        }

        public override object DefaultNewRowValue
        {
            // Default value for a newly added row in the grid
            get { return 0; }
        }
    }

    /// <summary>
    /// An auxilary class to NumericUpDownColumn that supplies the appropriate overridden interfaces to the normal NumericUpDown control.
    /// </summary>
    class NumericUpDownEditingControl : NumericUpDown, IDataGridViewEditingControl
    {
        private DataGridView dataGridViewControl;
        private bool valueIsChanged = false;
        private int rowIndexNum;
        protected bool initializing = false;

        public NumericUpDownEditingControl()
        {
            initializing = true;

            this.Minimum = (decimal)0;
            this.DecimalPlaces = 0;
            this.Maximum = 120;

            initializing = false;
        }

        virtual public object EditingControlFormattedValue
        {
            get { return this.Value.ToString("#"); }

            set
            {
                if (value is int)
                {
                    this.Value = int.Parse(Value.ToString());
                }
                else if (value is decimal)
                {
                    this.Value = decimal.Parse(value.ToString());
                }
            }
        }

        virtual public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return this.Value.ToString("#");
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex
        {
            get { return rowIndexNum; }
            set { rowIndexNum = value; }
        }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return false;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // No preparation needs to be done.
        }

        public bool RepositionEditingControlOnValueChange
        {
            get { return false; }
        }

        public DataGridView EditingControlDataGridView
        {
            get { return dataGridViewControl; }
            set { dataGridViewControl = value; }
        }

        public bool EditingControlValueChanged
        {
            get { return valueIsChanged; }
            set { valueIsChanged = value; }
        }

        public System.Windows.Forms.Cursor EditingControlCursor
        {
            get { return base.Cursor; }
        }

        System.Windows.Forms.Cursor IDataGridViewEditingControl.EditingPanelCursor
        {
            get { return EditingControlCursor; }
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            if (!initializing) // Original code blew up without this
            {
                // Notify the DataGridView that the contents of the cell have changed.
                valueIsChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true); base.OnValueChanged(eventargs);
            }
        }
    }
    }
