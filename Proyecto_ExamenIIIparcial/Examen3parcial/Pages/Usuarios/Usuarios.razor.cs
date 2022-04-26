
using Examen3parcial.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;
partial class Usuarios
    {
        [Inject] private IUsuarioServicios _usuarioServicio { get; set; }

        private IEnumerable<Usuario> usuariosLista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            usuariosLista = await _usuarioServicio.GetLista();
        }

    }
}
