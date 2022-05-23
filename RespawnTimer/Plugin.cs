﻿namespace RespawnTimer
{
    using System;
    using System.Reflection;
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using Exiled.Loader;

    using ServerEvent = Exiled.Events.Handlers.Server;

    public class RespawnTimer : Plugin<Config, Translation>
    {
        public static RespawnTimer Singleton;

        public static Assembly SerpentsHandAssembly;
        public static Assembly UIURescueSquadAssembly;

        private Handler handler;

        public override void OnEnabled()
        {
            Singleton = this;

            handler = new Handler();

            ServerEvent.RoundStarted += handler.OnRoundStart;

            foreach (IPlugin<IConfig> plugin in Loader.Plugins)
            {
                if (plugin.Name == "SerpentsHand" && plugin.Config.IsEnabled)
                {
                    SerpentsHandAssembly = plugin.Assembly;
                    Log.Debug("检测到蛇之手插件！", Config.ShowDebugMessages);
                }

                if (plugin.Name == "UIURescueSquad" && plugin.Config.IsEnabled)
                {
                    UIURescueSquadAssembly = plugin.Assembly;
                    Log.Debug("检测到UIURescueSquad插件！", Config.ShowDebugMessages);
                }
            }

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            ServerEvent.RoundStarted -= handler.OnRoundStart;

            handler = null;
            Singleton = null;

            base.OnDisabled();
        }

        public override string Name => "RespawnTimer";
        public override string Author => "Michal78900";
        public override Version Version => new Version(3, 0, 0);
        public override Version RequiredExiledVersion => new Version(3, 0, 5);
    }
}
