import proxy.BanqueService;
import proxy.BanquesWS;
import proxy.Compte;

import java.util.List;

public class ClientWS {
    public static void main(String[] args) {
        BanqueService stubWsws= new BanquesWS().getBanqueServicePort();
        System.out.println(stubWsws.conversionEuroToDH(800));
        Compte cp= stubWsws.getCompte(2L);
        System.out.println(cp.getCode());
        System.out.println(cp.getSolde());
        List<Compte> cptes=stubWsws.listComptes();
        cptes.forEach(c->{
            System.out.println("-------------------");
            System.out.println(c.getCode());
            System.out.println(c.getSolde());
        });
    }
}
