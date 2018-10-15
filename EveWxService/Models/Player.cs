using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EveWxService
{
    public class Player
    {
        public int ID { get; set; }

        public string CharacterName { get; set; }

        public int CharacterID { get; set; }

        public string Access_token { get; set; }

        public string Refresh_token { get; set; }

    }
}