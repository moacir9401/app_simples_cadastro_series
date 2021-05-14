using System;

namespace DIO.series
{
  class Program
  {
    static SerieRepositorio repositorio = new SerieRepositorio();
    static void Main(string[] args)
    {

      var opcaoUsuario = OlbterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {

        switch (opcaoUsuario)
        {
          case "1":
            ListaSerie();
            break;
          case "2":
            Inserirserie();
            break;
          case "3":
            AtualizarSerie();
            break;
          case "4":
            ExcluirSerie();
            break;
          case "5":
            VisualizarSerie();
            break;
          case "C":
            Console.Clear();
            break;

          default:
            throw new ArgumentOutOfRangeException();
            break;
        }
      }
    }

    private static void VisualizarSerie()
    {
        System.Console.WriteLine("Digite o id da série");
       int indiceSerie = int.Parse(Console.ReadLine());

       var serie = repositorio.RetornarPorId(indiceSerie);

       System.Console.WriteLine(serie);
    }
  
    private static void ExcluirSerie()
    {
        System.Console.WriteLine("Digite o id da série");
       int indiceSerie = int.Parse(Console.ReadLine());

       repositorio.excluir(indiceSerie);
    }

    private static void AtualizarSerie()
    {
       System.Console.WriteLine("Digite o id da série");
       int indiceSerie = int.Parse(Console.ReadLine());

      foreach (var i in Enum.GetValues(typeof(Genero)))
      {
        System.Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
      }
      System.Console.WriteLine("Digite o gênero entre as opções acima: ");
      int entradaGenero = int.Parse(Console.ReadLine());

      System.Console.WriteLine("Digite o Título da Série: ");
      string entradaTitulo = Console.ReadLine();

      System.Console.WriteLine("Digite o Ano de Início da Série: ");
      int entradaAno = int.Parse(Console.ReadLine());

      System.Console.WriteLine("Digite a Descrição da Série");
      string entradaDescricao = Console.ReadLine();

      Serie atualizaSerie = new Serie(id: repositorio.ProximoId(),
                                  genero: (Genero)entradaGenero,
                                  titulo: entradaTitulo,
                                  ano: entradaAno,
                                  descricao: entradaDescricao);

      repositorio.Atualizar(indiceSerie,atualizaSerie);
    }

    private static void Inserirserie()
    {
      System.Console.WriteLine("Inserir nova série");

      foreach (var i in Enum.GetValues(typeof(Genero)))
      {
        System.Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
      }
      System.Console.WriteLine("Digite o gênero entre as opções acima: ");
      int entradaGenero = int.Parse(Console.ReadLine());

      System.Console.WriteLine("Digite o Título da Série: ");
      string entradaTitulo = Console.ReadLine();

      System.Console.WriteLine("Digite o Ano de Início da Série: ");
      int entradaAno = int.Parse(Console.ReadLine());

      System.Console.WriteLine("Digite a Descrição da Série");
      string entradaDescricao = Console.ReadLine();

      Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                  genero: (Genero)entradaGenero,
                                  titulo: entradaTitulo,
                                  ano: entradaAno,
                                  descricao: entradaDescricao);

      repositorio.Inserir(novaSerie);
    }

    private static void ListaSerie()
    {
      System.Console.WriteLine("Listar séries");

      var lista = repositorio.lista();

      if (lista.Count == 0)
      {
        System.Console.WriteLine("Nenhuma série cadastrada.");
      }

      foreach (var serie in lista)
      {
        System.Console.WriteLine($"#ID {serie.retornaId()}, {serie.retornaTitulo()}");
      }
    }

    private static string OlbterOpcaoUsuario()
    {
      System.Console.WriteLine();
      System.Console.WriteLine("Dio Séries a seu dispor !!!");
      System.Console.WriteLine("1 - Listar Séries");
      System.Console.WriteLine("2 - Inserir novas serie");
      System.Console.WriteLine("3 - Atualizar series");
      System.Console.WriteLine("4 - excluir serie");
      System.Console.WriteLine("5 - Visualizar series");
      System.Console.WriteLine("C - Limpar Tela");
      System.Console.WriteLine("x - Sair");

      var opcaoUsuario = System.Console.ReadLine().ToUpper();
      System.Console.WriteLine();
      return opcaoUsuario;
    }
  }
}
