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
        public static Dictionary<string, int> GetKeyBindings(string gameType)
        {
            var dic = new Dictionary<string, int>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("UserPreferences.xml");
            var nodes = xmlDoc.SelectNodes(string.Format("//KeyBindings//Movement[@Type='{0}']//MovementKey", gameType));
            foreach (XmlNode key in nodes)
                dic.Add(key.Attributes["Type"].Value, XmlConvert.ToInt32(key.Attributes["Key"].Value));
            return dic;
        }
    }
}
