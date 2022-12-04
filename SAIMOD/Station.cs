using SAIMOD.Observer;

namespace SAIMOD
{
    internal class Station : IObserver
    {
        public Queue<Train> MainQueue { get; set; } = new Queue<Train>();
        public Queue<Train> ExternQueue { get; set; } = new Queue<Train>();
        public double SummaryFine { get; set; }
        public bool Bool { get; set; } = false;

        public virtual void AddTrain(Train train)
        {
            if (MainQueue.Count < 3)
            {
                MainQueue.Enqueue(train);
            }
            else
            {
                ExternQueue.Enqueue(train);
            }
        }
        public void NextMin()
        {

            if (MainQueue.Count > 0)
            {
                MainQueue.Peek().RemainingTime--;
            }
            foreach (Train train in ExternQueue)
            {
                train.Fine += 1000.0 / 60.0;
                //    train.Prostoi++;
                //    if (train.Prostoi > 60)
                //    {
                //        //train.Fine = 1000;
                //        SummaryFine += 1000;
                //        train.Prostoi = 0;
                //    }
                //    //train.Prostoi++;
                //    //if (train.Prostoi > 60)
                //    //{
                //    //    SummaryFine += 1000;
                //    //    Bool = true;
                //    //    break;
                //    //}
                //}
                //if (Bool)
                //{
                //    foreach (Train train in ExternQueue)
                //    {
                //        train.Prostoi = 0;
                //    }
                //    Bool = false;
            }
        }

        public void Update()
        {
            MainQueue.Dequeue();
            if (ExternQueue.Count > 0)
            {
                var item = ExternQueue.Dequeue();
                MainQueue.Enqueue(item);
                SummaryFine += item.Fine;
            }
        }
    }
}
