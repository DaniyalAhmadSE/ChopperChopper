using System;

namespace ChopperChopper.Services
{
    public class Randomizer
    {
        public Randomizer(int minPoint, int maxPoint, int change, int currentPoint)
        {
            MinPoint = minPoint;
            MaxPoint = maxPoint;
            Change = change;
            CurrentPoint = currentPoint;
            CurrentInvertedPoint = currentPoint;
        }

        public int MinPoint { get; set; }
        public int MaxPoint { get; set; }
        public int Change { get; set; }
        public int CurrentPoint { get; set; }
        public int CurrentInvertedPoint { get; set; }

        public void Update()
        {
            if (CurrentPoint <= MinPoint)
            {
                CurrentPoint += Change;
                CurrentInvertedPoint -= Change;
            }
            else if (CurrentPoint >= MaxPoint)
            {
                CurrentPoint -= Change;
                CurrentInvertedPoint += Change;
            }
            else
            {
                bool addChange = GetRandomBool();
                CurrentPoint += addChange ? +Change : -Change;
                CurrentInvertedPoint -= addChange ? +Change : -Change;
            }
        }

        private bool GetRandomBool()
        {
            return new Random().Next() > (Int32.MaxValue / 2);
        }

    }
}
