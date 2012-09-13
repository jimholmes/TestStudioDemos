public float ComputeWages(float hours, 
                         	            float rate, 
                            	            bool isHourlyWorker)
{
    if (hours > 80)
    {
        throw new ArgumentException();
    }
    float wages = 0;

    if (hours > 40)
    {
        var overTimeHours = hours - 40;
        if (isHourlyWorker)
        {
            wages += (overTimeHours*1.5f)*rate;
        }
        else
        {
            wages += overTimeHours*rate;
        }
        hours -= overTimeHours;
    }
    wages += hours*rate;

    return wages;
}
