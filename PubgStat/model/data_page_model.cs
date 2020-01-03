using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PubgStat.model {
   public class data_page_model {
        public string rank_points { get;  set; }
        public int round_played { get; set; }
        public int top_10 { get; set; }
        public int wins { get; set; }
        public float k_d { get; set; }
        public int kills { get; set; }
        public float avg_damage { get; set; }
        public int max_kill_streak { get; set; }
        public int headshots { get; set; }
        public float longest_kill { get; set; }
        public int round_max_kill { get; set; }
        public int vehicle_destroys { get; set; }
        public int road_kill { get; set; }
        public int team_kill { get; set; }
        public int knocks { get; set; }
        public float heals { get; set; }
        public float boosts { get; set; }
        public DateTime most_survival_time { get; set; }
        public DateTime total_survival_time { get; set; }
        public int suicide { get; set; }
        public float walk_dist { get; set; }
        public float ride_dist { get; set; }
        public string swim_dist { get; set; }
       
    }

    
}
