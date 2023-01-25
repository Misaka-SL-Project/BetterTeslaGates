using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BetterTeslaGates
{
    public class Config : IConfig
    {
        [Description("If the plugin is enabled or not.")]
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;

        [Description("Available items that could disable the tesla gate")]
        public List<ItemType> RequiredItems { get; set; } = new List<ItemType>()
        {
            ItemType.KeycardNTFOfficer,
            ItemType.KeycardContainmentEngineer,
            ItemType.KeycardNTFLieutenant,
            ItemType.KeycardNTFCommander,
            ItemType.KeycardContainmentEngineer,
            ItemType.KeycardFacilityManager,
            ItemType.KeycardO5
        };
    }
}
