using SimpleWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ToSerializeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Characters character;
            character = new Characters();
            XmlSerializer serializer = new XmlSerializer(typeof (Characters));
            using (StringWriter characterWriter = new StringWriter())
            {
                serializer.Serialize(characterWriter, character);
                File.WriteAllText($"{character.Name}.xml", characterWriter.ToString());
                Console.WriteLine(characterWriter.ToString());
            }
            Characters xmlCharacter;
            using (StringReader characterReader = new StringReader(File.ReadAllText("Character1.xml")))
            {
                xmlCharacter = (Characters)serializer.Deserialize(characterReader);
            }
            Console.WriteLine("Name: "+xmlCharacter.Name +" Class: "+ xmlCharacter.Class);
            Console.ReadKey(true);
        }
    }
}
