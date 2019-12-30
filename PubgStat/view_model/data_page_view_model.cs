using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PubgStat.model;

namespace PubgStat.view_model {
    public class data_page_view_model : INotifyPropertyChanged {

       
            public event PropertyChangedEventHandler PropertyChanged;
            
        private data_page_model rank_points_model;
        private data_page_model swim_dist_model;
            public data_page_view_model() {
                rank_points_model = new data_page_model();
                swim_dist_model = new data_page_model();
            }

            public string rank_points {
                get { return rank_points_model.rank_points; }
                set {
                    if(rank_points_model.rank_points != value) {
                    rank_points_model.rank_points = value;
                        

                    }
                }
            }
            public string swim_dist {
                get { return swim_dist_model.swim_dist; }
                set {
                    if(swim_dist_model.swim_dist != value) {
                    swim_dist_model.swim_dist = value;
                    }
                }
            }

            protected void OnPropertyChanged(string propName) {
                if(PropertyChanged != null)
                    PropertyChanged(this,new PropertyChangedEventArgs(propName));
            }
        
    }


}
