using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    internal class ManualSportSequence: IEnumerable<sport>
    {
        public IEnumerator<sport> GetEnumerator()
        {
            return new ManualSportEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
