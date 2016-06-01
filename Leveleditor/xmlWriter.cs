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
        private Field[,] mFields;
        private string mName;

        public xmlWriter()
        {
            mSavePath = "xmlConfig.xml";
            mFields = null;
            mName = null;
        }

        public xmlWriter(string path, Field[,] fields, string name)
        {
            mSavePath = path + "xmlConfig.xml";
            mFields = fields;
            mName = name;
        }

        public bool WriteXMLFile()
        {
            bool success = true;
            try
            {
                XmlTextWriter myXmlTextWriter = new XmlTextWriter(mSavePath, null);
                myXmlTextWriter.Formatting = Formatting.Indented;
                myXmlTextWriter.WriteStartDocument(false);
                myXmlTextWriter.WriteComment("Dieser Teil ist noch alternativ");

                myXmlTextWriter.WriteStartElement("GameField", null);
                myXmlTextWriter.WriteAttributeString("Name", mName);

                myXmlTextWriter.WriteStartElement("Size", null);
                myXmlTextWriter.WriteAttributeString("Rows", mFields.GetLength(0).ToString());
                myXmlTextWriter.WriteAttributeString("Columns", mFields.GetLength(1).ToString());
                myXmlTextWriter.WriteEndElement();

                myXmlTextWriter.WriteStartElement("Fields", null);

                for (int x = 0; x < mFields.GetLength(0); x++)
                {
                    for (int y = 0; y < mFields.GetLength(1); y++)
                    {
                        myXmlTextWriter.WriteStartElement("Field", null);
                        myXmlTextWriter.WriteAttributeString("Type", mFields[x, y].Type);
                        myXmlTextWriter.WriteAttributeString("PowerUps", mFields[x, y].PowerUp);
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
                Console.WriteLine(ex.Message);
                success = false;
            }
            return success;
        }
    }
}
