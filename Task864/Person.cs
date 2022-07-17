using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace Task864
{
    public struct Person
    {
        #region Поля

        public string name { get; set; }
        public string street { get; set; }
        public string houseNumber { get; set; }
        public string flatNumber { get; set; }
        public string mobilePhone { get; set; }
        public string flatPhone { get; set; }

        #endregion

        #region Конструктор
        public Person(string pName, string str, string hn, string fn, string mp, string fp)
        {
            this.name = pName;
            this.street = str;
            this.houseNumber = hn;
            this.flatNumber = fn;
            this.mobilePhone = mp;
            this.flatPhone = fp;
        }
        #endregion

        #region Метод

        /// <summary>
        /// Метод, возвращающий Person в виде структурированного XElement.
        /// </summary>
        /// <returns></returns>
        public XElement XmlPrint()
        {

            XElement nPerson = new XElement("Person", $"name='{name}'",
                new XElement("Address",
                    new XElement("Street", street),
                    new XElement("HouseNumber", houseNumber),
                    new XElement("FlatNumber", flatNumber)
                    ),
                new XElement("Phones",
                    new XElement("MobilePhone", mobilePhone),
                    new XElement("FlatPhone", flatPhone)
                    )
                );

            return nPerson;
        }

        #endregion
    }
}
