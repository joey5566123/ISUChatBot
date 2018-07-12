﻿using System.Collections.Generic;

namespace Bot_Application2.Model
{
    public class LUISResponse
    {
        public string query { get; set; }
        public TopScoringIntent topScoringIntent { get; set; }
        public Entity[] entities { get; set; }
    }

    public class TopScoringIntent
    {
        public string intent { get; set; }
        public double score { get; set; }
    }

    public class Entity
    {
        public string entity { get; set; }
        public string type { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
        public double score { get; set; }
    }

}