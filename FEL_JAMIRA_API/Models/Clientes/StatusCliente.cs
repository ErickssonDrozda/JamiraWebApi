﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FEL_JAMIRA_API.Models.Clientes
{
    public class StatusCliente
    {
        public int IdSolicitacao { get; set; }
        public string Status{ get; set; }
        public string Estaciomento { get; set; }
        public string Endereco { get; set; }
        public bool InProgress { get; set; }
    }
}