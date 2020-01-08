using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PubgStat.model {
   public class data_page_model {
        public Image image { get; set; }
        public double rank_points { get;  set; }
        public double best_rank_points { get; set; }        
        public int revives { get; set; }
        public int round_played { get; set; }
        public int assists { get; set; }
        public int top_10 { get; set; }
        public int wins { get; set; }
        public double k_d { get; set; }
        public int kills { get; set; }
        public double avg_damage { get; set; }
        public int max_kill_streak { get; set; }
        public int headshots { get; set; }
        public double longest_kill { get; set; }
        public int round_max_kill { get; set; }
        public int vehicle_destroys { get; set; }
        public int road_kill { get; set; }
        public int team_kill { get; set; }
        public int knocks { get; set; }
        public double heals { get; set; }
        public double boosts { get; set; }
        public double most_survival_time { get; set; }
        public double total_survival_time { get; set; }
        public int suicide { get; set; }
        public double walk_dist { get; set; }
        public double ride_dist { get; set; }
        public double swim_dist { get; set; }
        public int weaponsAcquired { get; set; }
    }

    
}
