﻿using Entitas.CodeGeneration.Attributes;

namespace Entitas.CodeGeneration.Plugins
{
    public class EventData
    {
        public readonly EventTarget EventTarget;
        public readonly EventType EventType;
        public readonly int Order;

        public EventData(EventTarget eventTarget, EventType eventType, int order)
        {
            EventTarget = eventTarget;
            EventType = eventType;
            Order = order;
        }
    }
}
