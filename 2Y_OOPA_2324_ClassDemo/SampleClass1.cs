using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _2Y_OOPA_2324_ClassDemo
{
    internal class SampleClass1
    {
        private string theMessage = "This is the message";
        
        /// <summary>
        /// This gets the message value of the class
        /// </summary>
        /// <returns>the message</returns>
        public string message()
        {
            return theMessage;
        }

        /// <summary>
        /// This sets the value of the message
        /// </summary>
        /// <param name="newMessage">The new message</param>
        public void changeTheMessage(string newMessage)
        {
            theMessage = newMessage;
        }
        
    }
}
