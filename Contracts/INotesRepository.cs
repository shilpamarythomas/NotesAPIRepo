using Contracts.ViewModel;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface INotesRepository : IRepositoryBase<Notes>
    {
        List<Notes> GetNotes(int? NoteId);
        int AddNote(CreateNoteVM noteVM);
        int UpdateNote(int Id, CreateNoteVM clientVM);
        void DeleteNote(int Id);
    }
}
