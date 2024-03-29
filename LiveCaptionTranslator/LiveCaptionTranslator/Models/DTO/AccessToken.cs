﻿namespace LiveCaptionTranslator.Models.DTO
{
    public class AccessToken
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public int expiration { get; set; }
        public string scope { get; set; }
    }
}
