using BusinesCardWebsite.Domain.Repositories.Abstract;

namespace BusinesCardWebsite.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository) 
        { 
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
