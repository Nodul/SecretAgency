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
        public string Text // full text of this document
        {
            get
            {
                return HeaderText+"\n\n"+BodyText+"\n\n"+EndText;
            }
        }

        public Document(bool isRevealed)
        {
            IsRevealed = isRevealed;
        }
    }
}