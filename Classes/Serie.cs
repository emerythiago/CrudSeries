using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {   
        //Atributo
        private Genero genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }


        private bool Excluido { get; set; }

        //Metodo

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;

        }

        public Serie(int id, Genero genero, string titulo, int ano)
        {
            Id = id;
            this.genero = genero;
            Titulo = titulo;
            Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;

            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir ()
        {
            this.Excluido = true;
        }
    }

}