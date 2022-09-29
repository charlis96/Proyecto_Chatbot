using System;

namespace Library
{
    public class Admin
    {
        public string NickName { get; set; }
        public string Password { get; set; }
        private static Admin instance;

        private Admin() {}

        /// <summary>
        ///   Utilizamos este Singleton para que exista un unico admin.
        /// </summary>
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

        /// <summary>
        ///  A traves de este metodo se le daria la posibildad al admin de poder eliminar categorias.
        /// </summary>
        public void DeleteCategory ()
        {
               
        }

        /// <summary>
        ///  A traves de este metodo se le daria la posibildad al admin de poder eliminar servicios.
        /// </summary>
        public void CancelService ()
        {
        
        }
    }
}