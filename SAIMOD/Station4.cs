using SAIMOD.Observer;

namespace SAIMOD
{
    internal class Station4 : Station
    {
        public override void AddTrain(Train train)
        {
            if (MainQueue.Count < 4)
            {
                MainQueue.Enqueue(train);
            }
            else
            {
                ExternQueue.Enqueue(train);
            }
        }
    }
}
