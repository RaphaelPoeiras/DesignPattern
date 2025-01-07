using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.Domain
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Mensalidade { get; set; }
        public Aluno(int id, string nome, decimal mensalidade)
        {
            Id = id;
            Nome = nome;
            Mensalidade = mensalidade;
        }
    }
}