using System;

namespace Exercise_Typing_with_all_ten_fingers
{
    class Stats
    {
        public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);
        public event UpdatedStatsEventHandler UpdatedStats;

        public int Correct { get; set; }
        public int Missed { get; set; }
        public int Accuracy { get; set; }

        private void onUpdatedStats()
        {
            UpdatedStatsEventHandler handler = UpdatedStats;
            if (handler != null)
                handler(this, new EventArgs());
        }

        public void Update(bool correctKey)
        {
            if (correctKey)
            {
                Correct++;
            }
            else
            {
                Missed++;
            }


            calculateAccuracy();
            onUpdatedStats();
        }

        private void calculateAccuracy()
        {
            int sum = Missed + Correct;
            Accuracy = sum / Correct;
        }
    }
}
