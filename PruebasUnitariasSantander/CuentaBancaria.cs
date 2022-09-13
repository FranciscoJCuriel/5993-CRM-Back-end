using System;

namespace PruebasUnitariasSantander
{
    public class CuentaBancaria
    {
        private readonly string nombreCLiente;
        private double balance;

        private CuentaBancaria() { }
        public CuentaBancaria(string m_customerName, double m_balance)
        {
            nombreCLiente = m_customerName;
            balance = m_balance;
        }

        public string NombreCliente
        {
            get { return nombreCLiente;  }
        }
        public double Balance
        {
            get { return balance; }
        }

        public void Debito(double monto)
        {
                                  
            if (monto > balance)
            {
                throw new  ArgumentOutOfRangeException("monto");
            }

                if (monto < 0)
            {
                throw new ArgumentOutOfRangeException("monto");
            }

            balance -= monto;

        }

        public void Credito(double monto)
        {
            if (monto < 0)
            {
                throw new ArgumentOutOfRangeException("monto");

            }
            balance -= monto;
        }

        public static void Main()
        {
            CuentaBancaria cb = new CuentaBancaria("Pako Leal", 11.99);
            cb.Credito(5.77);
            cb.Debito(11.22);

            Console.WriteLine("El saldo actual es ${0}", cb.Balance);
        }

       
    }
}
