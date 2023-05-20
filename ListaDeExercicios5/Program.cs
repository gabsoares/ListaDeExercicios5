Console.Write("Digite o valor da conta: ");
double valorConta = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor pago: ");
double valorPago = Convert.ToDouble(Console.ReadLine());

double troco = valorPago - valorConta;

int notaDe100 = 0;
int notaDe50 = 0;
int notaDe20 = 0;
int notaDe10 = 0;
int notaDe5 = 0;
int notaDe2 = 0;


    while (troco >= 100)
    {
        troco -= 100;
        notaDe100++;
    }
    while (troco >= 50)
    {
        troco -= 50;
        notaDe50++;
    }
    while (troco >= 20)
    {
        troco -= 20;
        notaDe20++;
    }
   while (troco >= 10)
    {
        troco -= 10;
        notaDe10++;
    }
    while (troco >= 10)
    {
        troco -= 10;
        notaDe10++;
    }
    while (troco >= 5)
    {
        troco -= 5;
        notaDe5++;
    }
    while (troco >= 2)
    {
        troco -= 2;
        notaDe2++;
    }

Console.WriteLine($"Seu troco: {notaDe100} nota de cem, {notaDe50} nota de 50, {notaDe10} nota de 10, {notaDe5} nota de 5,  {notaDe2} nota de 2");