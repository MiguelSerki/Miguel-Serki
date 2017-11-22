using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public interface IBalance
    {
        decimal GetBalance();
        string AccountNumber { get; set; }
        string Bank { get; set; }

    }
}
