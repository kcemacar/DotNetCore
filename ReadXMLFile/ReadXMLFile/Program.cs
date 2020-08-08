using System;
using System.Xml; // This namespace provides standarts-based support for processing XML

namespace ReadXMLFile
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader xtr = new XmlTextReader("C:\\Users\\LENOVO\\source\\repos\\ReadXMLFile\\ReadXMLFile\\student.xml");
            // XmlTextReader = This class provides methods to access to XML data

            while(xtr.Read()) // Reads the next node from the stream
            {
                // NodeType : This attribute gets the type of the current node
                if(xtr.NodeType == XmlNodeType.Element && xtr.Name == "name")
                {
                    string s1 = xtr.ReadElementString(); // Reads a text-only element.
                    Console.WriteLine("Name = " + s1);
                }

                
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "class_Section")
                {
                    string s2 = xtr.ReadElementString();
                    Console.WriteLine("Class = " + s2);
                }

                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "roll_no")
                {
                    string s3 = xtr.ReadElementString();
                    Console.WriteLine("Result = " + s3);
                    Console.WriteLine();
                    Console.WriteLine();
                }

            }
        }
    }
}
