using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazada
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private string isbn;

        public Libro(string titulo, string autor, string isbn)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
        }

        public string getTitulo() { return titulo; }
        public void setTitulo(string titulo) { this.titulo = titulo; }
        public string getAutor() { return autor; }
        public void setAutor(string autor) { this.autor = autor; }
        public string getIsbn() { return isbn; }
        public void setIsbn(string isbn) { this.isbn = isbn; }

    }
}
