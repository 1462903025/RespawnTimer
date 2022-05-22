namespace RespawnTimer.Commands
{
    using CommandSystem;
    using Exiled.API.Features;
    using RemoteAdmin;
    using System;

    [CommandHandler(typeof(ClientCommandHandler))]
    public class Timer : ICommand
    {
        public string Command => "倒计时";

        public string[] Aliases => Array.Empty<string>();

        public string Description => "显示/隐藏重生倒计时。";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            string userId = Player.Get(sender).UserId;

            if (!Handler.TimerHidden.Contains(userId))
            {
                Handler.TimerHidden.Add(userId);

                response = "<color=red>重生倒计时已隐藏！</color>";
                return true;
            }

            Handler.TimerHidden.Remove(userId);

            response = "<color=green>已显示重生倒计时！</color>";
            return true;
        }
    }
}
