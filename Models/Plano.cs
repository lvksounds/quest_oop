using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionarioOOP.Models
{
    public class Plano
    {
        public formaDoisD FormaDoisD { get; set; }

        public bool AttachFigura(formaDoisD figure)
        {
            if (figure == null) return false;

            FormaDoisD = figure;
            return true;
        }


        public bool DetachFigure()
        {
            if (FormaDoisD != null)
            {
                FormaDoisD = null;
                return true;
            }
            return false;
        }
    }
}
