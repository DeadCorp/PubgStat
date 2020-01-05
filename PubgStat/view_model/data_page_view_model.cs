using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PubgStat.model;

namespace PubgStat.view_model {
    public class data_page_view_model : base_view_model {




        private data_page_model bild { get;  set; }

        public data_page_view_model() {
                bild = new data_page_model();
                
            }

        public double rank_points {
            get { return bild.rank_points; }
            set {
                if(bild.rank_points != value) {
                    bild.rank_points = value;
                    NotyfyPropertyChanged(nameof(rank_points));

                }
            }
        }
        public int assists {
            get { return bild.assists; }
            set {
                if(bild.assists != value) {
                    bild.assists = value;
                    NotyfyPropertyChanged(nameof(assists));

                }
            }
        }
        public int revives {
            get { return bild.revives; }
            set {
                if(bild.revives != value) {
                    bild.revives = value;
                    NotyfyPropertyChanged(nameof(revives));

                }
            }
        }
        public double swim_dist {
            get { return bild.swim_dist; }
            set {
                if(bild.swim_dist != value) {
                    bild.swim_dist = value;
                    NotyfyPropertyChanged(nameof(swim_dist));

                }
            }
        }
        public int weaponsAcquired {
            get { return bild.weaponsAcquired; }
            set {
                if(bild.weaponsAcquired != value) {
                    bild.weaponsAcquired = value;
                    NotyfyPropertyChanged(nameof(weaponsAcquired));

                }
            }
        }
        public int round_played {
            get { return bild.round_played; }
            set {
                if(bild.round_played != value) {
                    bild.round_played = value;
                    NotyfyPropertyChanged(nameof(round_played));

                }
            }
        }
        public int top_10 {
            get { return bild.top_10; }
            set {
                if(bild.top_10 != value) {
                    bild.top_10 = value;
                    NotyfyPropertyChanged(nameof(top_10));

                }
            }
        }
        public int wins {
            get { return bild.wins; }
            set {
                if(bild.wins != value) {
                    bild.wins = value;
                    NotyfyPropertyChanged(nameof(wins));

                }
            }
        }
        public double k_d {
            get { return bild.k_d; }
            set {
                if(bild.k_d != value) {
                    bild.k_d = value;
                    NotyfyPropertyChanged(nameof(k_d));

                }
            }
        }

        public int kills {
            get { return bild.kills; }
            set {
                if(bild.kills != value) {
                    bild.kills = value;
                    NotyfyPropertyChanged(nameof(kills));

                }
            }
        }
        public double avg_damage {
            get { return bild.avg_damage; }
            set {
                if(bild.avg_damage != value) {
                    bild.avg_damage = value;
                    NotyfyPropertyChanged(nameof(avg_damage));

                }
            }
        }

        public int max_kill_streak {
            get { return bild.max_kill_streak; }
            set {
                if(bild.max_kill_streak != value) {
                    bild.max_kill_streak = value;
                    NotyfyPropertyChanged(nameof(max_kill_streak));

                }
            }
        }

        public int headshots {
            get { return bild.headshots; }
            set {
                if(bild.headshots != value) {
                    bild.headshots = value;
                    NotyfyPropertyChanged(nameof(headshots));

                }
            }
        }
        public double longest_kill {
            get { return bild.longest_kill; }
            set {
                if(bild.longest_kill != value) {
                    bild.longest_kill = value;
                    NotyfyPropertyChanged(nameof(longest_kill));

                }
            }
        }
        public int round_max_kill {
            get { return bild.round_max_kill; }
            set {
                if(bild.round_max_kill != value) {
                    bild.round_max_kill = value;
                    NotyfyPropertyChanged(nameof(round_max_kill));

                }
            }
        }
        public int vehicle_destroys {
            get { return bild.vehicle_destroys; }
            set {
                if(bild.vehicle_destroys != value) {
                    bild.vehicle_destroys = value;
                    NotyfyPropertyChanged(nameof(vehicle_destroys));

                }
            }
        }
        public int road_kill {
            get { return bild.road_kill; }
            set {
                if(bild.road_kill != value) {
                    bild.road_kill = value;
                    NotyfyPropertyChanged(nameof(road_kill));

                }
            }
        }

        public int team_kill {
            get { return bild.team_kill; }
            set {
                if(bild.team_kill != value) {
                    bild.team_kill = value;
                    NotyfyPropertyChanged(nameof(team_kill));

                }
            }
        }
        public int knocks {
            get { return bild.knocks; }
            set {
                if(bild.knocks != value) {
                    bild.knocks = value;
                    NotyfyPropertyChanged(nameof(knocks));

                }
            }
        }

        public double heals {
            get { return bild.heals; }
            set {
                if(bild.heals != value) {
                    bild.heals = value;
                    NotyfyPropertyChanged(nameof(heals));

                }
            }
        }
        public double boosts {
            get { return bild.boosts; }
            set {
                if(bild.boosts != value) {
                    bild.boosts = value;
                    NotyfyPropertyChanged(nameof(boosts));

                }
            }
        }
        public double most_survival_time {
            get { return bild.most_survival_time; }
            set {
                if(bild.most_survival_time != value) {
                    bild.most_survival_time = value;
                    NotyfyPropertyChanged(nameof(most_survival_time));

                }
            }
        }

        public double total_survival_time {
            get { return bild.total_survival_time; }
            set {
                if(bild.total_survival_time != value) {
                    bild.total_survival_time = value;
                    NotyfyPropertyChanged(nameof(total_survival_time));

                }
            }
        }

        public int suicide {
            get { return bild.suicide; }
            set {
                if(bild.suicide != value) {
                    bild.suicide = value;
                    NotyfyPropertyChanged(nameof(suicide));

                }
            }
        }
        public double walk_dist {
            get { return bild.walk_dist; }
            set {
                if(bild.walk_dist != value) {
                    bild.walk_dist = value;
                    NotyfyPropertyChanged(nameof(walk_dist));

                }
            }
        }
        public double ride_dist {
            get { return bild.ride_dist; }
            set {
                if(bild.ride_dist != value) {
                    bild.ride_dist = value;
                    NotyfyPropertyChanged(nameof(ride_dist));

                }
            }
        }


    }


}
