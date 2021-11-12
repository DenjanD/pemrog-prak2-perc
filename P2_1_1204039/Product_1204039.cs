using System;

namespace P2_1_1204039
{
    public class Product_1204039
    {
        private String myType;
        private String myTitle;

        public Product_1204039()
        {

        }

        public Product_1204039(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;
        }

        public string MyType
        {
            get
            {
                return myType;
            }

            set
            {
                myType = value;
            }
        }

        public string MyTitle
        {
            get
            {
                return myTitle;
            }

            set
            {
                myTitle = value;
            }
        }
    }
}
