
using Confluent.Kafka;

namespace Users.Services
{
    public class UserService(IProducer<Null,string> producer) : IUserService
    {
        public async Task<string> SendMessage(string topic, string message)
        {
            try
            {
                var response = await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });

                if (response.Status != PersistenceStatus.Persisted)
                {
                    return "Error is creating new user";
                }
                else
                {
                    producer.Flush();
                    return response.Message.Value;
                }
                
            }
            catch(ProduceException<Null,string> ex) 
            {
                return ex.Message;
            }
        }
    }
}
