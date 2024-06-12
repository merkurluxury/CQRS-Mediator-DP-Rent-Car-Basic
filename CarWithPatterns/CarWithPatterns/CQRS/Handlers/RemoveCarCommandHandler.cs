using CarWithPatterns.CQRS.Commands;
using CarWithPatterns.DAL;

namespace CarWithPatterns.CQRS.Handlers
{
    public class RemoveCarCommandHandler
    {
        private readonly Context _context;

        public RemoveCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle( RemoveCarCommand command)
        {
            var values = _context.Cars.Find(command.CarID);
            _context.Cars.Remove(values);
            _context.SaveChanges();

        }
    }


}
