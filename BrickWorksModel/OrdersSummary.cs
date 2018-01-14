using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickWorks
{
    class OrdersSummary
    {
        public int OrderId { get; set; }
        public DateTime OrderedDate { get; set; }
        public string Client { get; set; }
        public double Amount
        {
            get
            {
                var db = new BrickWorksModel();
                var BricksInOrder = db.OrderedBricks.Where(b => b.OrderId == OrderId).ToList();
                double sum = 0;
                foreach (var brick in BricksInOrder)
                {
                    var cost = db.BrickCosts.Where(
                        b => b.BrickId == brick.BrickId && b.Date <= OrderedDate).OrderByDescending(d => d.Date);
                   
                    if(cost.Count()>0)
                    {
                        sum += brick.Quantity * cost.FirstOrDefault().Cost;
                    }
                }
                sum += (float)db.Orders.FirstOrDefault(o=> o.Id == OrderId).DeliveryCost;
                sum = Math.Round(sum, 2);
                return sum;
            }
        }
    }
}