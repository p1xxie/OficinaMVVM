﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OficinaMVVM.Models
{
    public class AtendimentoFoto
    {
        public long? AtendimentoFotoID { get; set; }
        public long? AtendimentoID { get; set; }
        public byte[] ConteudoFoto { get; set; }
        public string CaminhoFoto { get; set; }
        public string Observacoes { get; set; }
        //public Atendimento Atendimento { get; set; }

        public string  NomeArquivo { get; set; }
    }
}

