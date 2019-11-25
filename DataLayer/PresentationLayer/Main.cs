using LogicalLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PresentationLayer.Prefabs;
using LogicalLayer.Enums;
using LogicalLayer.Interfaces;

namespace PresentationLayer
{
    /// <summary>
    /// Main class.
    /// </summary>
    public partial class Main : Form, TotalValue,ContainerUpdater
    {
        private Singleton singleton;
        private double total;

        /// <summary>
        /// Main constructor.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            this.singleton = Singleton.getInstance();
            this.fillContainer( this.singleton.getMoney());          
        }
        public void fillContainer(List<Money> list)
        {    
            foreach(Money money in list)
            {
                MoneyControl temp = new MoneyControl(this, money);
                if (money.TypeCurrency == TypeCurrency.Bill)
                    billContainer.Controls.Add(temp);
                else
                    coinContainer.Controls.Add(temp);

            }
        }

        public void addMoney(double value)
        {
            this.total += value;
            lblMoney.Text = this.total.ToString();
        }

        /// <summary>
        /// if you press the "Gestionar Dinero" button, open the form Manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openManager(object sender, EventArgs e)
        {
            Manager form =  new Manager(this.singleton);
            form.ShowDialog();
            this.containerUpdate();
            
        }


        private void finish(object sender, EventArgs e)
        {
            this.total = 0;
            lblMoney.Text = "0.0";
            Closing form = new Closing();
            form.fillinClosing(); //function that fills the listbox of the form to be displayed
            form.ShowDialog();
        }

        /// <summary>
        /// if you close the window the program finishes running
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit(); //the program ends
        }

        /// <summary>
        /// if you choose the type of currency again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back(object sender, EventArgs e)
        {
            Form form = new Preload();
            form.Show();
            this.Dispose();
        }

        public void containerUpdate()
        {
            this.coinContainer.Controls.Clear();
            this.billContainer.Controls.Clear();
            this.fillContainer(this.singleton.getMoney());
        }
    }
}
