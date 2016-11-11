using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Base.Exceptions
{
    public class ExceptionMapper : IExceptionMapper
    {
        public string MapException(string exception)
        {
            //if (exception.Contains("UK_PushCampaignCode_UserID") || exception.Contains("UK_PullCampaignCode_UserID"))
            //    return "Ya existe una campaña con el código especificado.";

            //if (exception.Contains("UK_MobileNumber_UserID"))
            //    return "Ya existe un contacto activo con ese número de teléfono.";

            //if (exception.Contains("UK_UserName"))
            //    return "El nombre de usuario ya está siendo utilizado.";

            //if (exception.Contains("UK_Email"))
            //    return "La dirección de e-mail ya está siendo usada para otra cuenta.";

            //if (exception.Contains("UK_MobileNumber"))
            //    return "El número de teléfono ya está siendo usada para otra cuenta.";

            //if (exception.Contains("UK_Description_UserId"))
            //    return "Ya existe un grupo de contactos con esa descripción.";

            //if (exception.Contains("UK_Description"))
            //    return "Ya existe una Landing Page con esa descripción.";


            //if (exception.Contains("DELETE") && exception.Contains("DELETE"))
            //    return "No es posible realizar la eliminación ya que existen registros relacionados que deberían ser borrados antes.";

            return exception;
        }
    }
}