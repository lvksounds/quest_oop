using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace questionarioOOP.Models
{
    public abstract class formaDoisD
    {
        public float PI { get; } = 3.1415926f;
        public Cor cor { get; set; }

        public abstract float obterArea();
    }
}
