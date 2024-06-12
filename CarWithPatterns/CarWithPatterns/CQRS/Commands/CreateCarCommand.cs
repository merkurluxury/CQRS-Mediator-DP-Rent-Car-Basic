namespace CarWithPatterns.CQRS.Commands
{
    public class CreateCarCommand
    {
        public string? CarBrand { get; set; }
        public string? CarModel { get; set; }
        public string? MotorPower { get; set; }
        public string? ImageUrl { get; set; }
        public string Price { get; set; }

        public bool IsAvailable { get; set; } // Aracın müsaitlik durumu

    }
}
