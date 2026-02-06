using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_semana_3.Model;
using Trabajo_semana_3.Repositories;

namespace Trabajo_semana_3.ViewModel
{
    public partial class RegistroViewModel : ObservableObject
    {
        private readonly IRegistroInterface _repository;
        public ObservableCollection<Registro> Registros { get; set; } = new ObservableCollection<Registro>();

       [ObservableProperty]
        private int _totalRegistros;

        public RegistroViewModel(IRegistroInterface repository)
        {
            _repository = repository;
        }

        [RelayCommand]
        private void AgregarRegistro()
        {
            var nuevo = new Registro(32398248, "Edgar", "Isai26361@gmail.com");
            _repository.GuardarRegistro(nuevo);
            Registros.Add(nuevo);
        }

        [RelayCommand]
        private void MostrarTotal()
        {
            TotalRegistros = _repository.ConteoRegistro();
        }
    }
}