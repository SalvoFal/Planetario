using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using classe_vettori;

namespace Planetario
{
    internal class Pianeti
    {
        public double Massa { get; set; }
        public Vettore Spostamento { get; set; }
        public Vettore Velocita { get; set; }
        public Brush Brush { get; set; }
        public Pianeti (double massa, Vettore spostamento, Vettore velocita, Brush brush)
        {
            Massa =massa;
            Spostamento =spostamento;
            Velocita =velocita;
            Brush =brush;
        }
    }
}
