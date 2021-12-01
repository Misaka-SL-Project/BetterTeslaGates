using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;

namespace BetterTeslaGates.EventHandlers
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            try
            {
                if (plugin.Config.RequiredItems.Contains(ev.Player.CurrentItem.Type))
                {
                    ev.IsTriggerable = false;
                }
            }
            catch
            {

            }
        }
    }
}
