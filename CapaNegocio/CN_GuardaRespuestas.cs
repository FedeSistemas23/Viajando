﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_GuardaRespuestas
    {
        CD_GuardaRespuestas guardarespuestas = new CD_GuardaRespuestas();
        public void GuardarRespuestas()
        {
            guardarespuestas.GuardarRespuestas();
        }
    }
}
