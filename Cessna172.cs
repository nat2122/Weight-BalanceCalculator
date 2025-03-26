using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_B_Calculator
{
    class Cessna172
    {
        public int calculatingMoment172(Cessna172Calulations cessna172Calulations)
        {
            if (cessna172Calulations == null)
            {
                MessageBox.Show("Error: Cessna172Calculations instance is null!");
                return 0;
            }

            int totalWeight = cessna172Calulations.GetTotalWeight172();
            int passWeight = cessna172Calulations.GetWeightOfPass172();
            int bagWeight = cessna172Calulations.GetTotalBag172();
            int fuelWeight = cessna172Calulations.GetWeightFuel172();
            
                        MessageBox.Show($"Total Weight: {totalWeight}\n" +
                                        $"Passenger Weight: {passWeight}\n" +
                                        $"Baggage Weight: {bagWeight}\n" +
                                        $"Fuel Weight: {fuelWeight}");
            

            double momentPilot = totalWeight * 37;
            double momentPass = passWeight * 73;
            double momentBag = bagWeight * 95;
            double momentFuel = fuelWeight * 48;
            MessageBox.Show(cessna172Calulations.GetTotalWeight172().ToString());
            double totalRampMoment = momentFuel + momentPilot + momentPass + momentBag;
            double takeOffMoment = totalRampMoment - 300;
            return Convert.ToInt32(takeOffMoment);
        }
    




// take takeOff and take totalRampMoment and graph them on the chart
public static int calculatingTotalRamp()
        {
            Cessna172Calulations cessna172Calulations = new Cessna172Calulations();
            int totalRamp = cessna172Calulations.GetWeightOfPass172() + cessna172Calulations.GetWeightFuel172() + cessna172Calulations.GetTotalWeight172() + cessna172Calulations.GetTotalBag172() + 1680;
            int takeOff = totalRamp - 7;
            return takeOff;
        }
        // CALCULATING TAKEOFF DISTANCE //
        public  int takeOffDistance()
        {
            Cessna172Calulations calculationsForm = new Cessna172Calulations();
            AccelerationStop_Cessna172 accelerationStopForm = new AccelerationStop_Cessna172(calculationsForm);

            int temperature = accelerationStopForm.GetTemperature();
            int altitude = accelerationStopForm.GetAlt();
            int rampWeight = calculatingTotalRamp();

            if (rampWeight >= 2550 - 50 && rampWeight <= 2550 + 50)
            {
                if (temperature >= 0 && temperature < 10)
                    return EvaluateAltitude(altitude, 1465, 1600, 1755, 1925, 2120, 2345, 2605, 2910, 3265);
                else if (temperature >= 10 && temperature < 20)
                    return EvaluateAltitude(altitude, 1575, 1720, 1890, 2080, 2295, 2545, 2830, 3170, 3575);
                else if (temperature >= 20 && temperature < 30)
                    return EvaluateAltitude(altitude, 1690, 1850, 2035, 2240, 2480, 2755, 3075, 3440, 3880);
                else if (temperature >= 30 && temperature < 40)
                    return EvaluateAltitude(altitude, 1810, 1990, 2190, 2420, 2685, 2975, 3320, 3730, 4225);
                else if (temperature == 40)
                    return EvaluateAltitude(altitude, 1945, 2135, 2355, 2605, 2880, 3205, 3585, 4045, 4615);
            }
            else if (rampWeight >= 2400 - 50 && rampWeight <= 2400 + 50)
            {
                if (temperature >= 0 && temperature < 10)
                    return EvaluateAltitude(altitude, 1275, 1390, 1520, 1665, 1830, 2015, 2230, 2470, 2755);
                else if (temperature >= 10 && temperature < 20)
                    return EvaluateAltitude(altitude, 1370, 1495, 1635, 1795, 1975, 2180, 2410, 2686, 3000);
                else if (temperature >= 20 && temperature < 30)
                    return EvaluateAltitude(altitude, 1470, 1605, 1760, 1930, 2130, 2355, 2610, 2900, 3240);
                else if (temperature >= 30 && temperature < 40)
                    return EvaluateAltitude(altitude, 1570, 1720, 1890, 2080, 2295, 2530, 2805, 3125, 3500);
                else if (temperature == 40)
                    return EvaluateAltitude(altitude, 1685, 1845, 2030, 2230, 2455, 2715, 3015, 3370, 3790);
            }
            else if (rampWeight >= 2200 - 50 && rampWeight <= 2200 + 50)
            {
                if (temperature >= 0 && temperature < 10)
                    return EvaluateAltitude(altitude, 1055, 1145, 1250, 1365, 1490, 1635, 1800, 1985, 2195);
                else if (temperature >= 10 && temperature < 20)
                    return EvaluateAltitude(altitude, 1130, 1230, 1340, 1465, 1605, 1765, 1940, 2145, 2370);
                else if (temperature >= 20 && temperature < 30)
                    return EvaluateAltitude(altitude, 1130, 1230, 1340, 1465, 1605, 1765, 1940, 2145, 2375);
                else if (temperature >= 30 && temperature < 40)
                    return EvaluateAltitude(altitude, 1205, 1315, 1435, 1570, 1725, 1900, 2100, 2325, 2580);
                else if (temperature == 40)
                    return EvaluateAltitude(altitude, 1380, 1505, 1650, 1805, 1975, 2175, 2395, 2650, 2950);
            }

            return 0; // Return a default value if no condition is met
        }
       
        private static int lastEvaluatedValue; // Store the last calculated value

        public static int EvaluateAltitude(int altitude, int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9)
        {
            if (altitude <= 1000)
                lastEvaluatedValue = v1;
            else if (altitude <= 2000)
                lastEvaluatedValue = v2;
            else if (altitude <= 3000)
                lastEvaluatedValue = v3;
            else if (altitude <= 4000)
                lastEvaluatedValue = v4;
            else if (altitude <= 5000)
                lastEvaluatedValue = v5;
            else if (altitude <= 6000)
                lastEvaluatedValue = v6;
            else if (altitude <= 7000)
                lastEvaluatedValue = v7;
            else if (altitude <= 8000)
                lastEvaluatedValue = v8;
            else
                lastEvaluatedValue = v9;

            return lastEvaluatedValue;
        }

        public static int GetLastEvaluatedValue() // Getter to access the last evaluated value
        {
            return lastEvaluatedValue;
        }

    }
}




