using MobileMart.Models;

namespace MobileMart.Interface
{
    public interface IKafkaService
    {
        public Task GetResponse(MobileDEtails mobileDEtails);
    }
}
