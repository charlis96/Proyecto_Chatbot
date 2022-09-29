using System;

namespace Library
{
    public class Admin
    {
        public string NickName { get; set; }
        private static Admin instance;

        private Admin() {}

        public static Admin Instance 
        {
            get
            {
                if (instance == null) 
                {
                    instance = new Admin();
                }
                return instance;
            }
        }

        public Category CreateCategory (string name)
        {
            var category = new Category 
            {
                Name = name
            };

            return category;
        }

        public void DeleteCategory ()
        {

        }
    }
}