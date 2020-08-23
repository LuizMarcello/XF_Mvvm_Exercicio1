using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XF_Mvvm_Exercicio1.Models;

namespace XF_Mvvm_Exercicio1.ViewModels
{
    public class AlunoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Aluno> _listaAlunos;
        public List<Aluno> ListaAlunos
        {
            get { return _listaAlunos; }
            set { _listaAlunos = value;
                onPropertyChanged();
            }
        }

        public AlunoViewModel()
        {
            var alunosService = new AlunosService();
            _listaAlunos = alunosService.GetAlunos();
        }

        protected virtual void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

               




