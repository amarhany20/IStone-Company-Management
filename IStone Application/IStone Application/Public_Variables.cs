using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IStone_Application
{
    class Public_Variables
    {
        public static int selectedCustomerID, signedInID, selectedOrderID , rank = 2 , selectedUserId;
        public static string selectedCustomerName, SignedInUsername, selectedOrderName, creationFullName, creationMobile1, creationMobile2, creationEmail, creationNotes, creationOrder, creationType, creationDaysRequested, creationMarbleType, creationMarbleAmount, creationMarbleNotes, creationPaymentName , selectedUsername;
        public static double creationPrice, creationMeter, creationMarbleLength, creationMarbleWidth, creationPaymentAmount;
        public static bool firstTime = true, selectionDone = false, isAdminSelectingAChange = false;
    }
}
