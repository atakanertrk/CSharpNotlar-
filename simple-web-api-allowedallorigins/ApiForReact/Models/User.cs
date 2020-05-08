using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.ObjectPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiForReact.Models
{
    public class User
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
    }
}
