namespace API.Controllers;

public class Test
{
    public bool PaymentWithCash()
    {
        ////
        return true;
    } 
    public bool PaymentWithVisa()
    {
        //// Conecta VISa
        return true;
    }
    
    public bool PaymentWithCryto()
    {
        //// Conecta VISa
        return true;
    }
    
    public bool PaymentWithMastercard()
    {
        //// Conecta VISa
        return true;
    }
    
    public bool sale(int PaymentType) //Coupled --Acoplado
    {
        switch (PaymentType)
        {
            case: 1;
                PaymentWithCash();
            case: 2;
                PaymentWithVisa();
            case: 3;
                PaymentWithCryto();
        }
        return true;
    }

    public bool sale2(func<bool> payment)
    {
        payment()
    }
    
    sale2(paymentWithMastecard)
    sale2(paymentWithVisa)
    sale2(paymentWithCryto)
    
}