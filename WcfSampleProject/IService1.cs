using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfSampleProject.Models;

namespace WcfSampleProject
{

    //atribute to expose
    [ServiceContract]
    public interface IService1
    {
        //declare the methods in the interface
        [OperationContract]
        IEnumerable<category> getCategory();

        [OperationContract]
        void InsertCategory(category pobj);

        [OperationContract]
        void UpdateCategory(category pobj);

        [OperationContract]
        void DeleteCategory(int id);
    }

}
