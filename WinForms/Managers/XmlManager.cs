using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WinForms.Models;

namespace WinForms.Managers
    {
    class XmlManager
        {
        readonly string filePath = @"C:\Users\i3\source\repos\WinForms\WinForms\Data\employee.xml";
        readonly XmlDocument xDoc = new XmlDocument ();


        readonly List<Employee> employees = new List<Employee> {
                new Employee ()
                    {
                    _id = Guid.NewGuid (),
                    _firstName = "Tom",
                    _lastName = "Howard",
                    _age = 21,
                    _email = "tomhoward@gmail.com"
                    },
                new Employee()
                    {
                    _id = Guid.NewGuid (),
                    _firstName = "Jane",
                    _lastName = "Johnson",
                    _age = 20,
                    _email = "janejohnson@gmail.com"
                    }
                };



        public XmlDocument CreateXmlFile ()
            {
            xDoc.Load (filePath);



            for ( int i = 0; i < employees.Count; i++ )
                {
                XmlElement xRoot = xDoc.DocumentElement;
                // XmlElement rootElement = xDoc.CreateElement ("employees");
                XmlElement employeeElem = xDoc.CreateElement ("employee");
                XmlElement idElem = xDoc.CreateElement ("Id");
                XmlElement firstNameElem = xDoc.CreateElement ("FirstName");
                XmlElement lastNameElem = xDoc.CreateElement ("LastName");
                XmlElement ageElem = xDoc.CreateElement ("Age");
                XmlElement emailElem = xDoc.CreateElement ("Email");

                XmlText idText = xDoc.CreateTextNode (employees [i]._id.ToString ());
                idElem.AppendChild (idText);
                XmlText firstNameText = xDoc.CreateTextNode (employees [i]._firstName);
                firstNameElem.AppendChild (firstNameText);
                XmlText lastNameText = xDoc.CreateTextNode (employees [i]._lastName);
                lastNameElem.AppendChild (lastNameText);
                XmlText ageText = xDoc.CreateTextNode (employees [i]._age.ToString ());
                ageElem.AppendChild (ageText);
                XmlText emailText = xDoc.CreateTextNode (employees [i]._email);
                emailElem.AppendChild (emailText);

                employeeElem.AppendChild (idElem);
                employeeElem.AppendChild (firstNameElem);
                employeeElem.AppendChild (lastNameElem);
                employeeElem.AppendChild (ageElem);
                employeeElem.AppendChild (emailElem);


                /* var items = xDoc.GetElementsByTagName ("employee");
                 for ( int j = 0; j < items.Count; j++ )
                     {
                     rootElement.AppendChild (items [j]);
                     }*/
                // rootElement.AppendChild (employeeElem);
                xRoot.AppendChild (employeeElem);
                }

            //xDoc.AppendChild (rootElement);
            xDoc.Save (filePath);
            ;

            return xDoc;
            }
        public void DeleteChild ()
            {

            XmlElement xRoot = xDoc.DocumentElement;

            XmlNode firstNode = xRoot.FirstChild;
            xRoot.RemoveChild (firstNode);
            xDoc.Save (filePath);
            }
        }
    }

