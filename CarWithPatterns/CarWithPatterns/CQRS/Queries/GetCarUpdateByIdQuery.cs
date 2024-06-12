namespace CarWithPatterns.CQRS.Queries
{
    public class GetCarUpdateByIdQuery
    {
        public GetCarUpdateByIdQuery(int carID)
        {
            CarID = carID;
        }

        public int CarID { get; set; }

    }
}
