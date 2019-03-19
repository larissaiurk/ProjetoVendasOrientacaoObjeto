using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasOsorioBLarissa.Model
{
    class Cliente
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime CriadoEm { get; set; }

        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " | CPF: " + Cpf;
        }

        public override bool Equals(object obj)
        {
            Cliente c = (Cliente)obj;
            if (c.Nome.Equals(Nome) && c.Cpf.Equals(Cpf))
            {
                return true;
            }
            return false;
        }


        //JAVA
        //private string nome;

        //public string getNome()
        //{
        //    return nome;
        //}
        //public void setNome(string nome)
        //{
        //    this.nome = nome;
        //}


    }
}
