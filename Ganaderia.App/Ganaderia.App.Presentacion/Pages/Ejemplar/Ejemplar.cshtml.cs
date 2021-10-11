using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Presentacion.Pages
{
    public class EjemplarModel : PageModel
    {
        //Llamamos instancia del Repo Ejemplar para traer datos de la BD
        private static IRepositorioEjemplar _repoEjemplar= new RepositorioEjemplar(new Persistencia.AppContext());
        
        public Ejemplar ejemplar { get; set; }
        
        
        public IActionResult OnGet(int ejemplarId)
        {
            ejemplar = _repoEjemplar.GetEjemplar(ejemplarId);
            if(ejemplar==null)
            {
                return RedirectToPage("./Error");
            }else
            {
                return Page();
            }
        }
    }
}
