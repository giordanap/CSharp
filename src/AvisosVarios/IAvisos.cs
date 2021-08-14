using System;
using System.Collections.Generic;
using System.Text;

namespace AvisosVarios
{
    interface IAvisos
    {
        // Con esto se obliga a crear los metodos
        void MostrarAvisos();
        string GetFecha();

    }
}
