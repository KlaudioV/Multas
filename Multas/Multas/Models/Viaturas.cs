﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Viaturas
    {
        public int ID { get; set; }

        public string Matricula { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public string NomeDono { get; set; }

        public string MoradaDono { get; set; }

        public string CodPostalDono { get; set; }

        //****************************************
        //Lista das Multas associadas à Viatura
        //****************************************

        public Collection<Multas> ListadeMultas { get; set; }
    }
}