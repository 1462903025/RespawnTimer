namespace RespawnTimer
{
    using Exiled.API.Interfaces;
    using System.ComponentModel;

    public class Config : IConfig
    {
        [Description("插件是否已启用。")]
        public bool IsEnabled { get; set; } = true;

        [Description("是否在服务器控制台中显示调试消息。")]
        public bool ShowDebugMessages { get; private set; } = false;

        [Description("屏幕上的计时器应该更低或更高。（值从0到14，0-非常高，14-非常低）")]
        public byte TextLowering { get; private set; } = 8;

        [Description("计时器应该准确到分钟数吗？")]
        public bool ShowMinutes { get; private set; } = true;

        [Description("计时器应该精确到秒数吗？")]
        public bool ShowSeconds { get; private set; } = true;

        [Description("是否在复活队伍开始时显示计时器？（NTF直升机/混沌车到达）")]
        public bool ShowTimerOnlyOnSpawn { get; private set; } = false;

        [Description("是否显示观众人数？")]
        public bool ShowNumberOfSpectators { get; private set; } = true;

        [Description("是否显示NTF和CI 重生票数?")]
        public bool ShowTickets { get; private set; } = true;
    }
}