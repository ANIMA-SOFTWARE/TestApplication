using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPortal.Models;
using Windows.Media.Audio;

namespace SchoolPortal.Stores
{
   public interface IStore
    {
        void Create(BaseModel model);
        void Update(BaseModel model);
        void Delete(BaseModel model);
    }
}
