using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechSDK.Model
{
    /// <summary>
    /// Classe que representa um modelo de audio
    /// </summary>
    public class AudioModel
    {
        /// <summary>
        /// Identificador do modelo
        /// </summary>
        public Guid IdentificadorModelo { get; private set; }

        /// <summary>
        /// Arquivos de audio
        /// </summary>
        public List<string> Audios { get; private set; }

        public AudioModel()
        {
            Audios = new List<string>();
            IdentificadorModelo = Guid.NewGuid();
        }

        public AudioModel(params string[] audios):this()
        {
            Audios.AddRange(audios);
        }
    }
}
