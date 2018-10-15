using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAuth.Models
{

    public class SkillQueue
    {
        public Queue[] Queues { get; set; }
    }

    public class Queue
    {
        public DateTime Finish_date { get; set; }
        public int Finished_level { get; set; }
        public int Level_end_sp { get; set; }
        public int Level_start_sp { get; set; }
        public int Queue_position { get; set; }
        public int Skill_id { get; set; }
        public DateTime Start_date { get; set; }
        public int Training_start_sp { get; set; }
        public string Skill_name { get; set; }
    }

}
