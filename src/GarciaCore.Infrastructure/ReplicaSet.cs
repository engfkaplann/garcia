﻿using System.Collections.Generic;

namespace GarciaCore.Infrastructure
{
    public class ReplicaSet
    {
        public string Name { get; set; }
        public List<Endpoint> EndPoints { get; set; } = new List<Endpoint>();
    }
}
