using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experiment.Model;

namespace Experiment.UserInterface
{
    class Controller
    {
        ExperimentManager manager = new ExperimentManager();


        public void experiment(int size, int repetitions, int order)
        {
            Order chosenOrder = new Order();

            switch (order){
                case 1:
                    chosenOrder = Order.Increasing;
                    break;
                case 2:
                    chosenOrder = Order.Decreasing;
                    break;
                case 3:
                    chosenOrder = Order.Random;
                    break;
            }



            manager.StartExperiment(size, repetitions, chosenOrder);
        }
    }
}
