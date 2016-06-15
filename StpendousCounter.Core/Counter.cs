﻿using SQLite;

namespace StpendousCounter.Core
{
    public class Counter
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Value { get; set; }
    }
}
