using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalLayer.Interfaces
{
    /// <summary>
    /// Use for accumulate total value of the clash closing.
    /// </summary>
    public interface TotalValue
    {
        /// <summary>
        /// take the value and add to accumlate.
        /// </summary>
        /// <param name="value"> value to add </param>
        void addMoney(double value);
    }
}
