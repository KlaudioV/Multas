using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Agentes
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Esquadra { get; set; }

        public string Fotografia { get; set; }

        //****************************************
        //Lista das Multas associadas aos Agentes
        //****************************************

        public Collection<Multas> ListadeMultas { get; set; }
    }
}