using System;

namespace DIO.series
{
  public class serie : EntidadeBase
  {
       private Genero genero {get;set;}
       private string Titulo {get;set;}
       private string Descricao {get;set;}
       private int Ano {get;set;}

       public serie(int id, Genero genero, string titulo, string descricao, int ano)
       {
           this.Id = id;
           this.genero = genero;
           this.Titulo = titulo;
           this.Descricao = descricao;
           this.Ano = ano;
       }

    public override string ToString()
    {
      return $"Gênero: {this.genero + Environment.NewLine}"+
             $"Titulo: {this.Titulo + Environment.NewLine}"+
             $"Descrição: {this.Descricao + Environment.NewLine}"+
             $"Ano de Inicio: {this.Ano}";
    }

    public string retornaTitulo(){
        return this.Titulo;
    }

    public int retornaId(){
        return this.Id;
    }
  }
}