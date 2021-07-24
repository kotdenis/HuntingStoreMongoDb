﻿using System.Collections.Generic;

namespace HuntingStoreMongoDb.Shared.IdentityModels
{
    public class CurrentUser
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public Dictionary<string, string> Claims { get; set; }
    }
}
