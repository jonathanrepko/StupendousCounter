using SQLite;
using System;

namespace StpendousCounter.Core
{
    public class CounterIncrementHistory
    {
        [Indexed]
        public int CounterId { get; set; }
        public DateTime IncrementDateTimeUtc { get; set; }
    }
}
