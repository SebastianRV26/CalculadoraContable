using DataLayer;
using LogicalLayer.Enums;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LogicalLayer
{
    /// <summary>
    /// Singleton class.
    /// 
    /// </summary>
    public class Singleton
    {
        private const string PATH = "Currency\\";
        private const string TYPE = ".json";

        private static Singleton instance;
        private List<Money> money;

        private Currency currency;

        /// <summary>
        /// Singleton Constructor
        /// </summary>
        private Singleton(){ }

        ///<summary> search and save data in money attribute </summary>
        private List<Money> getData()
        {
            string data = Manager.loadJson(PATH + this.currency.ToString() + TYPE);

            if (data != null)
                return this.money = JsonConvert.DeserializeObject<List<Money>>(data);
            return this.money = new List<Money>();
        }

        ///<summary>
        ///getter the Singleton istance, if the instance is null,
        ///create new Singleton instance
        ///</summary>
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                return instance = new Singleton();
            }
            return instance;
        }

        ///<summary>
        ///getter attribute money. This attribute has all money in the active session.
        ///</summary>
        public List<Money> getMoney()
        {
            return this.money;
        }


        ///<summary>
        ///call saveJson method to save all currency in the active session.
        ///</summary>
        public bool saveMoney()
        {
            string path = PATH + currency.ToString() + TYPE;
            return Manager.saveJson(path,this.money);
        }


        ///<summary>
        ///getter attrbiute currency. this attribute has active currency in the application.
        ///</summary>
        public Currency getCurrency()
        {
            return this.currency;
        }

        ///<summary>
        ///setter attribute currency
        ///</summary>
        ///<param name="currency">
        ///Currency enum to set.
        /// </param>
        public void setCurrency(Currency currency)
        {
            this.currency = currency;
            this.getData();
        }
    }
}
