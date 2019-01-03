using System.Collections.Generic;
using DTO;

namespace SAL
{
    public interface ISALEntity
    {
        List<DTOEmployee> SearchEntity();
        int InsertEntity();
        void UpdateEntity();
        void DeleteEntity();
    }
}
