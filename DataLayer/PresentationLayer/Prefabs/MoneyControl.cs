using System;
using LogicalLayer.Interfaces;
using System.Windows.Forms;
using LogicalLayer;

namespace PresentationLayer.Prefabs
{
    /// <summary>
    /// Money Control
    /// provide a view to display currency data and methods to edit, 
    /// delete and add money to the total
    /// </summary>
    public partial class MoneyControl : UserControl
    {
        private TotalValue manager;
        private MoneyManager editor;
        private Money money;
        private bool editing;

        /// <summary>
        /// MoneyControl Constructor. It is used when you want to only show your data
        /// </summary>
        /// <param name="manager">TotalValue interface. it is necessary for the event to add quantity </param>
        /// <param name="money">Money object. Object of the currency to be displayed</param>
        public MoneyControl(TotalValue manager, Money money)
        {
            this.editing = false;
            this.manager = manager;
            InitializeComponent();
            this.money = money;
            lblValue.Text = money.Value.ToString();
            this.changeBackground();

        }

        /// <summary>
        /// MoneyControl Constructor. It is used when you want to be able to edit the currency
        /// </summary>
        /// <param name="manager">MoneyManager interface. it is necessary for delete and verify if the unique currency</param>
        /// <param name="money">Money object. Object of the currency to be displayed</param>
        public MoneyControl(MoneyManager editor, Money money)
        {
            this.editing = true;
            this.editor = editor;
            InitializeComponent();

            this.lblEditing.Visible = true;
            lblValue.Visible = false;
            btnDelete.Visible = true;
            this.inputQuantity.DecimalPlaces = 2;
            inputQuantity.Value = (decimal) money.Value;
            this.btnAction.Text = "Guardar";
            this.money = money;

            this.changeBackground();
        }

        /// <summary>
        ///  check if the money object is bill or coin, if it is a bill,
        ///  this function changes the background color.
        /// </summary>
        private void changeBackground()
        {
            if (this.money.TypeCurrency == LogicalLayer.Enums.TypeCurrency.Bill)
                this.BackColor = System.Drawing.Color.LightBlue;
        }

        /// <summary>
        /// event that occurs when pressing x in the view. deletes the program currency
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void removeCurrency(object sender, EventArgs e)
        {
            this.editor.deleteCurrency(this.money);
            this.Dispose();
        }

        /// <summary>
        ///  event that occurs when pressing 'guardar' or 'agregar' in the view. edit currency value or 
        ///  add value total.
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void action(object sender, EventArgs e)
        {
            if (editing)
            {
                Console.WriteLine("Editanto");
                double value = (double)inputQuantity.Value;
                Console.WriteLine(value);
                if (value > 0)
                {
                    Console.WriteLine("Valor mayor");
                    if (!this.editor.isEqual(value, this.money.TypeCurrency))
                    {
                        this.money.Value = value;
                    }
                    MessageBox.Show("Guardado");
                }
                else
                    MessageBox.Show("Numero menor o igual a 0");
                return;
            }
            manager.addMoney( (int)inputQuantity.Value * this.money.Value);
            this.money.setQuantity((int)inputQuantity.Value); //increase the amount of the object

            inputQuantity.Value = 0;
        }
    }
}
