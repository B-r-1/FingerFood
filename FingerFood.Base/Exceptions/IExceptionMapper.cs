using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerFood.Base.Exceptions
{
    public interface IExceptionMapper {
        String MapException(String str);
    }
}
