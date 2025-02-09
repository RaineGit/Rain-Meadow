﻿using Mono.Cecil;
using System.Linq;

namespace RainMeadow
{
    public class AbstractRoomFirstTimeRealizedEvent : ResourceEvent
    {
        public AbstractRoomFirstTimeRealizedEvent() { }
        public AbstractRoomFirstTimeRealizedEvent(RoomSession onlineResource) : base(onlineResource)
        {

        }
        public override EventTypeId eventType => EventTypeId.AbstractRoomFirstTimeRealized;

        public override void Process()
        {
            var rs = onlineResource as RoomSession;

            rs.absroom.firstTimeRealized = false;
        }
    }
}
