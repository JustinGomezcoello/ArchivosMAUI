using ArchivosMAUI.Interfaces;
using ArchivosMAUI.Models;
using ArchivosMAUI.Repositories;

namespace ArchivosMAUI
{
    public partial class MainPage : ContentPage
    {
        public IEstudianteUDLARepository _estudianteUdlaRepository;
        public EstudianteUDLA estudiante = new EstudianteUDLA();

        public MainPage()
        {
            InitializeComponent();
            _estudianteUdlaRepository = new EstudianteUdlaFilesRepository();   //aqui si quiero ahora hacer con base de datos pues tengo que llamar al repositorio nuevo de base de datos
            estudiante = _estudianteUdlaRepository.DevuelveInfoEstudiante(1);
            BindingContext = estudiante;
        }



        private async void btn_guardar_Clicked(object sender, EventArgs e)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA
            {
                Id = Int32.Parse(editor_id.Text),
                Nombre = editor_nombre.Text,
                Carrera = editor_carrera.Text
            };
            bool guardar = _estudianteUdlaRepository.CrearEstudianteUDLA(estudiante);
            if (guardar)
            {
                await DisplayAlert("Alerta", "Guardado Correctamnete", "Aceptar");
            }
            else
            {
                await DisplayAlert("Alerta", "Error al guardar", "Aceptar");
            }
            Navigation.PushAsync(new MainPage());
        }
    }

}
