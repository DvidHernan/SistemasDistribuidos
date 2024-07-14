using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Controlador
{
    public class UserController
    {
        IUserView _view;
        
        public UserController(IUserView view)
        {
            _view = view;
            view.SetController(this);
        }
    }
}
