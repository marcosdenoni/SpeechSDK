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

        public SpeechCore()
        {
            _modelos = new Dictionary<Guid, AudioModel>();
        }

        public void AdicionarModelo(AudioModel modelo)
        {
            if (!_modelos.ContainsKey(modelo.IdentificadorModelo))
                _modelos.Add(modelo.IdentificadorModelo, modelo);
            else
                throw new ArgumentException("Modelo já cadastrado.");
        }

        public void Treinar()
        {
            int inputCount = 1400;

            var activationNetwork = new ActivationNetwork(new ThresholdFunction(), inputCount, _modelos.Count);
            var perceptronLearning = new PerceptronLearning(activationNetwork);
            //perceptronLearning.LearningRate = this.learningRate;

            foreach (var modelo in _modelos)
            {
                var saidaEsperada = modelo.Value.ObterSaidaEsperada();

                foreach (var caracteristicas in modelo.Value.ObterCaracteristicas(inputCount))
                {
                    var erroAbsoluto = perceptronLearning.Run(caracteristicas, saidaEsperada);

                }
            }

        }
    }
}
