public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var Cars = new (int position,int speed)[position.Length];
        var ArrivingTimes = new List<double>();
        double CurrentTime = 0;

        for(int i = 0; i < position.Length; i++)
            Cars[i] = (position[i],speed[i]);

        Array.Sort(Cars, (a, b) => b.position.CompareTo(a.position));

        for(int i = 0; i < position.Length; i++)
        {
            CurrentTime = (double)(target - Cars[i].position) / Cars[i].speed;
            if(ArrivingTimes.Count() == 0 || ArrivingTimes[ArrivingTimes.Count() - 1] < CurrentTime)
                ArrivingTimes.Add(CurrentTime);       
        }

        return ArrivingTimes.Count();
    }
}