using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA1_Fields_And_Properties_ManjulaRajan
{
    public class Person
    {
       
             

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
            }

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
        

        
    }
}
