using SelfieAWookie.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Services.Selfies
{
    public interface ISelfieService
    {
        List<Selfie> GetList();
    }
}
