using BusinesCardWebsite.Domain.Enteties;
using BusinesCardWebsite.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BusinesCardWebsite.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext context;

        public EFTextFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteTextField(Guid id)
        {
            context.TextFields.Remove(new TextField() { Id = id });
            context.SaveChanges();
        }

        public TextField GetTextFielbById(Guid id)
        {
            return context.TextFields.FirstOrDefault(f => f.Id == id);
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public IQueryable<TextField> GetTextFilieds()
        {
            return context.TextFields;
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }

            context.SaveChanges();
        }
    }
}
