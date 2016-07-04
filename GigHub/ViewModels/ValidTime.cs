using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        /* M�todo que verificar� se a hora inclusa pelo usu�rio � nulo ou
         * v�lido */
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), 
                "HH:mm", 
                CultureInfo.CurrentCulture, 
                DateTimeStyles.None,
                out dateTime);
            
            return (isValid);
        }
    }
}