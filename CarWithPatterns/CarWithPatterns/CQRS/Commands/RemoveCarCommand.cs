namespace CarWithPatterns.CQRS.Commands
{
    public class RemoveCarCommand
    {
        public RemoveCarCommand(int carID)
        {
            CarID = carID;
        }

        public int CarID { get; set; }

    }
}
