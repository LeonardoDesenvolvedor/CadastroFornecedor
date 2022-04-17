

using CadastroFornecedor.Models;

namespace CadastroFornecedor.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuider)
        {
            using (var serviceScope = applicationBuider.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();




                // CRIAÇÃO DE DADOS INICIAL 


                // inicialização de dados na tbl Fornecedor

                if (!context.Fornecedores.Any())
                {
                    for (int cont = 0; cont < 5; cont++)
                    {
                        context.Fornecedores.AddRange(new List<Fornecedor>()
                        {
                          new Fornecedor()
                           {
                            Nome = "Teste Nome Teste",
                           }
                       });
                        context.SaveChanges();
                    }
                }



                // inicialização de dados na tbl Empresa

                if (!context.Empresas.Any())
                {
                    for (int cont = 0; cont < 5; cont++)
                    {
                        context.Empresas.AddRange(new List<Empresa>()
                            {

                                new Empresa()
                                  {
                                    RazaoSocial = "Empresa teste",
                                    NomeFantasia = "Fantasia teste ",
                                    Email = "empresateste@teste",
                                 }
                        });
                        context.SaveChanges();
                    }
                }

                        // inicialização de dados na tabela Endereco

                if (!context.Enderecos.Any())
                {
                    for (int cont = 0; cont < 5; cont++)
                    {
                        context.Enderecos.AddRange(new List<Endereco>()
                        {
                             new Endereco()
                             {
                                 Referente = "Empresa teste",
                                 Cidade = "Cidade teste ",
                                 Bairro = "Bairro teste",
                                 Cep = "000000",
                                 Logradouro = "Local teste",
                                 Numero = "000000",
                             }
                       });
                        context.SaveChanges();
                    }
                 }


            }  
        }   
    }
}
