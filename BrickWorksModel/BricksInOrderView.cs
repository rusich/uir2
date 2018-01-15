using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickWorks
{
    class BricksInOrderView
    {
        BrickWorksModel db;
        public int Id;
        public int BrickId;
        public DateTime OrderDate;
        public int OrderId;
        public string BrickMark { get; set; }
        public int Quantity { get; set; }
        public float Cost
        {
            get
            {
                var costs = db.BrickCosts.Where(b => b.BrickId == BrickId && b.Date <= OrderDate);
                if (costs.Count()>0 )
                {
                    return costs.OrderByDescending(d => d.Date).FirstOrDefault().Cost;
                }
                return 0;
            }
        }

        public float Total
        {
            get
            {
                return Cost* Quantity; 
            }
        }

        public BricksInOrderView()
        {
            db = new BrickWorksModel();
        }

    }
}
