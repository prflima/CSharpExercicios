using System;
using NetOffice.ExcelApi;
using System.IO;

namespace PrimeiroExcel
{
    public class ArquivoExcel
    {
        public int codigo;
        public string nome;
        public string marca;
        public int quantidade;
        public double preco;

        public string Salvar()
        {
            //Vamos declarar os objetos que iremos utilizar

            Application ex = new Application();

            //Vamos saber se o arquivo existe ou não
            //com o objeto do FileInfo

            FileInfo ar = new FileInfo(@"C:\temp\produtos.xlsx");
            if (!ar.Exists)//O "!" de inicio no comando if, é um comando de negação "Se o arquivo não existe"
            {
                //Abrir o excel
                ex.Visible = true;
                //Vamos adicionar uma pasta de trabalho ao excel
                ex.Workbooks.Add();
                ex.Range("A1").Value = "Product table";
                //Vamos formatar o título, mudando a letra,
                //tamanho e o estilo para negrito.
                ex.Range("A1").Font.Name = "Verdana";
                ex.Range("A1").Font.Size = "20";
                ex.Range("A1").Font.Bold = true; //Negrito

                //Mesclar e Centralizar o Título
                ex.Range("A1:E1").MergeCells = true;

                //Montar o cabeçalho de colunas
                ex.Range("A2").Value = "Code Product"; //Código
                ex.Range("B2").Value = "Name";//Nome
                ex.Range("C2").Value = "Brand";//Marca
                ex.Range("D2").Value = "Amount";//Quantidade
                ex.Range("E2").Value = "Price";//Preço

                //Aplicar Negrito ao cabeçalho
                ex.Range("A2:E2").Font.Bold = true;
                ex.Range("A2:E2").Font.Underline = true;//Sublinhar o cabeçalho.
                ex.Range("A2:E2").Font.Size = "14";//Formatando tamanho do cabeçalho.

                //Adicionar os dados que o cliente digitou
                ex.Range("A3").Value = codigo;
                ex.Range("B3").Value = nome;
                ex.Range("C3").Value = marca;
                ex.Range("D3").Value = quantidade;
                ex.Range("E3").Value = preco;

                //Ajustar a largura das colunas
               // ex.Cells.AutoFit();


                //Salvar o arquivo de excel
                ex.ActiveWorkbook.SaveAs(@"C:\temp\produtos.xlsx");

            }
            else
            {
                ex.Visible = true;
                ex.Workbooks.Open(@"C:\temp\produtos.xlsx");

                for (int x = 4; x <= 100; x++)
                {
                    if (ex.Range("A" + x).Value == null)
                    {
                        ex.Range("A" + x).Value = codigo;
                        ex.Range("B" + x).Value = nome;
                        ex.Range("C" + x).Value = marca;
                        ex.Range("D" + x).Value = quantidade;
                        ex.Range("E" + x).Value = preco;
                        /*Depois de preencher as células acima
                        vamos sair do laço FOR.
                        Para isso iremos usar o comando break; */
                        break;
                    }//Fim do IF                    
                }//Fim do For
                ex.Range("E:E").CurrentRegion.Select();//Passar para moeda.
                ex.Cells.AutoFit();//Ajustando as colunas
                ex.ActiveWorkbook.Save();//Salvando as informações
            }
            ex.Quit();//Fechar o Excel
            return "Save Sucessfully!";


        }
    }
}