using SecretAgency.Engine.Helpers;

namespace SecretAgency.Engine
{
    public class Location
    {
        public string Address { get;  set; }
        public bool IsRevealed { get;  set; }
        public string Summary { get; set; }

        public Location(bool isRevealed)
        {
            Address = TextGen.GetAddrees();
            IsRevealed = isRevealed;
            
        }
    }
}