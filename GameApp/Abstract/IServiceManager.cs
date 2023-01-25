using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
    public interface IServiceManager
    {
        
        void Delete(IEntity entity);
        void Update (IEntity entity);
    }
}
