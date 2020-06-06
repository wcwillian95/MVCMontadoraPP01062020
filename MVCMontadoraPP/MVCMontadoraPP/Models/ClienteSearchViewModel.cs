using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCMontadoraPP.Models.ModelsPesquisa
{
    public class ClienteSearchViewModel
    {
        public List<Cliente> Clientes { get; set; }
        public SelectList Genres { get; set; }
        public string ClienteGenre { get; set; }
        public string SearchString { get; set; }

    }
}
