using BusinessLayer.Interface;
using DataLayer;
using DataLayer.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Conversion : IConversion
    {
        ApplicationDbContext _dbContext;
        public Conversion(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public Metric convert_to_integral(int Id)
        {

            return _dbContext.MerticsData.Where(x => x.sr_no == Id).FirstOrDefault();
        }
    }
}
