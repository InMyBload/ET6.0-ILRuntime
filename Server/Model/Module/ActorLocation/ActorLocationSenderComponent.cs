﻿﻿using System.Collections.Generic;

namespace ET
{
    public class ActorLocationSenderComponent: Entity
    {
        public static long TIMEOUT_TIME = 60 * 1000;

        public static ActorLocationSenderComponent Instance { get; set; }

        public long CheckTimer;
    }
}