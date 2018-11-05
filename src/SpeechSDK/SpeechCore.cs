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
            int msSegmentos = 100;

            int tamanhoEntrada = (msSegmentos / 10 + 1) * 13;//1 segundo = 100 valores MFCC, cada valor com 14 dados

            //var activationNetwork = new ActivationNetwork(new ThresholdFunction(), tamanhoEntrada, _classes.Count);
            //var supervisedLearning = new PerceptronLearning(activationNetwork);

            var activationNetwork = new ActivationNetwork(new SigmoidFunction(0.5), tamanhoEntrada,  _classes.Count);
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

                foreach (var caracteristicas in modelo.Value.ObterCaracteristicas(msSegmentos))
                {
                    entrada.Add(caracteristicas);
                    saida.Add(modelo.Value.SaidaEsperada);

                    //var erroAbsoluto = supervisedLearning.Run(caracteristicas, modelo.Value.SaidaEsperada);

                    if (treinamento == contadorTreinamento++)
                        break;
                }
            }

            var entradaArray = entrada.ToArray();
            var saidaArray = saida.ToArray();

            var resultado = supervisedLearning.RunEpoch(entradaArray, saidaArray);

            Testar(activationNetwork, msSegmentos, @".\Audios\Giovanni", @".\Audios\Giovanni\audio_02.wav");
            Testar(activationNetwork, msSegmentos, @".\Audios\Giovanni", @".\Audios\Giovanni\audio_03.wav");

            Testar(activationNetwork, msSegmentos, @".\Audios\Sidney", @".\Audios\Sidney\audio_03.wav");
            Testar(activationNetwork, msSegmentos, @".\Audios\Sidney", @".\Audios\Sidney\audio_04.wav");

            Testar(activationNetwork, msSegmentos, @".\Audios\Wellington", @".\Audios\Wellington\audio_03.wav");
        }

        private void Testar(ActivationNetwork activationNetwork, int inputCount, string baseCaminho, string arquivo)
        {
            var classe = _classes.First(c => c.Value.Audios.Any(a => a.StartsWith(baseCaminho)));

            Debug.Write($"{baseCaminho} Saida esperada: ");

            ImprimirVetor(classe.Value.SaidaEsperada);

            var teste2 = AudioModelHelper.ObterCaracteristicas(arquivo, inputCount);

            var media = new int[_classes.Count];

            foreach (var item in teste2)
            {
                var saida = activationNetwork.Compute(item);

                //Debug.WriteLine($"'{saida[0]}', '{saida[1]}', '{saida[2]}'");

                var impressao = Imprimir(saida);

                for (int i = 0; i < _classes.Count; i++)
                {
                    media[i] += impressao[i];
                }

                ImprimirVetor(saida);
            }

            Debug.Write("Média: ");
            ImprimirVetor(media);
        }

        private void ImprimirVetor<T>(T[] vetor, bool pularLinha = true)
        {
            foreach (var item in vetor)
                Debug.Write($"{item}, ");

            if (pularLinha)
                Debug.WriteLine("");
        }

        private int[] Imprimir(double[] vetor)
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

            var tmpVector = new int[vetor.Length];
            tmpVector[maior] = 1;
            ImprimirVetor(tmpVector, false);

            Debug.Write($" | ");

            return tmpVector;
        }

        private double[] ObterSaidaEsperada(int v)
        {
            var saida = new double[_classes.Count];

            saida[v] = 1;

            return saida;
        }
    }
}
