using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanProject
{
    public interface ICreature
    {
        string GetImageFileName();
        int GetDrawingPriority();
        bool DeadInConflict(ICreature conflictedObject);
    }
}
