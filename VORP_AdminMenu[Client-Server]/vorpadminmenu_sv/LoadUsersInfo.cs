﻿using CitizenFX.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vorpadminmenu_sv
{
    class LoadUsersInfo : BaseScript
    {
        public LoadUsersInfo()
        {
            EventHandlers["vorp_admin:LoadPlayerInfo"] += new Action<Player>(LoadPlayerInfo);
        }

        private void LoadPlayerInfo([FromSource]Player source)
        {
            TriggerEvent("vorp:getCharacter", int.Parse(source.Handle), new Action<dynamic>((user) =>
            {
                string group = user.group;
                source.TriggerEvent("vorp_admin:GetPlayerInfo",group);
            }));
        }
    }
}
