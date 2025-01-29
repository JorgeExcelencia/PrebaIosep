using System;
using System.Collections.Generic;

namespace ApiIosep.Models.IOSEPweb
{
    public partial class AspNetEvent
    {
        public string Id { get; set; } = null!;
        public string OldUserName { get; set; } = null!;
        public string NewUserName { get; set; } = null!;
        public string ChangeUser { get; set; } = null!;
        public DateTime EventTime { get; set; }
    }
}
