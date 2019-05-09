using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAP2
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "SoapPrinterService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez SoapPrinterService.svc ou SoapPrinterService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class SoapPrinterService : ISoapPrinterService
    {
        public Boolean addCHFByUID(int idUser, decimal amount)
        {
            BLL.UserManager.addCHFByUID(idUser, amount);
            return true;
        }
        public String getUsernameByCardID(int cardId)
        {
            return BLL.CardManager.getUsernameByUserID(cardId);
        }
        public double addQuotaByUsername(string username, decimal amount)
        {
            return BLL.UserManager.addCHFByUserName(username,BLL.UserManager.convertCHFToQuota(amount));
        }

        public decimal convertCHFToQuota(decimal amount)
        {
            return BLL.UserManager.convertCHFToQuota(amount);
        }

        public decimal convertQuotaToCHF(decimal amount)
    {
            return BLL.UserManager.convertCHFToQuota(amount);
        }
        public Boolean addCHFByUsername(String name, decimal amount)
        {
            BLL.UserManager.addCHFByUserName(name,amount);
            return true;
        }
        public String getUserAccount(String name)
        {
            User tempUser = BLL.UserManager.getUserAccount(name);
            int quota = BLL.UserManager.convertCHFToQuota(tempUser.CHF);
            string userString = "UserId: \t" + tempUser.userId + "\n" +
                                "userName: \t" + tempUser.userName + "\n" +
                                "CHF:\t\t" + tempUser.CHF + "\n" +
                                "cardId:\t\t" + tempUser.cardId + "\n" +
                                "Quota:\t\t" + quota + "\n";

            return userString;
        }





    }
}