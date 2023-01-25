using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exiled.Events.EventArgs.Player;

namespace BetterTeslaGates.EventHandlers
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            if (ev.Player.CurrentItem != null && plugin.Config.RequiredItems.Contains(ev.Player.CurrentItem.Type))
            {
                ev.IsAllowed = false;
            }
        }
    }
}
