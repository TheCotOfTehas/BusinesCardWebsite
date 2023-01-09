using BusinesCardWebsite.Domain.Enteties;
using System;
using System.Linq;

namespace BusinesCardWebsite.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFilieds();
        TextField GetTextFielbById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField id);
        void DeleteTextField(Guid id);

    }
}
