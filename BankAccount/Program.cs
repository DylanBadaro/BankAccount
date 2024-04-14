namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        { 
            BankAccount cbDylan = new BankAccount("Dylan", 1000, DateTime.Now);
            Console.WriteLine($"{cbDylan.Owner} acaba de crear su cuenta numero ({cbDylan.Number}) con: ${cbDylan.Balance}");
            cbDylan.MakeDeposit(400, DateTime.Now, "Honorarios");
            Console.WriteLine($"Estimado {cbDylan.Owner} su balance es: {cbDylan.Balance}");
            cbDylan.MakeDeposit(600, DateTime.Now, "Deuda cobrada");
            Console.WriteLine($"Estimado {cbDylan.Owner} su balance es: {cbDylan.Balance}");

            cbDylan.MakeWithDrawall(500, DateTime.Now, "Compra de PC");
            Console.WriteLine($"Estimado {cbDylan.Owner} su balance es: {cbDylan.Balance}");
            Console.WriteLine("========== HISTORIAL DE CUENTA ==========");
            Console.WriteLine(cbDylan.getAccountHistory());
            Console.WriteLine($"Saldo en cuenta: ${cbDylan.Balance}");

            Console.WriteLine("\n\n*************************************\n\n");

            BankAccount cbMaxi = new BankAccount("Maxi", 9000, DateTime.Now);
            Console.WriteLine($"{cbMaxi.Owner} acaba de crear su cuenta numero ({cbMaxi.Number}) con: ${cbMaxi.Balance}");
            cbMaxi.MakeDeposit(50000, DateTime.Now, "Honorarios");
            Console.WriteLine($"Estimado {cbMaxi.Owner} su balance es: {cbMaxi.Balance}");
            cbMaxi.MakeDeposit(7500, DateTime.Now, "Venta de auto");
            Console.WriteLine($"Estimado {cbMaxi.Owner} su balance es: {cbMaxi.Balance}");

            cbMaxi.MakeWithDrawall(100, DateTime.Now, "Supermercado");
            Console.WriteLine($"Estimado {cbMaxi.Owner} su balance es: {cbMaxi.Balance}");
            Console.WriteLine("========== HISTORIAL DE CUENTA ==========");
            Console.WriteLine(cbMaxi.getAccountHistory());
            Console.WriteLine($"Saldo en cuenta: ${cbMaxi.Balance}");


        }
    }
}
