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
        public double addCHFByUID(int idUser, decimal amount)
        {
            return BLL.UserManager.addCHFByUID(idUser,amount);
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
        public double addCHFByUsername(String name, decimal amount)
        {
            return BLL.UserManager.addCHFByUserName(name,amount);
        }
        public DTO.User getUserAccount(String name)
        {
            return BLL.UserManager.getUserAccount(name);
        }





    }
}