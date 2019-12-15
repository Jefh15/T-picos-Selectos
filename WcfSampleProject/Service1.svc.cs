using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfSampleProject.Models;

namespace WcfSampleProject
{
    public class Service1 : IService1
    {
        private static string cadena = "Data Source = localhost; Initial Catalog = sakila; Integrated Security = True";

        //CRUD methods here Ctrl + .
        public void DeleteCategory(int id)
        {
            sakilaEntities bd = new sakilaEntities();
            var query = (from cat in bd.category
                         where cat.category_id == id
                         select cat).FirstOrDefault();
            bd.category.Remove(query);            
            bd.SaveChanges();
        }

        public IEnumerable<category> getCategory()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adapte = new SqlDataAdapter("Select * from category", cadena);
            adapte.Fill(tabla);

            IList<category> retorno = new List<category>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                category item = new category()
                {
                    category_id = byte.Parse(tabla.Rows[i]["category_id"] + ""),
                    name = tabla.Rows[i]["name"] + "",
                    last_update = Convert.ToDateTime(tabla.Rows[i]["last_update"] + "")
                };
                retorno.Add(item);
            }
            return retorno;

        }

        public void InsertCategory(category pobj)
        {
            sakilaEntities bd = new sakilaEntities();
            bd.category.Add(pobj);
            bd.SaveChanges();
        }

        public void UpdateCategory(category pobj)
        {
            sakilaEntities bd = new sakilaEntities();
            var query = (from cat in bd.category
                         where cat.category_id == pobj.category_id
                         select cat).FirstOrDefault();
            query.name = pobj.name;
            query.last_update = pobj.last_update;
            bd.SaveChanges();
        }
    }
}
