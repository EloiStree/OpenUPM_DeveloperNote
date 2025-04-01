namespace Eloi.Note
{
    public static class SaveCurrentAuthorEditor
    {
        public static void SetCurrentAuthor(string author)
        {
#if UNITY_EDITOR
            UnityEditor.EditorPrefs.SetString("CurrentAuthor", author);
#endif
        }
        public static void SetCurrentAuthor(AuthorOfNote author)
        {
            SetCurrentAuthor(author.GetAuthor());
        }

        public static void GetCurrentAuthor(out string author)
        {
            GetCurrentAuthor(out AuthorOfNote a);
            author = a.GetAuthor();
        }
        public static void GetCurrentAuthor(out AuthorOfNote author)
        {
            author = new AuthorOfNote();
#if UNITY_EDITOR
            author.SetAuthor(UnityEditor.EditorPrefs.GetString("CurrentAuthor", ""));
#endif
        }
    }

}