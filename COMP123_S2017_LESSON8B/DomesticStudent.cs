using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_LESSON8B
{
    public class DomesticStudent : Student
    {

        // PUBLIC PROPERTY
        public string DomesticAddress { get; private set; } //READ ONLY

      
        //CONSTRUCTORS

        /// <summary>
        /// This is the constructor takes three arguments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public DomesticStudent(string name,int age, string studentID):
            base(name,age,studentID)
        {
        }

        //PUBLIC METHODS
        /// <summary>
        /// This method sets the domestic address property
        /// </summary>
        /// <param name="address"></param>
        public void SetDomesticAddress(string address)
        {
            this.DomesticAddress = address;
        }

    }
}
