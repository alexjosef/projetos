using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using DesignPatterns2.Cap8;
using DesignPatterns2.Cap9;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAP4
            //// (1 + 10) + (20 - 10)
            //IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            //IExpressao soma = new Soma(esquerda, direita);
            //IExpressao e = new RaizQuadrada(soma);

            //Console.WriteLine(soma.Avalia());

            //PreFixaVisitor prefixa = new PreFixaVisitor();
            //soma.Aceita(prefixa);

            //IEnviador enviador = new EnviaPorEmail();
            //IMensagem mensagem = new MensagemAdministrativa("Alex");
            //mensagem.Enviador = enviador;
            //mensagem.Envia();

            //FilaDeTrabalho fila = new FilaDeTrabalho();
            //Pedido pedido1 = new Pedido("Alex", 150.0);
            //Pedido pedido2 = new Pedido("Lucas", 650.0);

            //fila.Adiciona(new PagaPedido(pedido1));
            //fila.Adiciona(new PagaPedido(pedido2));

            //fila.Adiciona(new FinalizaPedido(pedido1));

            //fila.Processa();

            //Cliente cliente = new Cliente();
            // cliente.Nome = "Alex";
            // cliente.Endereco = "Rua Godo Deeke";
            // cliente.DataDeNascimento = DateTime.Now;

            // String xml = new GeradorXml().GeraXml(cliente);

            // Console.WriteLine(xml);

            //String cpf = "12345";

            //EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            //Cliente cliente = facade.BuscaPorCliente(cpf);

            //var fatura = facade.CriaFatura(cliente, 5000);
            //facade.GeraCobranca(tipo.boleto, fatura);

        }
    }
}
