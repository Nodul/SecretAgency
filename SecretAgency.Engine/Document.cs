namespace SecretAgency.Engine
{
    public class Document
    {
        public string name; // used for reference inside the program
        public string DocName; // the name the player will see
        public string HeaderText;
        public string BodyText;
        public string EndText;
        public bool IsRevealed { get;  set; }

        public Document(bool isRevealed)
        {
            IsRevealed = isRevealed;
        }
    }
}