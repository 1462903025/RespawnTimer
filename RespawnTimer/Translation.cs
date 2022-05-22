namespace RespawnTimer
{
    using Exiled.API.Interfaces;

    public class Translation : ITranslation
    {
        public string YouWillRespawnIn { get; private set; } = "<color=orange>您将在以下时间重生：</color>";
        public string YouWillSpawnAs { get; private set; } = "您将重生为： ";
        public string Ntf { get; private set; } = "<color=blue>九尾狐特遣队</color>";
        public string Ci { get; private set; } = "<color=green>混沌分裂者</color>";
        public string Sh { get; private set; } = "<color=red>蛇之手</color>";
        public string Uiu { get; private set; } = "<color=yellow>Unusual Incidents Unit</color>";
        public string Spectators { get; private set; } = "<color=#B3B6B7>旁观者: </color>";
        public string NtfTickets { get; private set; } = "<color=blue>九尾狐特遣队: </color>";
        public string CiTickets { get; private set; } = "<color=green>混沌分裂者: </color>";
        public string Seconds { get; private set; } = " <b>{seconds} 秒</b>";
        public string Minutes { get; private set; } = "<b>{minutes} 分钟.</b>";
        public string SpectatorsNum { get; private set; } = "{spectators_num}";
        public string NtfTicketsNum { get; private set; } = "{ntf_tickets_num}";
        public string CiTicketsNum { get; private set; } = "{ci_tickets_num}";
    }
}
