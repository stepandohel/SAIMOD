
using SAIMOD.Observer;

namespace SAIMOD
{
    internal class Train : IObservable
    {
        private int remainingTime;
        public int RemainingTime
        {
            get
            {
                return remainingTime;
            }
            set
            {
                remainingTime = value;
                if (remainingTime == 0)
                {
                    NotifyObservers();
                }
            }
        }
        public double Fine { get; set; }
        public int Prostoi { get; set; }
        private IObserver _observer;

        public Train(IObserver observer)
        {
            _observer = observer;
        }
        public Train(IObserver observer, int time)
        {
            _observer = observer;
            remainingTime = time;
        }

        public void AddObserver(IObserver o)
        {
            _observer = o;
        }

        public void RemoveObserver(IObserver o)
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            _observer.Update();
        }
    }
}
