using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PubgStat.model;

namespace PubgStat.view_model {
    public class data_page_view_model : base_view_model {




        public data_page_model rank_points_model { get; private set; }

        public data_page_view_model() {
                rank_points_model = new data_page_model();
                
            }

            public string rank_points {
                get { return rank_points_model.rank_points; }
                set {
                    if(rank_points_model.rank_points != value) {
                    rank_points_model.rank_points = value;
                    NotyfyPropertyChanged(nameof(rank_points));

                }
                }
            }
        public string swim_dist {
            get { return rank_points_model.swim_dist; }
            set {
                if(rank_points_model.swim_dist != value) {
                    rank_points_model.swim_dist = value;
                    NotyfyPropertyChanged(nameof(swim_dist));

                }
            }
        }



    }


}
