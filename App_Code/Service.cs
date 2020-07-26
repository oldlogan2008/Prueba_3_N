using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    int IService.Metodo(int Boleta1, int Boleta2)
    {
        if (Boleta1 >= Boleta2)
        {
            if (Boleta2 == 0)
            {
                return -1;
            }

            else
            {
                return Boleta1 % Boleta2;
            }
        }

        else
        {
            if (Boleta1 == 0)
            {
                return -1;
            }

            else
            {
                return Boleta2 % Boleta1;
            }
        }
    }

}