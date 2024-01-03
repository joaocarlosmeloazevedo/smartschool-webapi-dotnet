using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Aluno
    {
        public Aluno() { }

        public Aluno(int id, string sobrenome, string telefone, string nome) 
        {
            this.Id = id;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
            this.Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas {get; set;}
    }
}
