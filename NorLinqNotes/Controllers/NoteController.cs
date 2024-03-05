using Contracts;
using Contracts.ViewModel;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace NorLinqNotes.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INotesRepository _noteRepository;
        public NoteController(INotesRepository notesRepository)
        {
            _noteRepository = notesRepository;
        }

        [HttpGet]
        public JsonResult GetNote(int? NoteId)
        {
            try
            {
                var noteList = _noteRepository.GetNotes(NoteId);
                return new JsonResult(noteList);
            }
            catch (Exception ex)
            {
                return new JsonResult("Error occured in GetNote!");
            }
        }

        [HttpPost]
        public JsonResult AddNotes(CreateNoteVM noteVM)
        {
            try
            {
                if (noteVM == null)
                {
                    throw new ArgumentNullException(nameof(noteVM));
                }

                if (ModelState.IsValid)
                {
                    _noteRepository.AddNote(noteVM);
                    return new JsonResult("Inserted successfully!");
                }
                else
                {
                    return new JsonResult("Failed to insert!");
                }
            }
            catch (Exception ex)
            {
                return new JsonResult("Error occured in AddNotes!");
            }
        }

        [HttpPut]
        public JsonResult UpdateNotes(int Id, CreateNoteVM noteVM)
        {
            try
            {
                if (noteVM == null)
                {
                    throw new ArgumentNullException(nameof(noteVM));
                }

                if (ModelState.IsValid)
                {
                    _noteRepository.UpdateNote(Id, noteVM);
                    return new JsonResult("Updated successfully!");
                }
                else
                {
                    return new JsonResult("Failed to update!");
                }
            }
            catch (Exception ex)
            {
                return new JsonResult("Error occured in UpdateNotes!");
            }
        }

        [HttpDelete]
        public JsonResult DeleteNote(int Id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _noteRepository.DeleteNote(Id);
                    return new JsonResult("Deleted successfully!");
                }
                else
                {
                    return new JsonResult("Failed to delete!");
                }
            }
            catch (Exception ex)
            {
                return new JsonResult("Error occured in DeleteNote!");
            }
        }
    }
}
