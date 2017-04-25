using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgency.Engine.Helpers
{
    /// <summary>
    /// Document converter
    /// </summary>
    public static class DocCon
    {
        public static Document Convert(Location location, bool revealed = true)
        {
            Document doc = new Document(revealed)
            {
                name = "location_doc",
                HeaderText = "SITE INVESTIGATION",
                BodyText = $"{location.Address}\n\n{location.Summary}",
                EndText = "[CURRENT ORDERS]",
                DocName = location.Address
            };         
            return doc;

        }

        public static Document Convert(Character character, bool revealed = true)
        {
            Document doc = new Document(revealed)
            {
                name = "character_doc",
                HeaderText = "SUSPECT RAPORT",
                BodyText = $"{character.FullName}, {character.Age} y.o.\n{character.Address}\n\nOccupation: {character.Occupation}\nProminence: {character.Prominence.ToString()}\n\nSummary: {character.Summary}\n\nNotes: {character.TriviaList[0]}",
                EndText = "[CURRENT ORDERS]",
                DocName = character.FullName               
            };
            return doc;
        }
        public static Document Convert(Item item, bool revealed = true)
        {
            throw new NotImplementedException("Item document not implemented");
            Document doc = new Document(revealed)
            {

            };
            return doc;
        }


    }
}
