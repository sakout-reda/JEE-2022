using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soap_client_ws
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.BanqueServiceClient stub = new ServiceReference1.BanqueServiceClient();
            Console.WriteLine(stub.conversionEuroToDH(500));

            Console.WriteLine("---------- Détails du compte ----------");
            ServiceReference1.compte compte = stub.getCompte("MM55");
            Console.WriteLine(compte.code);
            Console.WriteLine(compte.solde);
            Console.WriteLine(compte.dateCreation);

            ServiceReference1.compte[] comptes = stub.getComptes();

            Console.WriteLine("---------- Liste des comptes ----------");
            foreach (var cpt in comptes)
            {
                Console.WriteLine(cpt.code);
                Console.WriteLine(cpt.solde);
                Console.WriteLine(cpt.dateCreation);
            }
            Console.ReadLine();
        }
    }
}
