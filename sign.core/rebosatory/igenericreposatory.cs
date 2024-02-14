using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sign.core.rebosatory
{
    public interface igenericreposatory<t> where t : baseEntity 
    {
        //Task<IEnumerable<t>> GetAllasync();
        //Task<t>GetByIdasync(int Id);
        Task InsertAsync(t entity);
    }
}
