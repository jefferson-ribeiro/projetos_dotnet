using System.Collections.Generic;

namespace console5
{
  internal class Aluno
  {
    public string NomeAluno { get; set; }
    public string MatriculaAluno { get; set; }
    public int QtdNotasAluno { get; set; }
    public List<double> Notas = new List<double>();
  }

}