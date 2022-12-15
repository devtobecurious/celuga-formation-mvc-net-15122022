using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Models
{
    ///// <summary>
    ///// Chef, Aviateur, Tireur
    ///// </summary>
    //public class Rang
    //{
    //    public int Id { get; set; }

    //    public string Libelle { get; set; } = string.Empty;

        
    //}

    public record Rang(int Id, string Libelle);

}
