using UnityEngine;


namespace Eloi.Note
{

    /// <summary>
    /// IF THERE IS ONE THAT YOU DONT WANT TO RENAME IT IS THIS ONE
    /// NOTE FROM AUTHOR
    /// </summary>
    [System.Serializable]
    public class TextNote : I_HasTextNote
    {

        [TextArea(2,10)]
        [SerializeField]
        string m_textNote;
        /// <summary>
        /// DONT CHANGE THIS VARIABLE NAME m_textNote
        /// This is the note of the author. Change it break the note in old project.
        /// </summary>
        /// <param name="note"></param>

        public void GetNote(out string note)
        {
            note = m_textNote;
        }

        public string GetNote()
        {
            GetNote(out string note);
            return note;
        }

        public void SetNote(string note)
        {
            m_textNote = note;
        }
    }

}