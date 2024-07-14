using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Controlador
{
    public interface IUserView
    {
        void SetController(UserController controller);
    }
}
