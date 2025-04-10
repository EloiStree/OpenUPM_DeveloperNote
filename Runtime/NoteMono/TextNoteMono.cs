using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Eloi.Note
{

    

    /// <summary>
    /// IF THERE IS ONE THAT YOU DONT WANT TO RENAME IT IS THIS ONE
    /// NOTE FROM AUTHOR
    /// </summary>
    [System.Serializable]
    public class TextNoteMono : NoteMonoBehaviour , I_HasTextNote
{
        [Tooltip("The note to be share")]
        /// <summary>
        /// IF THERE IS ONE THAT YOU DONT WANT TO RENAME IT IS THIS ONE
        /// NOTE FROM AUTHOR
        /// </summary>
        public TextNote m_note;
         public void GetNote(out string note)
        {
            if(m_note == null)
            {
                note = string.Empty;
                return;
            }

            m_note.GetNote(out note);
        }
        public void SetNote(string note)
        {
            m_note.SetNote(note);
        }
        public string GetNote() {

            GetNote(out string note);
            return note;
        }

        [ContextMenu("Open Chat GPT with text")]
        public void OpenChatGptWithText() {

            string correct = "https://chat.openai.com/?prompt=Rephrase+"+ m_note.GetNote().Replace(" ","+");
            Application.OpenURL(correct);
        }
    }

}