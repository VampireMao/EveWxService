using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EveWxService
{

    public class Character
    {
        public int CharacterID { get; set; }

        public string CharacterName { get; set; }

        public DateTime ExpiresOn { get; set; }

        public string Scopes { get; set; }

        public string TokenType { get; set; }

        public string CharacterOwnerHash { get; set; }

        public string IntellectualProperty { get; set; }
    }

}