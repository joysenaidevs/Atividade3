using System;

namespace atv_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 3");

            Console.WriteLine("Digite quais são os produtos: ");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de produtos: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o preço unitario: ");
            float precoUnitario = float.Parse(Console.ReadLine());
            
            
            TotalAPagar(quantidadeProduto, precoUnitario);

            float TotalAPagar(int quantidade, float preco)
            {
                float total = quantidade * preco;
                float desconto;

                if(quantidade <=5){
                    desconto = 0.02f;
                }else if(quantidade <=10){
                    desconto = 0.03f;
                }else{
                    desconto = 0.05f;
                }
                float valorDesconto = total * desconto;
                float totalDesconto = total - valorDesconto;

                Console.WriteLine($"O valor total é de: {total}");
                Console.WriteLine($"Voce terá {valorDesconto} de desconto");
                Console.WriteLine($"Sua compra com desconto fica  {totalDesconto}");

                return totalDesconto;

            } // Fim total a pagar

        } // fim do main
    }
}
