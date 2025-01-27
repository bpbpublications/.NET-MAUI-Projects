using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class BMI : INotifyPropertyChanged
    {
		private double bmivalue;

		public double BMIValue
		{
			get { return bmivalue; }
			set 
			{
				if(bmivalue != value)
				{
                    bmivalue = value;
					NotifyPropertyChanged();
                }
            }
		}

        public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
