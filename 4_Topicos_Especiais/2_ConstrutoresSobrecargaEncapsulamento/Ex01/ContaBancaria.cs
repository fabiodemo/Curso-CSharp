/*
Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
exemplo).
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação.
*/
using System.Globalization;


namespace Ex01
{
    class ContaBancaria
    {
        private int _id;
        private string _nome;
        private double _saldo;


        public ContaBancaria()
        {

        }

        public ContaBancaria(int Id, string Nome, double Saldo)
        {
            _id = Id;
            _nome = Nome;
            _saldo = Saldo;
        }

        public ContaBancaria(int Id, string Nome)
        {
            _id = Id;
            _nome = Nome;
            _saldo = 0.0;
        }

        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    _id = 1;
                }
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    _nome = value;
                }
            }
        }

        public double Saldo
        {
            get { return _saldo; }
            set{
                if (value > 0)
                {
                    _saldo = value;
                }
            }
        }

        public void Deposito(double valor)
        {
            _saldo += valor;
        }

        public void Saque(double valor)
        {
            if (valor <= _saldo)
            {
                _saldo -= (valor + 5);
            }
            else
            {
                Console.WriteLine("Valor do saque supera o valor em conta!");
            }
        }

        public override string ToString()
        {
            return $"Conta {_id}, Titular: {_nome}, Saldo atual: {_saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}