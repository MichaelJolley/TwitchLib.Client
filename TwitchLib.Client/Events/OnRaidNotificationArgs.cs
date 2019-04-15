﻿using System;
using TwitchLib.Client.Models;

namespace TwitchLib.Client.Events
{
    public class OnRaidNotificationArgs : EventArgs
    {
        public RaidNotification RaidNotification;
        public string Channel;
    }
}
