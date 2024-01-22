namespace Bybit.Exchange.Net.Models.Common
{
    public class ByBitCredentials
    {
        public string Key { get; set; } = default!;
        public string Secret { get; set; } = default!;

        public ByBitCredentials()
        {
        }

        public ByBitCredentials(string key, string secret)
        {
            Secret = secret;
            Key = key;
        }
    }
}