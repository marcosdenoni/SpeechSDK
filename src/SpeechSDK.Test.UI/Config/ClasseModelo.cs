using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechSDK.Test.UI.Config
{
    public class ClasseModelo
    {
        public string Nome { get; set; }

        public int Quantidade { get => Arquivos.Count; }

        public List<string> Arquivos { get; set; }

        public ClasseModelo()
        {
            Arquivos = new List<string>();
        }
    }
}
