using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public static class AFImplementation
    {
        public interface IVan
        {
            void Assemble();
        }

        public interface IAutomobile
        {
            void Assemble();
        }

        public interface AbstractFactory
        {
            public IVan ProduceVan();
            public IAutomobile ProduceAutomobile();

        }

        public class CitroenVan : IVan
        {
            public void Assemble()
            {
                Console.WriteLine("Putting Citroen Amblems...");
                Console.WriteLine("DONE!!");
            }
        }

        public class FiatVan : IVan
        {
            public void Assemble()
            {
                Console.WriteLine("Putting Fiat Amblems...");
                Console.WriteLine("DONE!!");
            }
        }

        public class CitroenAutomobile : IAutomobile
        {
            public void Assemble()
            {
                Console.WriteLine("Putting Citroen Amblems...");
                Console.WriteLine("DONE!!");
            }
        }

        public class FiatAutomobile : IAutomobile
        {
            public void Assemble()
            {
                Console.WriteLine("Putting Citroen Amblems...");
                Console.WriteLine("DONE!!");
            }
        }



        public class CitroenFactory : AbstractFactory
        {
            public IAutomobile ProduceAutomobile()
            {
                return new CitroenAutomobile();
            }

            public IVan ProduceVan()
            {
                return new CitroenVan();
            }
        }

        public class FiatFactory : AbstractFactory
        {
            public IAutomobile ProduceAutomobile()
            {
                return new FiatAutomobile();
            }

            public IVan ProduceVan()
            {
                return new FiatVan();
            }
        }
    }
}
