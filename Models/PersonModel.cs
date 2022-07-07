using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Models {

    [DataContract]
    public class PersonModel {
        [DataMember]
        private int Id { get; set; }
        
        [DataMember]
        public string FullName { get; set; } = string.Empty;

        [DataMember]
        public string Email { get; set; } = string.Empty;

        public PersonModel(int Id, string FullName, string Email) {
            this.Id = Id;
            this.FullName = FullName;
            this.Email = Email;
        }
    }
}