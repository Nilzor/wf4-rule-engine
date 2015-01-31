using System;

namespace SharedLibrary
{
    /// <summary>
    /// A class that defines a person
    /// </summary>
    public class Person
    {
        #region Properties
        public string Name { get; set; }
        public string Firstname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public bool Married { get; set; }
        public string Salutation { get; set; }

        /// <summary>
        /// Readonly property which returns the
        /// age of the person
        /// </summary>
        public Int32 Age
        {
            get { return CalculateAge(); }
        }

        /// <summary>
        /// Readonly property that returns true
        /// if the person is a minor
        /// </summary>
        public Boolean Minor
        {
            get { return (Age < 18); }
        }

        /// <summary>
        /// Readonly property that returns true
        /// if the person is an adult
        /// </summary>
        public Boolean Adult
        {
            get { return (Age >= 18); }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Calculates the age of the person.
        /// </summary>
        /// <returns></returns>
        private Int32 CalculateAge()
        {
            //Store today's date
            DateTime now = DateTime.Today;
            //Calculate the difference in years
            Int32 years = now.Year - BirthDate.Year;
            //Subtract one year, if the current date is 
            //before the birthday
            if ((now.Month < BirthDate.Month) ||
                (now.Month == BirthDate.Month &&
                now.Day < BirthDate.Day))
            {
                years--;
            }
            return years;
        }

        public void SetSomeValues()
        {
            Firstname = "John";
            Name = "Smith";
            BirthDate = new DateTime(1980, 01, 01);
            Gender = "Male";
        }

        public override string ToString()
        {
            return Salutation + " " + Firstname + " " + Name;
        }
        #endregion



    }
}