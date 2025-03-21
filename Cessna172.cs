using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace W_B_Calculator
{
    class Cessna172
    {
        int basicEmptyWeight = 1413;
        public int calculatingMoment172()
        {
            Cessna172Calulations cessna172Calulations = new Cessna172Calulations();
            // calculating moment with weight of both pilots
            double momentP = (700 / 19 + cessna172Calulations.GetTotalWeight172()) + 131.58;
            double momentPilot = Math.Round(momentP);
            // calculating moment with Pass
            double momentPas = (cessna172Calulations.GetWeightOfPass172() + 5) / 0.014;
            double momentPass = Math.Round(momentPas);
            // calculating moment with Bag
            double momentB = (cessna172Calulations.GetTotalBag172() - 3) / .01;
            double momentBag = Math.Round(momentB);
            // calculating moment with fuel
            double momentF = (cessna172Calulations.GetWeightFuel172() - 0.83) * 2300 / 47;
            double momentFuel = Math.Round(momentF);
            double totalRampMoment = momentFuel + momentPilot + momentPass + momentBag;
            double takeOffmoment = totalRampMoment - 300;
            int takeOffMoment = Convert.ToInt32(takeOffmoment);
            return takeOffMoment;
        }
            // take takeOff and take totalRampMoment and graph them on the chart
        public int calculatingTotalRamp()
        {
            Cessna172Calulations cessna172Calulations = new Cessna172Calulations();
            int totalRamp = cessna172Calulations.GetWeightOfPass172() + cessna172Calulations.GetWeightFuel172() + cessna172Calulations.GetTotalWeight172() + cessna172Calulations.GetTotalBag172();
            int takeOff = totalRamp - 7;
            return takeOff;
        }
        // CALCULATING TAKEOFF DISTANCE //

        public int takeOffDistance() // finish the rest
        {
            int x = 0;
            AccelerationStop_Cessna172 accelerationStop_Cessna172 = new AccelerationStop_Cessna172();
            int temperature = accelerationStop_Cessna172.GetTemperature();
            if (calculatingTotalRamp() >= 2550 - 50 && calculatingTotalRamp() <= 2550 + 50) // Around 2550

                if (temperature >= 0 && temperature < 10)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1465, 1600, 1755, 1925, 2120, 2345, 2605, 2910, 3265);
                }
                else if (temperature >= 10 && temperature < 20)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1575, 1720, 1890, 2080, 2295, 2545, 2830, 3170, 3575);
                }
                else if (temperature >= 20 && temperature < 30)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1690, 1850, 2035, 2240, 2480, 2755, 3075, 3440, 3880);
                }
                else if (temperature >= 30 && temperature < 40)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1810, 1990, 2190, 2420, 2685, 2975, 3320, 3730, 4225);
                }
                else if (temperature == 40)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1945, 2135, 2355, 2605, 2880, 3205, 3585, 4045, 4615);
                }
            
            //ACCELERATION FOR 2400
            if (calculatingTotalRamp() >= 2400 - 50 && calculatingTotalRamp() <= 2400 + 50) // Around 2550

                if (temperature >= 0 && temperature < 10)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1275, 1390, 1520, 1665, 1830, 2015, 2230, 2470, 2755);
                }
                else if (temperature >= 10 && temperature < 20)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1370, 1495, 1635, 1795, 1975, 2180, 2410, 2686, 3000);
                }
                else if (temperature >= 20 && temperature < 30)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(),1470, 1605, 1760, 1930, 2130, 2355, 2610, 2900, 3240);
                }
                else if (temperature >= 30 && temperature < 40)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1570, 1720, 1890, 2080, 2295, 2530, 2805, 3125, 3500);
                }
                else if (temperature == 40)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1685, 1845, 2030, 2230, 2455, 2715, 3015, 3370, 3790);
                }
            // ACCELERATION FOR 2200
            if (calculatingTotalRamp() >= 2200 - 50 && calculatingTotalRamp() <= 2200 + 50) // Around 2550

                if (temperature >= 0 && temperature < 10)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1055, 1145, 1250, 1365, 1490, 1635, 1800, 1985, 2195);
                }
                else if (temperature >= 10 && temperature < 20)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1130, 1230, 1340, 1465, 1605, 1765, 1940, 2145, 1370);
                }
                else if (temperature >= 20 && temperature < 30)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1130, 1230, 1340, 1465, 1605, 1765, 1940, 2145, 2375);
                }
                else if (temperature >= 30 && temperature < 40)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1205, 1315, 1435, 1570, 1725, 1900, 1310, 1435, 1580);
                }
                else if (temperature == 40)
                {
                    return EvaluateAltitude(accelerationStop_Cessna172.GetAlt(), 1380, 1505, 1650, 1805, 1975, 2175, 2395, 2650, 2950);
                }
            return x;
        }

    
        private static int EvaluateAltitude(int altitude, int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9)
        { 
            if (altitude > 1000)
                return v1;
            else if (altitude < 1000)
                return v2;
            else if (altitude <= 2000)
                return v3;
            else if (altitude <= 3000)
                return v4;
            else if (altitude <= 4000)
                return v5;
            else if (altitude <= 5000)
                return v6;
            else if (altitude <= 6000)
                return v7;
            else if (altitude <= 7000)
                return v8;
            else if (altitude <= 8000)
                return v9;

            // return "Altitude out of range";
        }


    }
}




