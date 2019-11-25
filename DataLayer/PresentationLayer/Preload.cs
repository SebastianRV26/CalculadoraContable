using System;
using System.Windows.Forms;
using LogicalLayer;
using LogicalLayer.Enums;

namespace PresentationLayer
{
    /// <summary>
    /// Preload class
    /// </summary>
    public partial class Preload : Form
    {
        private Singleton singleton;

        /// <summary>
        /// Preload constructor
        /// </summary>
        public Preload()
        {
            this.singleton = Singleton.getInstance();
            InitializeComponent();
            comboCurrency.DataSource = Enum.GetValues(typeof(Currency));
        }


        /// <summary>
        /// hide the current form and show the main form when the "Entrar" button 
        /// is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickEnter(object sender, EventArgs e)
        {
            this.singleton.setCurrency((Currency)comboCurrency.SelectedItem);
            Main form = new Main();
            form.Show();
            this.Dispose();
            
        }

        /// <summary>
        /// if you close the window the program finishes running
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        
            Application.Exit();
        }
    }
}
