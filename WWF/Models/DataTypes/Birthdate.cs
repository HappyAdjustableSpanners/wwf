using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WWF.Models.DataTypes
{
    public class Birthdate
    {
        public DateTime _birthDate { get; set; }
        public Birthdate()
        {
            _birthDate = DateTime.MinValue;
        }
    }
}
