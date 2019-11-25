using LogicalLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalLayer.Interfaces
{
    /// <summary>
    /// Money Manager interface
    /// used to remove money objcts or identify equals values in the active 
    /// </summary>
    public interface MoneyManager
    {
        /// <summary>
        /// delete specific Money object in list
        /// </summary>
        /// <param name="money"> Object money to search in list</param>
        void deleteCurrency(Money money);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"> Value used to compare </param>
        /// <param name="typeCurrency"> type currency used to compare</param>
        /// <returns>True if the value is equal or false is not same </returns>
        bool isEqual(double value,TypeCurrency typeCurrency);
    }
}