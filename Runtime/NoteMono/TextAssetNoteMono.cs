
using System;
using UnityEngine;

namespace Eloi.Note
{

    [System.Serializable]
    public class TextAssetNoteMono : MonoBehaviour, I_HasTextNoteGet
    {

        public TextAssetNote m_note;
       

        public void GetNote(out string note)
        {
            if (m_note == null)
            {
                note = "No Note";
                return;
            }
            m_note.GetNote(out note);
        }

        public string GetNote()
        {

            GetNote(out string note);
            return note; 
        }

        
    }
}