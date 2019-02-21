using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TagHelpersRazo.Models;

namespace TagHelpersRazo.Pages
{
    public class FormularioModel : PageModel
    {
        [BindProperty]
        public Persona Persona { get; set;}

        public List<SelectListItem> PreguntasSeguridad
        {
            get
            {
                string escogido = Persona?.Pregunta;
                var preguntas = ObtenerPreguntaDeSeguridad();
                var opciones = new List<SelectListItem>();
                foreach (var pregunta in preguntas)
                {
                    opciones.Add(new SelectListItem()
                    {
                        Text = pregunta,
                        Value = pregunta,
                        Selected = pregunta == escogido
                    });
                }

                return opciones;
            }
        }

        public void OnGet()
        {

        }
        
        private List<string> ObtenerPreguntaDeSeguridad()
        {
            return new List<string>
            {
                "¿Cual es la nacionalidad de su perro?",
                "¿Pepsi o Coca cola?",
                "¿Nombre de una persona que usted no conoce?"
            };
        }

        public void OnPost()
        {

        }

        [ValidateAntiForgeryToken]
        public void OnPostConToken()
        {

        }
    }
}