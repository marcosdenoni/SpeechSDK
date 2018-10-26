using Accord.Neuro;
using Accord.Neuro.Learning;
using Accord.Neuro.Networks;
using SpeechSDK.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private Dictionary<Guid, AudioModel> _classes;

        public SpeechCore()
        {
            _classes = new Dictionary<Guid, AudioModel>();
        }

        public void AdicionarModelo(AudioModel modelo)
        {
            if (!_classes.ContainsKey(modelo.IdentificadorModelo))
                _classes.Add(modelo.IdentificadorModelo, modelo);
            else
                throw new ArgumentException("Modelo já cadastrado.");
        }

        public void Treinar()
        {
            int inputCount = 13 * 10;

            var activationNetwork = new ActivationNetwork(new SigmoidFunction(0.5), inputCount, 7, _classes.Count);
            //var supervisedLearning = new PerceptronLearning(activationNetwork);
            var supervisedLearning = new BackPropagationLearning(activationNetwork);
            supervisedLearning.LearningRate = 0.6;


            int indice = 0;

            int treinamento = -1;

            var entrada = new List<double[]>();
            var saida = new List<double[]>();

            foreach (var modelo in _classes)
            {
                modelo.Value.SaidaEsperada = ObterSaidaEsperada(indice++);

                int contadorTreinamento = 0;

                foreach (var caracteristicas in modelo.Value.ObterCaracteristicas(inputCount))
                {
                    entrada.Add(caracteristicas);
                    saida.Add(modelo.Value.SaidaEsperada);

                    //var erroAbsoluto = perceptronLearning.Run(caracteristicas, modelo.Value.SaidaEsperada);

                    if (treinamento == contadorTreinamento++)
                        break;
                }
            }

            var entradaArray = entrada.ToArray();
            var saidaArray = saida.ToArray();

            var resultado = supervisedLearning.RunEpoch(entradaArray, saidaArray);

            //activationNetwork.Randomize();

            Testar(activationNetwork, inputCount, @".\Audios\Giovanni", @".\Audios\Giovanni\audio_03.wav");
            Testar(activationNetwork, inputCount, @".\Audios\Sidney", @".\Audios\Sidney\audio_04.wav");

            //Testar(activationNetwork, inputCount, @".\Audios\Giovanni", @".\Audios\Giovanni\audio_03.wav");
            //Testar(activationNetwork, inputCount, @".\Audios\Sidney", @".\Audios\Sidney\audio_04.wav");
        }

        private void Testar(ActivationNetwork activationNetwork, int inputCount, string baseCaminho, string arquivo)
        {
            var classe = _classes.First(c => c.Value.Audios.Any(a => a.StartsWith(baseCaminho)));

            Debug.Write($"Saida esperada: ");

            ImprimirVetor(classe.Value.SaidaEsperada);

            var teste2 = AudioModelHelper.ObterCaracteristicas(arquivo, inputCount);

            foreach (var item in teste2)
            {
                var saida = activationNetwork.Compute(item);

                //Debug.WriteLine($"'{saida[0]}', '{saida[1]}', '{saida[2]}'");

                Imprimir(saida);

                ImprimirVetor(saida);
            }
        }

        private void ImprimirVetor(double[] vetor)
        {
            foreach (var item in vetor)
                Debug.Write($"{item}, ");
            Debug.WriteLine("");
        }

        private void Imprimir(double[] vetor)
        {

            int maior = 0;
            double valor = vetor[0];

            for (int i = 0; i < vetor.Length; i++)
            {
                //Debug.Write($"'{vetor[i]}',");

                if (vetor[i] > valor)
                {
                    valor = vetor[i];
                    maior = i;
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (maior == i)
                    Debug.Write($"1,");
                else
                    Debug.Write($"0,");
            }

            Debug.Write($" | ");
            //Debug.WriteLine("");
        }

        private double[] ObterSaidaEsperada(int v)
        {
            var saida = new double[_classes.Count];

            saida[v] = 1;

            return saida;
        }
    }
}
