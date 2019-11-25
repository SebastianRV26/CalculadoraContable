using LogicalLayer.Enums;

namespace LogicalLayer
{

    /// <summary> 
    /// Money Class.
    /// Stores the basic currency information.
    /// </summary>
    public class Money
    {
        public double Value { get; set; }
        public Currency Currency { get; set; }
        public TypeCurrency TypeCurrency { get; set; }

        private int Quantity { get; set; }


        ///<summary> Constructor Class </summary>
        ///<param name="value"> monetary value that it has </param>
        ///<param name="typeCurrency"> Type currency </param>
        ///<example>Coin,Bill</example>
        ///<param name="currency">  </param>
        public Money(double value, TypeCurrency typeCurrency, Currency currency)
        {
            this.Currency = currency;
            this.TypeCurrency = typeCurrency;
            this.Value = value;
            this.Quantity = 0;
        }


        ///<summary> Getter attribute quantity</summary>
        ///<return> currency amount  </return>
        public int getQuantity()
        {
            return this.Quantity;
        }

        ///<summary> Setter attribute quantity </summary>
        ///<param name="quantity"> currecy amount to add quantity</param>
        public void setQuantity(int quantity)
        {
            this.Quantity += quantity;
        }
    }
}
