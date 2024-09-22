using System;

namespace PatternsDisign
{
    internal class Person
    {
        public String _Name { get; set; }
        public String _LastName { get; set; }
        public String _Document { get; set; }

        public Person(String Name, String LastName, String document)
        {
            _Name=Name;
            _LastName=LastName;
            _Document=document;
        }

        public string ObtenerDetalleClient() {
            return $"Name: {_Name}, LastName: {_LastName}, Document: {_Document}";
        }
    }
}
