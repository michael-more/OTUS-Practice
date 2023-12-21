using System;

namespace AttributesApp;

public class CommonMethods
{
        public static bool ValidateUser(Person person)
    {
        Type type = typeof(Person);

        // getting all attributes of Person class
        object[] attributes = type.GetCustomAttributes(false);

        // go through all attributes
        foreach (Attribute attr in attributes)
        {
            if (attr is AgeValidationAttribute ageAttribute)
            {
                return person.Age >= ageAttribute.Age;
            }
        }
        
        return true;
    }
}
