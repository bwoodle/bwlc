using System.Net;

internal class MinRefueling
{
    public void Test()
    {
        // Console.WriteLine($"Expect {MinRefuelStops(1, 1, [])} to be 0");
        // Console.WriteLine($"Expect {MinRefuelStops(100, 10, [[10,100]])} to be 1");
        // Console.WriteLine($"Expect {MinRefuelStops(100, 1, [[10,100]])} to be -1");
        // Console.WriteLine($"Expect {MinRefuelStops(100, 10, [[10,60],[20,30],[30,30],[60,40]])} to be 2");
        // Console.WriteLine($"Expect {MinRefuelStops(200, 50, [[25,25],[50,100],[100,100],[150,40]])} to be 2");
        Console.WriteLine($"Expect {MinRefuelStops(1000, 83, [[47,220],[65,1],[98,113],[126,196],[186,218],[320,205],[686,317],[707,325],[754,104],[781,105]])} to be 4");
    }
        
    // This is a working solution, but N^2 storage complexity does not allow it to be accepted
    public int MinRefuelStops(int target, int startFuel, int[][] stations) {
        if (target <= startFuel)
        {
            return 0;
        }
        
        var minPriorityQueue = new PriorityQueue<FuelStop, int>(stations.Length, Comparer<int>.Create((a,b) => a - b));
        minPriorityQueue.Enqueue(new FuelStop(-1, startFuel, 0), 0);

        while (minPriorityQueue.Count > 0)
        {       
            var currentStop = minPriorityQueue.Dequeue();
            var stationVisited = new List<int>();
            for(int i = currentStop.StationIdx + 1; i < stations.Length; i++)
            {
                if (stations[i][0] <= currentStop.TotalFuel)
                {
                    var newFuel = stations[i][1] + currentStop.TotalFuel;
                    var totalStops = currentStop.NumberOfStops + 1;
                    if (newFuel >= target)
                    {
                        return totalStops;
                    }
                    minPriorityQueue.Enqueue(new FuelStop(i, newFuel, totalStops), totalStops);
                }
            }
        }

        return -1;
    }

    private record FuelStop(int StationIdx, int TotalFuel, int NumberOfStops);
}