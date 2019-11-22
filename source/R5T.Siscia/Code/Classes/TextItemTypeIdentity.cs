using System;

using R5T.Guide;


namespace R5T.Siscia
{
    public class TextItemTypeIdentity : TypedGuid
    {
        #region Static

        public static TextItemTypeIdentity New()
        {
            var textItemTypeIdentity = new TextItemTypeIdentity();
            return textItemTypeIdentity;
        }

        public static TextItemTypeIdentity From(Guid guid)
        {
            var textItemTypeIdentity = new TextItemTypeIdentity(guid);
            return textItemTypeIdentity;
        }

        #endregion


        public TextItemTypeIdentity(Guid value)
            : base(value)
        {
        }

        public TextItemTypeIdentity()
            : this(TypedGuid.GetNewGuid())
        {
        }
    }
}
