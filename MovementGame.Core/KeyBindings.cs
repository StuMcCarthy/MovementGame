using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MovementGame.Core
{
    public static class KeyBindings
    {
        public static Dictionary<string, char> GetKeyBindings(string gameType)
        {
            var dic = new Dictionary<string, char>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("UserPreferences.xml");
            var nodes = xmlDoc.SelectNodes(string.Format("//KeyBindings//Movement[@Type='{0}']//MovementKey", gameType));
            foreach (XmlNode key in nodes)
                dic.Add(key.Attributes["Type"].Value, Convert.ToChar(key.Attributes["Key"].Value));
            return dic;
        }
    }
}
