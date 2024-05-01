using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    class ManualSportEnumerator: IEnumerator<sport>
    {
        int current = -1;
        public sport Current { get { return (sport)current; } }
        public void Dispose() { return; }
        object System.Collections.IEnumerator.Current { get { return Current; } }
        public bool MoveNext()
        {
            var maxEnumValue = Enum.GetValues(typeof(sport)).Length;
            if((int)current >= maxEnumValue -1)
                return false;
            current++;
            return true;
        }
        public void Reset()
        {
            current = 0;
        }
    }
}
