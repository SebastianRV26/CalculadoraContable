using LogicalLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{

    /// <summary>
    /// Closing class
    /// </summary>
    public partial class Closing : Form
    {
        private Singleton singleton;

        /// <summary>
        /// Closing constructor
        /// </summary>
        public Closing()
        {
            singleton = Singleton.getInstance(); 
            InitializeComponent();
        }

        /// <summary>
        /// fill the listbox with the coins that were added in the main form
        /// </summary>
        public void fillinClosing()
        {
            listBox1.Items.Add(string.Format("   \t{0}   \t\t{1}   \t\t{2}   \t{3}", "Tipo", "Valor", "Cantidad", "Total"));
            foreach (Money money in singleton.getMoney())
            {
                if (money.getQuantity() != 0)
                {
                    listBox1.Items.Add(string.Format("   \t{0}   \t\t{1}   \t\t{2}   \t\t{3}", money.TypeCurrency, money.Value, money.getQuantity(), money.Value * money.getQuantity()));
                    money.setQuantity(0);
                }
            }
        }

    }
}
