using System.Collections.Generic;
using System.IO;

namespace SpeechSDK.Test.UI.Config
{
    public class SpeechConfig
    {
        #region Singleton

        /// <summary>
        /// Instância
        /// </summary>
        private static SpeechConfig instance;

        /// <summary>
        /// Semáforo para sincronismo
        /// </summary>
        private static readonly object mutex = new object();

        /// <summary>
        /// Instância
        /// </summary>
        public static SpeechConfig Instance
        {
            get
            {
                lock (mutex)
                {
                    if (instance == null)
                        Load();
                    return instance;
                }
            }
        }

        #endregion Singleton

        /// <summary>
        /// Path do arquivo ConfigPadrão
        /// </summary>
        public static void Load()
        {
            lock (mutex)
            {
                instance = XmlSerializer.Load<SpeechConfig>(PathConfig);
            }
        }

        /// <summary>
        /// Salva as configurações
        /// </summary>
        public static void Save()
        {
            instance.Save(PathConfig);
        }

        /// <summary>
        /// Cria um novo de arquivo de configuração com os dados padrões caso o mesmo não exista
        /// </summary>
        public static void CreateConfiguration()
        {
            var config = new SpeechConfig();
            if (!File.Exists(PathConfig))
                config.Save(PathConfig);
        }

        /// <summary>
        /// Caminho do arquivo de configuração
        /// </summary>
        public static string PathConfig
        {
            get
            {
                return Path.ChangeExtension(typeof(SpeechConfig).Assembly.Location, "xml");
            }
        }


        public List<ClasseModelo> Modelos { get; set; }

        public SpeechConfig()
        {
            Modelos = new List<ClasseModelo>();


//#if DEBUG
//            Modelos.Add(new ClasseModelo()
//            {
//                Nome = "Sidney",
//                Arquivos = new List<string>()
//                {
//                    @".\Audios\Sidney\audio_01.wav",
//                    @".\Audios\Sidney\audio_02.wav",
//                    @".\Audios\Sidney\audio_03.wav"
//                }
//            });

//            Modelos.Add(new ClasseModelo()
//            {
//                Nome = "Giovanni",
//                Arquivos = new List<string>()
//                {
//                    @".\Audios\Giovanni\audio_01.wav",
//                    @".\Audios\Giovanni\audio_02.wav",
//                    @".\Audios\Giovanni\audio_03.wav"
//                }
//            });

//            Modelos.Add(new ClasseModelo()
//            {
//                Nome = "Wellington",
//                Arquivos = new List<string>()
//                {
//                    @".\Audios\Wellington\audio_01.wav",
//                    @".\Audios\Wellington\audio_02.wav",
//                    @".\Audios\Wellington\audio_03.wav"
//                }
//            }); 
//#endif
        }
    }
}