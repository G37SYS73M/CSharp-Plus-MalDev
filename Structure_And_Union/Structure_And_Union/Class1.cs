using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Structure_And_Union
{

    public class Class1
    {
        //Creting a Struct 
        public struct myStruct
        {

            public int id;
            public int code;
            public string address;

        }

        public static void Main(string[] args) {

            myStruct st = new myStruct();

            st.id = 1234;
            st.code = 141;
            st.address = "xffxffxffxffxff";
            Console.WriteLine(st.id);
            Console.WriteLine(st.code);
            Console.WriteLine(st.address);
            Console.WriteLine(Marshal.SizeOf(typeof(myStruct)));
            Console.WriteLine("Enter to exit");
            Console.ReadKey();
        }

    }
}
