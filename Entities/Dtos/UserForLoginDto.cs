using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendyolClone.Core.Entity;

namespace TrendyolClone.Entites.Dtos
{
    public class UserForLoginDto:IDto
    {
        public string Email  { get; set; }
        public string Password  { get; set; }
    }
}
