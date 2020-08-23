using System;
using System.Collections.Generic;
using System.Text;

namespace XF_Mvvm_Exercicio1.Models
{
    public class AlunosService
    {
        //Assim é apenas uma "propriedade" do tipo "List Aluno":
        //public List<Aluno> GetAlunos;

        //Assim é um "método" do tipo "List Alunos", que retorna uma lista:
        public List<Aluno> GetAlunos()
        {
            //Criando uma lista dentro deste método, e já instanciando com o tipo List<Aluno>.
            var lista = new List<Aluno>
            {
                //Acrecentando itens nesta lista;
                new Aluno
                {
                    Nome = "Macoratti",
                    Nota = "B+"
                },
                new Aluno
                {
                    Nome = "Jefferson",
                    Nota = "B",
                },
                new Aluno
                {
                    Nome = "Janice",
                    Nota = "C+"
                },
                new Aluno
                {
                    Nome = "Jessica",
                    Nota = "A"
                }
            };
            return lista;
        }
    }
}




