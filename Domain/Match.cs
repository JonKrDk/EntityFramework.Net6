using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Match : BaseDomainObject
    {
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
        public DateTime Date { get; set; }
    }
}
