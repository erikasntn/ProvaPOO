using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_POO
{
    public class Roupa
    {
        private string marca;
        private string cor;
        private double preco;
        protected int qntdEstoque; //para classes filhas acessarem
        private string tamanho;


        public string GetMarca()
        {
            return marca;
        }
        public string GetCor()
        {
            return cor;
        }
        public double GetPreco()
        {
            return preco;
        }
        public int GetQntdEstoque()
        {
            return qntdEstoque;
        }

        public string GetTamanho()
        {
            return tamanho;
        }
        public void SetMarca(string novaMarca)
        {
            marca = novaMarca;
        }
        public void SetCor(string novaCor)
        {
            cor = novaCor;
        }
        public void SetPreco(double novoPreco)
        {
            preco = novoPreco;
        }
        public void SetQntdEstoque(int novaqntdEstoque)
        {
            qntdEstoque = novaqntdEstoque;
        }
        public void SetTamanho(string novoTamanho)
        {
            tamanho = novoTamanho;
        }

        public Roupa()
        {
            marca = "Nike, Adidas, Baw, High";
            cor = "Verde, Azul, Preto, Amarelo, Branco";
            // preco = preco;
            qntdEstoque = 30;
            tamanho = "PP, P, M, G, GG";
        }


        public Roupa(string marca, string cor, double preco, int qntdEstoque, string tamanho)
        {
            this.marca = marca;
            this.cor = cor;
            this.preco = preco;
            this.qntdEstoque = qntdEstoque;
            this.tamanho = tamanho;
        }

       public void ExibirInformacoes(){

        Console.WriteLine($"Marcas - {marca}\n cores - {cor}\n precos - de 20 a 200\n " + 
        $"quantidade de roupas em estoquee - {qntdEstoque}\n tamanhos - {tamanho}");
       }

    }
}