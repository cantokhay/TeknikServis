﻿namespace TeknikServis.EntityLayer.ConcreteModels
{
    public class Note
    {
        public int NoteId { get; set; }
        public string NoteTitle { get; set; }
        public string NoteDescription { get; set; }
        public bool NoteStatus { get; set; }
    }
}
