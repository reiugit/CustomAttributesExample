using CustomAttributesExample.Attributes;

namespace CustomAttributesExample.MarkedClasses;

[CustomMarker("Base Tag")] // inheritable base attribute because of "AttributeUsage(Inherited = True)
class BaseClass
{
}
