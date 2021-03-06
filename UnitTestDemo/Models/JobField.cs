﻿using System;

namespace TechJobs.Models
{
    public class JobField
    {
        public int ID { get; set; }
        private static int nextId = 1;

        public string Value { get; set; }

        public JobField()
        {
            ID = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        // Provide a basic case-insensitive search
        public bool Contains(string testValue)
        {
            return Value.ToLower().Contains(testValue.ToLower());
            // this is an example of swallowing an exception
            // what would be a better way to handle this?
            //try
            //{
            //    testValue = testValue.ToLower();              
            //}
            //catch(Exception ex)
            //{
            //    Console.Write(ex.Message);
            //   // throw;
            //}
            //return Value.ToLower().Contains(testValue);
        }

        public override string ToString()
        {
            return Value;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return (obj as JobField).ID == ID;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return ID;
        }

    }
}
