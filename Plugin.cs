using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace BetterTeslaGates
{
    public class Plugin : Plugin<Config>
    {
    	public override string Author { get; } = "Killla";
	    public override string Name { get; } = "Better Tesla Gates";
	    public override string Prefix { get; } = "BetterTeslaGates";
	    public override Version Version { get; } = new Version(2, 0, 0);

        public override Version RequiredExiledVersion { get; } = new Version(6, 0, 0);

        private EventHandlers.EventHandlers EventHandlers;
        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers.EventHandlers(this);
            Exiled.Events.Handlers.Player.TriggeringTesla += EventHandlers.OnTriggeringTesla;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.TriggeringTesla -= EventHandlers.OnTriggeringTesla;
            base.OnDisabled();
        }
    }
}
