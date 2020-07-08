namespace Conversor_de_Moeda
{
    class ConversorDeMoeda
    {
        static public double Iof = 1.1;


        static public double Total(double cotacao, double quantidade)
        {
            double total =  cotacao * quantidade;
            return total + total * Iof / 100;
        }
    }
    
}
    