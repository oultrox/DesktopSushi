using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sushi.DALC;

namespace Sushi.Negocio
{
        class CommonBC
        {
            private static AdminSushiEntities _modeloSushi;
            public static AdminSushiEntities ModeloSushi
            {
                get
                {
                    if (_modeloSushi == null)
                    {
                        _modeloSushi = new AdminSushiEntities();
                    }
                    return _modeloSushi;
                }
            }

            public CommonBC() { }
        
    }


}
