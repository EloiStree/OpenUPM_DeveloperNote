namespace Eloi.Note
{
    public class AuthorNoteMono : TextNoteMono , I_HasAuthorName
    {

        public AuthorOfNote m_author;

        public void GetAuthor(out string author)
        {
            author = m_author.GetAuthor();
        }
        public string GetAuthor()
        {
            return m_author.GetAuthor();
        }
        public void SetAuthor(string author)
        {

            m_author.SetAuthor( author);
        }

        protected virtual void OnValidate()
        {
            SaveCurrentAuthorEditor.SetCurrentAuthor(m_author);
        }

        private void Reset()
        {
            SaveCurrentAuthorEditor.GetCurrentAuthor(out m_author);
        }
    }

}