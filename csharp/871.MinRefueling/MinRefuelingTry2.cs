using System.Net;

internal class MinRefuelingTry2
{
    public void Test()
    {
        Console.WriteLine($"Expect {MinRefuelStops(1, 1, [])} to be 0");
        Console.WriteLine($"Expect {MinRefuelStops(100, 10, [[10,100]])} to be 1");
        Console.WriteLine($"Expect {MinRefuelStops(100, 1, [[10,100]])} to be -1");
        Console.WriteLine($"Expect {MinRefuelStops(100, 10, [[10,60],[20,30],[30,30],[60,40]])} to be 2");
        Console.WriteLine($"Expect {MinRefuelStops(200, 50, [[25,25],[50,100],[100,100],[150,40]])} to be 2");
        Console.WriteLine($"Expect {MinRefuelStops(1000, 83, [[47,220],[65,1],[98,113],[126,196],[186,218],[320,205],[686,317],[707,325],[754,104],[781,105]])} to be 4");
    }
/*
A car travels from a starting position to a destination which is target miles east of the starting position.

There are gas stations along the way. The gas stations are represented as an array stations where stations[i] = [positioni, fueli] indicates that the ith gas station is positioni miles east of the starting position and has fueli liters of gas.

The car starts with an infinite tank of gas, which initially has startFuel liters of fuel in it. It uses one liter of gas per one mile that it drives. When the car reaches a gas station, it may stop and refuel, transferring all the gas from the station into the car.

Return the minimum number of refueling stops the car must make in order to reach its destination. If it cannot reach the destination, return -1.

Note that if the car reaches a gas station with 0 fuel left, the car can still refuel there. If the car reaches the destination with 0 fuel left, it is still considered to have arrived.
*/
    public int MinRefuelStops(int target, int startFuel, int[][] stations) {
        var totalDistance = startFuel;
        var totalStops = 0;
        var lastIdxEnqueued = -1;
        var passedStations = new PriorityQueue<int[], int>(Comparer<int>.Create((a,b) => b - a));

        if (totalDistance >= target)
        {
            return 0;
        }
        for(int i = 0; i < stations.Length; i++)
        {
            if (stations[i][0] <= totalDistance)
            {
                lastIdxEnqueued = i;
                passedStations.Enqueue(stations[i], stations[i][1]);
            }
        }
        
        while (passedStations.Count > 0)
        {
            var station = passedStations.Dequeue();
            totalStops++;
            totalDistance += station[1];
            if (totalDistance >= target)
            {
                return totalStops;
            }
            for (int i = lastIdxEnqueued + 1; i < stations.Length; i++)
            {
                if (stations[i][0] <= totalDistance)
                {
                    lastIdxEnqueued = i;
                    passedStations.Enqueue(stations[i], stations[i][1]);
                }
            }
        }

        return -1;
    }
}