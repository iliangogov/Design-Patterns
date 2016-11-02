namespace ChainOfResponsibilityDemo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            HeavyMover litleMan = new SmallGye();
            HeavyMover mediumMan = new MediumGye();
            HeavyMover bigMan = new BigGye();

            litleMan.SetSuccessor(mediumMan);
            mediumMan.SetSuccessor(bigMan);

            var smallStone = new Stone(20);
            litleMan.MoveStone(smallStone);

            var mediumStone = new Stone(40);
            litleMan.MoveStone(mediumStone);

            var hugeStone = new Stone(100);
            litleMan.MoveStone(hugeStone);
        }
    }
}
