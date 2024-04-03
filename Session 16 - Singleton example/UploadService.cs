using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16___Singleton_example
{
    sealed class UploadService
    {
        private static UploadService instance;
        private static readonly object _lock = new Object();

        public int Id { get; private set; }

        private UploadService() 
        {

        }

        public static UploadService getInstance(int id)
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null) 
                    {
                        instance = new UploadService();   
                        instance.Id = id;
                    }
                }                
            }
            return instance;            
        }
    }
}

/*

Der bruges et readonly object _lock (tænk intrinsic lock fra Java)

Så når to eller flere threads kalder getInstance, vil den først få låsen
og resten af threads vil vente indtil thread har sluppent _lock 

*/
