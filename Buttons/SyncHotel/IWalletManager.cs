using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHotel
{
    public interface IWalletManager
    {
        /*
        Properties:
        •	 WalletBalance
        Method: 
        •	WalletRecharge
        •	DeductBalance

        */
        public double WalletBalance { get; set; }

        public void WalletRecharge(double amount);
        public void DeductBalance(double amount);

    }
}