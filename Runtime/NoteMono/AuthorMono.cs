namespace Eloi.Note
{
    public  class AuthorMono : NoteMonoBehaviour, I_HasAuthorName
{
    public AuthorOfNote m_author = new AuthorOfNote();

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
            m_author.SetAuthor(author);
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