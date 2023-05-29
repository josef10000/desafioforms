using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioWinForms01
{
    internal class Dados
    {
        public static List<string> realizarLeituraDoArquivo(string nomeDoArquivo)
        {
			try
			{
				StreamReader leitor = new StreamReader(nomeDoArquivo, Encoding.UTF8);
				List<string> lista = new List<string>();

                do
				{
					string linha = leitor.ReadLine();
					lista.Add(linha);
					
                } while (!leitor.EndOfStream);

                return lista;
			}
			catch (Exception)
			{

				MessageBox.Show("Falha ao ler o arquivo","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
        }
    }
}
