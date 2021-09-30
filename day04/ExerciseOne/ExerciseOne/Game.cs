using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    class Game
    {
        private string name;
        private int winningProb = 100;
        private int energyLevel = 5;
        public string Name { get { return name; } set { name = value; } }
        public void FirstSpin()
        {
            energyLevel += 1;
            winningProb += 10;
        }
        public void SecondSpin()
        {
            energyLevel += 2;
            winningProb += 20;
        }
        public void ThirdSpin()
        {
            energyLevel -= 3;
            winningProb -= 30;
        }
        public void FourthSpin()
        {
            energyLevel += 4;
            winningProb += 40;
        }
        public void FifthtSpin()
        {
            energyLevel += 5;
            winningProb += 50;
        }
        public void SixthSpin()
        {
            energyLevel -= 1;
            winningProb -= 60;
        }
        public void SeventhtSpin()
        {
            energyLevel += 1;
            winningProb += 70;
        }
        public void EightSpin()
        {
            energyLevel -= 2;
            winningProb -= 20;
        }
        public void NinthSpin()
        {
            energyLevel -= 3;
            winningProb -= 30;
        }
        public void TenthSpin()
        {
            energyLevel += 10;
            winningProb += 100;
        }
        public string determinePrize()
        {
            if (energyLevel >= 4 && winningProb > 60)
            {
                return "Winner";
            }
            else if (energyLevel >= 1 && winningProb > 50)
            {
                return "Runner Up";
            }
            else
            {
                return "Looser";
            }
        }
    }
}
