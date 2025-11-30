class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualTime)
    {
        int ovenTime = ExpectedMinutesInOven();
        int RemainingMinute = ovenTime - actualTime;
        return RemainingMinute;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        int TotalTime = layers*2;
        return TotalTime;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers,int bakeTime)
    {
        int prepTime = PreparationTimeInMinutes(layers);
        int TotalTimeWorked = prepTime + bakeTime;
        return TotalTimeWorked;
    }
   
}
