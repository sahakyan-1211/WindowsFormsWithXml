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
        private XmlDocument xDoc;
        private string filePath = @"C:\Users\i3\source\repos\WindowsFormsWithXml\WindowsFormsWithXml\Source\employee.xml";

        List<Employee> employees = new List<Employee> {
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
            for ( int i = 0; i < employees.Count; i++ )
                {


                xDoc.Load (filePath);

                XmlElement rootElement = xDoc.CreateElement ("employees");
                XmlElement employeeElem = xDoc.CreateElement ("employee");
                XmlElement idElem = xDoc.CreateElement ("id");
                XmlElement firstNameElem = xDoc.CreateElement ("firstName");
                XmlElement lastNameElem = xDoc.CreateElement ("lastName");
                XmlElement ageElem = xDoc.CreateElement ("age");
                XmlElement emailElem = xDoc.CreateElement ("email");



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

                var items = xDoc.GetElementsByTagName ("employee");
                for ( int j = 0; j < items.Count; j++ )
                    {
                    rootElement.AppendChild (items [j]);
                    }

                xDoc.AppendChild (rootElement);
                xDoc.Save (filePath);
                }
            return xDoc;
            }
        }
    }
