using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Professor
    {
        public Professor(){}
        public Professor(int id, string nome) 
        {
            this.Id = id;
            this.Nome = nome;
   
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplina { get; set; }
    }
}