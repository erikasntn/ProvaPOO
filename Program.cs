using Prova_POO;

class Program
{
    static void Main(string[] args)
    {
        string resposta;
        int qtndRoupa;

        Console.WriteLine("Deseja comprar algo?\n");
        resposta = Console.ReadLine();
        if (resposta == "sim")
        {
            // Console.WriteLine("\nQuantas pecas de roupa voce deseja?\n");
            // qtndRoupa = int.Parse(Console.ReadLine());
            // for (int i = 0; i < qtndRoupa; i++)
            // {
            Roupa roupa = new Roupa();

            Console.WriteLine("\nInformacoes gerais abaixo \n");
            roupa.ExibirInformacoes();
            Console.WriteLine("\n O que gostaria de comprar? \n 1 - Camisa \n 2 - Calca \n");

            resposta = Console.ReadLine();
            if (resposta == "1")
            {
                //              public Camisa(string marca, string cor, double preco, int qntdEstoque, string tamanho,
                // string tipoManga, string estampa, bool possuiBotoes, bool possuiBolsos, string tipoGola)
                //  : base(marca, cor, preco, qntdEstoque, tamanho)

                Camisa camisa1 = new Camisa("Nike", "Preto", 200.00, 5, "M", "Curta", "Listras", false, false, "Redonda");
                Camisa camisa2 = new Camisa("High", "Verde", 150.00, 5, "G", "Curta", "Lisa", true, false, "Redonda");
                Camisa camisa3 = new Camisa("Nike", "Preto", 135.00, 5, "P", "Curta", "Listras", true, true, "Redonda");

                Console.WriteLine("Marca: " + camisa1.GetMarca() + " Cor: " + camisa1.GetCor() + " Preco: " + camisa1.GetPreco());
                camisa1.ExibirEstoque(5);
                Console.WriteLine("Quantas gostaria de comprar? ");
                int qntd = int.Parse(Console.ReadLine());
                camisa1.ComprarCamisa(5, qntd);
                double preco = camisa1.GetPreco();
                camisa1.ValorParaPagar(preco, qntd);

            }
            else if (resposta == "2")
            {
                //            public Calca(string marca, string cor, double preco, int qntdEstoque, string tamanho, string tipo,
                //    bool possuiZipper, int numeroBolsos, string comprimento, bool possuiCinto)
                //    : base(marca, cor, preco, qntdEstoque, tamanho)

                Calca calca1 = new Calca("Nike", "Preto", 200.00, 5, "38", "Jeans", true, 2, 115, true);


                Console.WriteLine("Marca: " + calca1.GetMarca() + " Cor: " + calca1.GetCor() + " Preco: " + calca1.GetPreco());
                calca1.ExibirEstoque(5);
                Console.WriteLine("Quantas gostaria de comprar? ");
                int qntd = int.Parse(Console.ReadLine());
                calca1.ComprarCalca(5, qntd);
                double preco = calca1.GetPreco();
                calca1.ValorParaPagar(preco, qntd);
                Console.WriteLine("Deseja fazer a barra?");
                if (resposta == "sim")
                {
                    calca1.FazerABarra(115);
                 }
            }
        }
    }
}
// }