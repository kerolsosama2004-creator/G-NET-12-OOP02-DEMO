using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP02_DEMO
{
    internal class BankAccount
    {
        //private int _AccountNumber;
        private decimal _Balance;
        private string _name;
        //private int _Pin;
        public BankAccount(/*int AccountNumber*/decimal Balance, string Name, int _pin)
        {
            // _AccountNumber = AccountNumber;
            _Balance = Balance;
            _name = Name;
            Pin = _pin;

        }
        #region Applying Encapsulation Using Getter And Setter
        //Getter
        public decimal GetBalance()
        {
            return _Balance;
        }
        //Setter
        public void SetBalance(decimal value)
        {
            if (value < 0)
            {
                Console.WriteLine("Balnace Can NOT Be Negative");
                return;
            }
            _Balance = value;
        }

        #endregion
        #region Applying Encapsulation Using Property
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    Console.WriteLine("Name Can Not Be Empty Or Less Than 3 Char");
                    return;
                }
                _name = value;
            }
        }

        #endregion
        #region Properities
        #region Part 01
        //Read/Write
        //public int AccountNumber
        //{
        //    get { return _AccountNumber; }
        //    set { _AccountNumber = value; }
        //}
        //-------------
        // Read- Only Property
        //public int AccountNumber
        //{
        //    get { return _AccountNumber; }
        //}
        //Write- Only Property
        //public int AccountNumber
        //{
        //    set { _AccountNumber = value; }
        //} 
        #endregion
        #region Atuo - Property
        public int AccountNumber { get; set; }
        //public int MyProperty { get; set; }
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}
        //-------' 
        //public int Pin
        //{
        //     get { return _Pin; }
        //    set
        //    {
        //        _Pin = value;
        //    }
        //}
        //------------------------
        //public int? Pin { get; private set; }
        public int? Pin { get; init; }
        //public void ResetPin()
        //{
        //    Pin = null;
        //}
        //---------
        // Computed Property
        public bool HasBalance
        {
            get { return _Balance > 0; }
        }
        #endregion
        #endregion
    }
}
