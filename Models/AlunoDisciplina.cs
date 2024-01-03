using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() {}
        public AlunoDisciplina(int alunoID, int disciplinaID) 
        {
            this.AlunoID = alunoID;
            this.DisciplinaID = disciplinaID;
   
        }
                public int AlunoID { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaID { get; set; }
        public Disciplina Disciplina { get; set; }

    }
}