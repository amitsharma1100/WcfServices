using System.Runtime.Serialization;

namespace WcfServiceLibrary.Models
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Gender { get; set; }
    }
}
