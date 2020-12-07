using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity3.Models
{
    public class CustomerModel
    {
        public int id;
        public string name;
        public int age;

        public CustomerModel()
        {
            this.id = 0;
            this.name = "";
            this.age = 0;
        }

        public CustomerModel(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }


    }
}