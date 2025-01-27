using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class ValueToStringConverter : IValueConverter
    {
        private const Double LIM_NORMALWEIGHT = 18.5F;
        private const Double LIM_OVERWEIGHT = 25.0F;
        private const Double LIM_OBESEWEIGHT = 30.0F;
        

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Double bmi = (Double)value;
            String result = null;
            /*
             * 
             Underweight: BMI is less than 18.5
             Normal weight: BMI is 18.5 to 24.9
             Overweight: BMI is 25 to 29.9
             Obese: BMI is 30 or more
             * 
             * */
            
            if(bmi < LIM_NORMALWEIGHT) { result = "Under Weight"; }

            if (bmi >= LIM_NORMALWEIGHT && bmi < LIM_OVERWEIGHT) { return "Normal Weight"; }

            if (bmi >= LIM_OVERWEIGHT && bmi < LIM_OBESEWEIGHT) { return "Over Weight"; }

            if (bmi >= LIM_OBESEWEIGHT) { return "Obese Weight"; }

            return result; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
