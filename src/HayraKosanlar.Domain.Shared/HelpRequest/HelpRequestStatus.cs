namespace HayraKosanlar.HelpRequest
{
    public enum HelpRequestStatus
    {
        NewRequest = 1,
        WaitingForDetection = 2,
        DetectionDone = 3,
        Rejected = 4,
        DeliveryWaiting = 5,
        DeliveryDone = 6,
        RequestDone = 7
    }
}