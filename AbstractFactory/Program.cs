using AbstractFactory;

public class Program
{
    static void Main()
    {
        AFImplementation.AbstractFactory _Cfactory = new AFImplementation.CitroenFactory();
        AFImplementation.AbstractFactory _Ffactory = new AFImplementation.FiatFactory();


        _Ffactory.ProduceVan().Assemble();


        _Cfactory.ProduceVan().Assemble();

    }
}



