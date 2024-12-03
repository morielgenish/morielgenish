using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger_shop
{
    
    internal class Customer
    {
        private string firstname;
        private string lastname;
        private string id;
        private string address;
        private string cardNumber;
        private string cardType;

        //Constructors
        public Customer()
        {

        }

        //Get and Set methods
        public string Firstname
        {
            get { return firstname; }
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new ArgumentException("First name must contain only letters.");
                    }
                }

                firstname = value;
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new ArgumentException("Last name must contain only letters.");
                    }
                }

                lastname = value;
            }
        }

        public string ID
        {
            get { return id; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "ID cannot be null.");
                }

                if (value.Length != 9)
                {
                    throw new Exception("ID must be exactly nine numbers.");
                }
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new Exception("ID must conatins only numbers.");
                    }
                }
                id = value;

            }
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new Exception("Card number must conatin only digits.");
                    }
                }

                if (value.Length < 6 || value.Length > 10)
                {
                    throw new Exception("Card number must contain 6 - 10 digits.");
                }
                cardNumber = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsLetterOrDigit(c) && c != ' ')
                    {
                        throw new Exception("Invalid Address!");
                    }
                }
                address = value;
            }
        }


        public string CardType
        {
            get { return cardType; }
            set
            {
                cardType = value;
            }
        }

        public override string ToString()
        {
            return firstname.ToUpper() + " " + lastname.ToUpper() + " Your order has been accepted "; 
        }

    }
}



