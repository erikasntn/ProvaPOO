using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_POO
{
    public class Calca : Roupa
    {
        private string tipo;
        private bool possuiZipper;
        private int numeroBolsos;
        private int comprimento;
        private bool possuiCinto;

        public string GetTipo()
        {
            return tipo;
        }

        public bool GetPossuiZipper()
        {
            return possuiZipper;
        }

        public int GetNumeroBolsos()
        {
            return numeroBolsos;
        }

        public int GetComprimento()
        {
            return comprimento;
        }

        public bool GetPossuiCinto()
        {
            return possuiCinto;
        }


        public void SetTipo(string novoTipo)
        {
            tipo = novoTipo;
        }

        public void SetPossuiZipper(bool novoPossuiZipper)
        {
            possuiZipper = novoPossuiZipper;
        }

        public void SetNumeroBolsos(int novoNumeroBolsos)
        {
            numeroBolsos = novoNumeroBolsos;
        }

        public void SetComprimento(int novoComprimento)
        {
            comprimento = novoComprimento;
        }

        public void SetPossuiCinto(bool novoPossuiCinto)
        {
            possuiCinto = novoPossuiCinto;
        }


        public Calca(string marca, string cor, double preco, int qntdEstoque, string tamanho, string tipo,
       bool possuiZipper, int numeroBolsos, int comprimento, bool possuiCinto)
       : base(marca, cor, preco, qntdEstoque, tamanho)
        {
            this.tipo = tipo;
            this.possuiZipper = possuiZipper;
            this.numeroBolsos = numeroBolsos;
            this.comprimento = comprimento;
            this.possuiCinto = possuiCinto;
        }
        public int ExibirEstoque(int estoque) //talvez fazer esse metodo ser override e fazer o original na classe pai
        {
            Console.WriteLine($"Estoque de camisas {estoque}");
            return estoque;
        }
        public int ComprarCalca(int estoque, int qntdCalca)
        {

            estoque = estoque - qntdCalca;
            Console.WriteLine($"{qntdCalca} Camisas compradas, {estoque} restantes dessa marca");
            return estoque;
        }

        public double ValorParaPagar(double preco, int qntdCalca)
        {
            double precoTotal = preco * qntdCalca;
            Console.WriteLine($"Total para ser pago = {precoTotal}");
            return precoTotal;
        }

        public double FazerABarra(int comprimento)
        {
            int tirarDaBarra = 5 ;
           int tamanhoNovoDaCalca = comprimento - tirarDaBarra;
            Console.WriteLine($"Tamanho atual = {tamanhoNovoDaCalca}");
            return tamanhoNovoDaCalca;
        }
    }
}