namespace Fundamentos_part2.Models
{
    public class Curso
    {

        public string Nome{ get; set; }

        public List<Pessoa> Alunos { get; set; }

       



        public void AdicionarAluno(Pessoa aluno) //adiciona alunos a coleção de lista
        {
            Alunos.Add(aluno);
        }
        

        public void RemoverAluno(Pessoa aluno)
        {

            Alunos.Remove(aluno);
        }


        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno);
            }
        }

        public int ObterAlunosMatriculados()
        {
            int quantidades = Alunos.Count(); //metodo Count usando para obter a quantidade de alunos
            return quantidades;
        }

    }
}