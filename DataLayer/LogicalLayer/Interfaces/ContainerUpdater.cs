using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalLayer.Interfaces
{
    /// <summary>
    /// Container updater
    /// Provide methods used to update containers.
    /// </summary>
    public interface ContainerUpdater
    {
        /// <summary>
        /// used to empty container and call fillCOntainer.
        /// </summary>
        void containerUpdate();

        /// <summary>
        /// fill with MoneyControl
        /// </summary>
        /// <param name="list"></param>
        void fillContainer(List<Money> list);
    }
}
