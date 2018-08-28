using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura.Binding
{
    class ActionBinder
    {
        public ActionBindInfo ObterActionBindInfo(object controller, string path)
        {
            // /Cambio/Calculo?moedaOrigem=BRL&moedaDestino=USD&valor=10
            // /Cambio/Calculo?moedaDestino=USD&valor=10
            // /Cambio/USD

            var idxInterrogacao = path.IndexOf("?");
            var existeQueryString = idxInterrogacao >= 0;

            if (!existeQueryString)
            {
                var nomeAction = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries)[1];
                var methodInfo = controller.GetType().GetMethod(nomeAction);

                return new ActionBindInfo(methodInfo, Enumerable.Empty<ArgumentoNomeValor>());
            }
            else
            {
                var nomeController = path.Substring(0, idxInterrogacao);
                var nomeAction = nomeController.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries)[1];
                var queryString = path.Substring(idxInterrogacao + 1);

                var tuplasNomeValor = ObterArgumentosNomeValores(queryString);

                var nomeArgumentos = tuplasNomeValor.Select(tupla => tupla.Nome).ToArray();

                var methodInfo = ObterMethodInfoAPartirDeNomeEArgumentos(nomeAction, nomeArgumentos, controller);

                return new ActionBindInfo(methodInfo, tuplasNomeValor);
            }
        }

        private IEnumerable<ArgumentoNomeValor> ObterArgumentosNomeValores(string queryString)
        {
            // valor=10&moedaOrigem=USD&moedaDestino=BRL
            var tuplasNomeValor = queryString.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var tuplas in tuplasNomeValor)
            {
                //valor=10
                var partesTupla = tuplas.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                yield return new ArgumentoNomeValor(partesTupla[0], partesTupla[1]);
            }
        }

        private MethodInfo ObterMethodInfoAPartirDeNomeEArgumentos(string nomeAction, string[] argumentos, object controller)
        {
            var argumentosCount = argumentos.Length;

            var bindingFlags =
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.DeclaredOnly;

            var metodos = controller.GetType().GetMethods(bindingFlags);
            var sobrecargas = metodos.Where(metodo => metodo.Name == nomeAction);

            foreach (var sobrecarga in sobrecargas)
            {
                var parametros = sobrecarga.GetParameters();

                if (argumentosCount != parametros.Length)
                    continue;

                var match =
                    parametros.All(
                        parametro =>
                            argumentos.Contains(parametro.Name)
                    );

                if (match)
                    return sobrecarga;
            }
            throw new ArgumentException($"A sobrecarga do método {nomeAction} não foi encontrada!");
        }
    }
}
