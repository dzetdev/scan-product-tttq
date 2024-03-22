namespace Scan_Product_TTTQ.Domain.Utils;

public class DateTimeUtils
{
    public static List<TimeOnly> GetTimeSlots(TimeOnly startTime, TimeOnly endTime, int slotDuration)
    {
        var timeSlots = new List<TimeOnly>();
        var currentTime = startTime;
        while (currentTime < endTime)
        {
            timeSlots.Add(currentTime);
            currentTime = currentTime.AddMinutes(slotDuration);
        }

        return timeSlots;
    }
}