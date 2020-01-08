using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using PubgStat;
using PubgStat.model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PubgStat.view_model {
    public class data_page_view_model : base_view_model {




        private data_page_model bild { get;  set; }

        public data_page_view_model() {
                bild = new data_page_model();
                
            }
        public double best_rank_points {
            get { return bild.best_rank_points; }
            set {
                if(bild.best_rank_points != value) {
                    bild.best_rank_points = value;
                    NotyfyPropertyChanged(nameof(best_rank_points));

                }
            }
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
        public Image image {
            get { return bild.image; }
            set {
                if(bild.image != value) {

                    bild.image = value;
                    
                    NotyfyPropertyChanged(nameof(image));

                }
            }
        }

        private Image get_rank_pics(double value) {

            Image temp = new Image();

            //UNKNOWN
            if(value <= 1) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Unknown.png"); }
            //BEGINNER
            if(Enumerable.Range(1,199)  .Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Beginner_01.png"); }
            if(Enumerable.Range(200,399).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Beginner_02.png"); }
            if(Enumerable.Range(400,599).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Beginner_03.png"); }
            if(Enumerable.Range(600,799).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Beginner_04.png"); }
            if(Enumerable.Range(800,999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Beginner_05.png"); }
            //NOVICE
            if(Enumerable.Range(1000,1199).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Novice_01.png"); }
            if(Enumerable.Range(1200,1399).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Novice_02.png"); }
            if(Enumerable.Range(1400,1599).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Novice_03.png"); }
            if(Enumerable.Range(1600,1799).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Novice_04.png"); }
            if(Enumerable.Range(1800,1999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Novice_05.png"); }
            //EXPERIENCED
            if(Enumerable.Range(2000,2199).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Experienced_01.png"); }
            if(Enumerable.Range(2200,2399).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Experienced_02.png"); }
            if(Enumerable.Range(2400,2599).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Experienced_03.png"); }
            if(Enumerable.Range(2600,2799).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Experienced_04.png"); }
            if(Enumerable.Range(2800,2999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Experienced_05.png"); }
            //SKILLED
            if(Enumerable.Range(3000,3199).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Skilled_01.png"); }
            if(Enumerable.Range(3200,3399).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Skilled_02.png"); }
            if(Enumerable.Range(3400,3599).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Skilled_03.png"); }
            if(Enumerable.Range(3600,3799).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Skilled_04.png"); }
            if(Enumerable.Range(3800,3999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Skilled_05.png"); }
            //SPECIALIST
            if(Enumerable.Range(4000,4199).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Specialist_01.png"); }
            if(Enumerable.Range(4200,4399).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Specialist_02.png"); }
            if(Enumerable.Range(4400,4599).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Specialist_03.png"); }
            if(Enumerable.Range(4600,4799).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Specialist_04.png"); }
            if(Enumerable.Range(4800,4999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Specialist_05.png"); }
            //EXPERT
            if(Enumerable.Range(5000,5999).Contains((int)value)) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Expert.png"); }
            //SURVIVOR
            if(value > 6000) { temp.Source = ImageSource.FromResource("PubgStat.Ranks.Survivor.png"); }




            return temp;


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
                    if(double.IsNaN(value)) {
                        bild.k_d = 0;
                        NotyfyPropertyChanged(nameof(k_d));
                    }
                    else {
                        bild.k_d = value;
                        NotyfyPropertyChanged(nameof(k_d));
                    }
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
                if(bild.avg_damage != value ) {
                    if (double.IsNaN(value)) {
                        bild.avg_damage = 0;
                        NotyfyPropertyChanged(nameof(avg_damage));
                    }
                    else {
                        bild.avg_damage = value;
                        NotyfyPropertyChanged(nameof(avg_damage));
                    }
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
