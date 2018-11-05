using System.IO;

namespace SpeechSDK.Test.UI.Config
{
    /// <summary>
    /// Classe de serialização de configuração
    /// </summary>
    public static class XmlSerializer
    {
        #region Serialização Config

        /// <summary>
        /// Salva as configurações
        /// </summary>
        public static void Save<T>(this T obj, string path, bool backupXML = true)
        {
            System.Xml.Serialization.XmlSerializer xserialize = new System.Xml.Serialization.XmlSerializer(typeof(T));

            if (File.Exists(path) && backupXML)
                File.Copy(path, Path.ChangeExtension(path, "bkp"), true);

            using (FileStream writer = new FileStream(path, FileMode.Create))
            {
                xserialize.Serialize(writer, obj);
            }
        }

        /// <summary>
        /// Carrega as configurações
        /// </summary>
        public static T Load<T>(string path = null)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Não foi possivel localizar o arquivo do {path}");

            System.Xml.Serialization.XmlSerializer xserialize = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return (T)xserialize.Deserialize(reader);
            }
        }

        #endregion Serialização Config
    }
}