using Contracts;
using Contracts.ViewModel;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class NotesRepository : RepositoryBase<Notes>, INotesRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public NotesRepository(RepositoryContext repositoryContext)
           : base(repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public List<Notes> GetNotes(int? NoteId)
        {
            return NoteId != null ? _repositoryContext.Notes.Where(x => x.Id == NoteId).ToList() :
                                      _repositoryContext.Notes.ToList();
        }
        public int AddNote(CreateNoteVM clientVM)
        {
            var input = new Notes()
            {
                
                Title = clientVM.Title,
                Content = clientVM.Content,
                CreatedBy= clientVM.CreatedBy
            };
            Create(input);
            SaveChange();

            return input.Id;

        }
        public int UpdateNote(int Id, CreateNoteVM clientVM)
        {
            var input = new Notes()
            {
                Id= Id,
                Title = clientVM.Title,
                Content = clientVM.Content,
                CreatedBy = clientVM.CreatedBy
            };
            Update(input);
            SaveChange();

            return input.Id;

        }

        public void DeleteNote(int Id)
        {
            var noteDelete = _repositoryContext.Notes.Where(x => x.Id == Id);
            if (noteDelete.Any())
            {
                noteDelete.ExecuteDelete();
            }
        }
    }
}
