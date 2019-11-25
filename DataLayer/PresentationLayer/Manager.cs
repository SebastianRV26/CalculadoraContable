using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LogicalLayer;
using PresentationLayer.Prefabs;
using LogicalLayer.Enums;
using LogicalLayer.Interfaces;

namespace PresentationLayer
{
    /// <summary>
    /// Manager class.
    /// </summary>
    public partial class Manager: Form, MoneyManager, ContainerUpdater
    {
        private Singleton singleton;

        /// <summary>
        /// Manager constructor
        /// </summary>
        /// <param name="singleton"></param>
        public Manager(Singleton singleton)
        {
            InitializeComponent();
            this.singleton = singleton;
            this.fillContainer(this.singleton.getMoney());
        }



        /// <summary>
        /// function call that removes the selected money instance
        /// </summary>
        /// <param name="money"></param>
        public void deleteCurrency(Money money)
        {
            this.singleton.getMoney().Remove(money);
        }

        /// <summary>
        /// Validates that the number entered is positive and validates that there is 
        /// no number with the same type of concurrence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMoney(object sender, EventArgs e)
        {
            if (txtboxAdd.Value > 0)
            {
                TypeCurrency typeCurrency;
                double value = (double) txtboxAdd.Value;

                if (radiobtnBillete.Checked)
                    typeCurrency = TypeCurrency.Bill;
                else
                    typeCurrency = TypeCurrency.Coin;

                if (!this.isEqual(value,typeCurrency))
                {
                    Money temp = new Money(value, typeCurrency, singleton.getCurrency());
                    this.singleton.getMoney().Add(temp);
                    this.singleton.saveMoney();
                    this.moneyContainer.Controls.Add(new MoneyControl(this, temp));
                    MessageBox.Show("Agregado correctamente!", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }else
                MessageBox.Show("Valor en cero", "Valor nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveData(object sender, FormClosingEventArgs e)
        {
            this.singleton.saveMoney();
        }

        /// <summary>
        /// call the functions that refresh the list
        /// </summary>
        public void containerUpdate()
        {
            this.moneyContainer.Controls.Clear();
            this.fillContainer(this.singleton.getMoney());
        }

        /// <summary>
        /// call the function that shows the coins
        /// </summary>
        /// <param name="list"></param>
        public void fillContainer(List<Money> list)
        {
            foreach (Money money in list)
            {
                moneyContainer.Controls.Add(new MoneyControl(this, money));
            }
        }
        /// <summary>
        /// if you press the "Atrás" button, close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBefore_Click(object sender, EventArgs e)
        { 
            this.Close(); //
        }


        /// <summary>
        /// function that runs through the singleton list
        /// </summary>
        /// <param name="value"></param>
        /// <param name="typeCurrency"></param>
        /// <returns>
        /// true: if you found a value with the repeated type
        /// false: if you didn't find it
        /// </returns>
        public bool isEqual(double value,TypeCurrency typeCurrency)
        {
            foreach (Money money in this.singleton.getMoney())
            {
                if (money.Value == value && money.TypeCurrency.Equals(typeCurrency))
                {
                    MessageBox.Show("Ya existe un billete con este valor", "Valor repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
    }
}
