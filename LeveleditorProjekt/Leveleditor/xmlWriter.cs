using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Leveleditor
{
    public class xmlWriter
    {
        private string mSavePath;

        public xmlWriter()
        {
            mSavePath = "xmlConfig.xml";
        }

        public xmlWriter(string path)
        {
            mSavePath = path + "\\xmlConfig.xml";
        }

        public void WriteXMLFile(Field[,] fields, string name)
        {
            try
            {
                XmlTextWriter myXmlTextWriter = new XmlTextWriter(mSavePath, null);
                myXmlTextWriter.Formatting = Formatting.Indented;
                myXmlTextWriter.WriteStartDocument(false);
                myXmlTextWriter.WriteComment("Dieser Teil ist noch alternativ");

                myXmlTextWriter.WriteStartElement("GameField", null);
                myXmlTextWriter.WriteAttributeString("Name", name);

                myXmlTextWriter.WriteStartElement("Size", null);
                myXmlTextWriter.WriteAttributeString("Rows", fields.GetLength(0).ToString());
                myXmlTextWriter.WriteAttributeString("Columns", fields.GetLength(1).ToString());
                myXmlTextWriter.WriteEndElement();

                myXmlTextWriter.WriteStartElement("Fields", null);

                for (int y = 0; y < fields.GetLength(1); y++)
                {
                    for (int x = 0; x < fields.GetLength(0); x++)
                    {
                        myXmlTextWriter.WriteStartElement("Field", null);
                        myXmlTextWriter.WriteAttributeString("Type", fields[x, y].Type);
                        myXmlTextWriter.WriteAttributeString("PowerUps", fields[x, y].PowerUp);
                        myXmlTextWriter.WriteAttributeString("Player", fields[x, y].Player);
                        myXmlTextWriter.WriteEndElement();
                    }  
                }
                myXmlTextWriter.WriteEndElement();
                myXmlTextWriter.WriteEndDocument();

                myXmlTextWriter.Flush();
                myXmlTextWriter.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
