using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleta
{
    public class Triatleta:Atleta
    {

        public override void Habilidades()
        {
            //base.Habilidades();
            MessageBox.Show("Correr,pedalar e nadar");
        }

        public override void acao()
        {
            MessageBox.Show("O atleta está correndo, pedalando e nadando.");

        }

    }
}
