namespace CustomAttributesExample.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)] // "Inherited = true" is default
internal class CustomMarkerAttribute(string Tag) : Attribute
{
    public string Tag { get; } = Tag;
}

