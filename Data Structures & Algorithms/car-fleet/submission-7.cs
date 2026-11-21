public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var cars = new (int position, int speed)[position.Length];
        var ArrivingTimes = new Stack<double>();
        double CurrentTime = 0;

        for(int i = 0; i < position.Length; i++)
            cars[i] = (position[i], speed[i]);

        Array.Sort(cars, (a, b) => b.position.CompareTo(a.position));

        for(int i = 0; i < position.Length; i++)
        {
            CurrentTime = (double)(target - cars[i].position) / cars[i].speed;

            if(ArrivingTimes.Count() == 0 || ArrivingTimes.Peek() < CurrentTime)
                ArrivingTimes.Push(CurrentTime);
        }

        return ArrivingTimes.Count();
    }
}