using Accord.Neuro;
using Accord.Neuro.Learning;
using SpeechSDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechSDK
{
    public class SpeechCore
    {
        /// <summary>
        /// Dicionario de modelos conhecidos
        /// </summary>
        private Dictionary<Guid, AudioModel> _modelos;

        public void AdicionarModelo(AudioModel modelo)
        {
            if (!_modelos.ContainsKey(modelo.IdentificadorModelo))
                _modelos.Add(modelo.IdentificadorModelo,modelo);
            else
                throw new ArgumentException("Modelo já cadastrado.");
        }

        public void Treinar()
        {
            var activationNetwork = new ActivationNetwork(new ThresholdFunction(), 15, _modelos.Count);
            var perceptronLearning = new PerceptronLearning(activationNetwork);
            //perceptronLearning.LearningRate = this.learningRate;

            //perceptronLearning.RunEpoch
        }
    }
}
