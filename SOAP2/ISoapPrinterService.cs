using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAP2
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ISoapPrinterService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ISoapPrinterService
    {
        [OperationContract]
        Boolean addCHFByUID(int idUser, decimal amount);

        [OperationContract]
        String getUsernameByCardID(int cardId);

        [OperationContract]
        double addQuotaByUsername(string Username, decimal amount);

        [OperationContract]
        decimal convertCHFToQuota(decimal amount);

        [OperationContract]
        decimal convertQuotaToCHF(decimal amount);

        [OperationContract]
        Boolean addCHFByUsername(String name, decimal amount);

        [OperationContract]
        String getUserAccount(String name);
    }
}
