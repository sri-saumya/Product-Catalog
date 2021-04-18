using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public class Categories
    {
        private int _id;
        private string _shortcode;
        public int ID
        {

            set
            {
                
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        public string ShortCode
        {
            set
            {
                if (value.Length > 4)
                {
                    throw new Exception("Invalid code");
                }
                this._shortcode = value;
            }
            get
            {
                return this._shortcode;
            }
        }

        public string Name { get; set; }
        public string Desciption { get; set; }
    }
}
