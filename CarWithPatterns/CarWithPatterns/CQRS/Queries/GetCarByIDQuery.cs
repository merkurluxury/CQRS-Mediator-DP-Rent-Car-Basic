namespace CarWithPatterns.CQRS.Queries
{
    public class GetCarByIDQuery
    {
        public GetCarByIDQuery(int carID)
        {
            CarID = carID;
        }

        public int CarID { get; set; }

    }
}
