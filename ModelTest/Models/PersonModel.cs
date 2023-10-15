using CommunityToolkit.Mvvm.ComponentModel;


namespace ModelTest.Models
{
    public class PersonModel: ObservableObject
    {
        private int _val = 0;
        public int Val
        {
            get => _val;
            set => SetProperty(ref _val, value);
        }

        private double _seed = 0.0;
        public double Seed
        {
            get => _seed;
            set => SetProperty(ref _seed, value);
        }
    }
}
