using System;

using R5T.Guide;


namespace R5T.Siscia
{
    public class TextItemIdentity : TypedGuid
    {
        #region Static

        public static TextItemIdentity New()
        {
            var textItemIdentity = new TextItemIdentity();
            return textItemIdentity;
        }

        public static TextItemIdentity From(Guid guid)
        {
            var textItemIdentity = new TextItemIdentity(guid);
            return textItemIdentity;
        }

        #endregion


        public TextItemIdentity(Guid value)
            : base(value)
        {
        }

        public TextItemIdentity()
            : this(TypedGuid.GetNewGuid())
        {
        }
    }
}
