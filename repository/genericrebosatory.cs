using Microsoft.EntityFrameworkCore;
using sign.core.rebosatory;
using sign.repository.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using sign.core.rebosatory;


    public class genericrebosatory<t> : igenericreposatory<t> where t : baseEntity
    {
        private readonly signupcontext _dbcontext;

        public genericrebosatory(signupcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        //public async Task<IEnumerable<t>> GetAllasync()
        //{
        //return await _dbcontext.Set<t>().ToListAsync();
        //}

        //public Task<t> GetByIdasync(int Id)
        //{
        //    return _dbcontext.Set<t>().Where(x => x.id == Id).FirstOrDefaultAsync();
        //}

    public async Task InsertAsync(t entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        await _dbcontext.Set<t>().AddAsync(entity);
        await _dbcontext.SaveChangesAsync();
    }
}

