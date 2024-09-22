using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_POO
{
    public class Camisa : Roupa
    {
        private string tipoManga;
        private string estampa;
        private bool possuiBotoes;
        private bool possuiBolsos;
        private string tipoGola;
        public string GetTipoManga()
        {
            return tipoManga;
        }
        public string GetEstampa()
        {
            return estampa;
        }
        public bool GetPossuiBotoes()
        {
            return possuiBotoes;
        }
        public bool GetPossuiBolsos()
        {
            return possuiBolsos;
        }

        public string GetTipoGola()
        {
            return tipoGola;
        }
        public void SetTipoManga(string novoTipoManga)
        {
            tipoManga = novoTipoManga;
        }
        public void SetEstampa(string novaEstampa)
        {
            estampa = novaEstampa;
        }
        public void SetPossuiBotoes(bool novoPossuiBotoes)
        {
            possuiBotoes = novoPossuiBotoes;
        }
        public void SetPossuiBolsos(bool novoPossuiBolsos)
        {
            possuiBolsos = novoPossuiBolsos;
        }
        public void SetTipoGola(string novoTipoGola)
        {
            tipoGola = novoTipoGola;
        }


        public Camisa(string marca, string cor, double preco, int qntdEstoque, string tamanho,
        string tipoManga, string estampa, bool possuiBotoes, bool possuiBolsos, string tipoGola)
         : base(marca, cor, preco, qntdEstoque, tamanho)

        {
            this.tipoManga = tipoManga;
            this.estampa = estampa;
            this.possuiBotoes = possuiBotoes;
            this.possuiBolsos = possuiBolsos;
            this.tipoGola = tipoGola;
        }

        public Camisa() { }

        public int ExibirEstoque(int estoque) //talvez fazer esse metodo ser override e fazer o original na classe pai
        {
            Console.WriteLine($"Estoque de camisas {estoque}");
            // ComprarCamisa(estoque);
            return estoque;
        }

        public int ComprarCamisa(int estoque, int qntdCamisa)
        {

            estoque = estoque - qntdCamisa;
            Console.WriteLine($"{qntdCamisa} Camisas compradas, {estoque} restantes dessa marca");
            return estoque;
        }

        public double ValorParaPagar(double preco, int qntdCamisa)
        {
            double precoTotal = preco * qntdCamisa;
            Console.WriteLine($"Total para ser pago = {precoTotal}");
            return precoTotal;
        }
  
    }
}