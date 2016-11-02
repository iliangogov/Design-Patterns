using System;

namespace ChainOfResponsibilityDemo
{
    public class MediumGye : HeavyMover
    {
        public override void MoveStone(Stone stone)
        {
            if (stone.WeightInKg < 60)
            {
                Console.WriteLine(
                    "{0} has moved the Stone because he can lift {1}kg",
                    this.GetType().Name,
                    stone.WeightInKg);
            }
            else if (this.Successor != null)
            {
                this.Successor.MoveStone(stone);
            }
        }
    }
}
