using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1_Fields_And_Properties_ManjulaRajan
{
    public class Person
    {
       
             //Field is made private so that we can have validations and It is encapsulated within the class and accessed through a public property Instructor, which provides controlled access to the field. The private access level ensures that the field is not directly accessible from outside the class, promoting encapsulation and data integrity.

            private string _name;

            //Property
            public string Name
            {
                get { return _name; }
                set 
                {
                    if (!string.IsNullOrEmpty(value))
                        _name = value;

                    else
                        throw new ArgumentException("Name cannot be null or empty");
                            
                }



            }   // The getter returns the value of a private field variable. It can not be modified and it only readble. while the setter modifies the importance of it, Its Writable or edible.

        //Read only property; only includes a getter
        public string ReadOnlyName
            {
                get { return _name; }
            }

            //Write only property; only includes a setter
            public string WriteOnlyName
            {
                set { _name = value; }
            }

        //Note;
        //Why the field is private ?

        //Answer: Instructor field is made private so that we can have validations and It is encapsulated within the class and accessed through a public property Instructor, which provides controlled access to the field. The private access level ensures that the field is not directly accessible from outside the class, promoting encapsulation and data integrity.





        //What is the role within class?

        //Answer: It is storing instructor name of this course. Instructor is a private field used to store the instructor's name. It indicates that the field is not directly accessible from outside the class.





        //PRIVATE FIELDS AND PUBLIC PROPERTIES EXPLANATION:

        //What is the need for Private Fields? Explanation

        //Answer: 1.Encapsulation and Data integrity 2. Data Hiding 3.Controlled Access 4.Abstraction 5. Security.
        //Using encapulation it prevents the direct access and manupation from external code. This promotes data intergrity and reduces the risk of unintended changes to objects. By hiding the data the internal  implementation details are hidden from external code, providing a clear separation between the public interface of the class and its internal workings. Private filed only be access and modified by methods and properties within the same class. This control over access ensures that the class can enforce business rules, validation logic, and constraints on the data it manages.Private fields help in enforcing security measures by restricting access to sensitive data. By hiding implementation details and providing controlled access, private fields reduce the risk of unauthorized access and manipulation of critical information.






        //How public properties provide controlled access to these fields?

        //Answer:Propertied are special methods that provide controlled access to private fields. They act as an interface through which external code can interact with the class's data. Properties encapsulate the access to the underlying fields, allowing the class to enforce validation rules, compute values dynamically, or perform other operations before allowing access to the data and By defining properties with custom get and set accessors, a class can control how its data is read and modified. Get accessors retrieve the value of a property (which may be derived from a private field or calculated dynamically), while set accessors assign new values to the property (after validating or processing them).






        //What is the benefits of encapsulation approach.

        //Answer: 1.Data Hiding 2.Controlled Access (getter and setter) 3. Abstraction 4.Flexilibty and Evolution 5. Easy to test code like Unit Test 6.Resuability of code. 7.Reduction of Human based errors 8.Code will be more cleaner and understandable way.


    }//class




}//namespace
