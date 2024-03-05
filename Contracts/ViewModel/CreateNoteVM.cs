using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModel
{
    public class CreateNoteVM
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int CreatedBy { get; set; }
    }

    public class NoteVM : CreateNoteVM
    {
        public int Id { get; set; }
    }
}
