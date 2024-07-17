# Example with custom attributes

Generating a custom attribute using 'AttributeUsage(...)'
<pre>
AttributeUsage(Inherited = True, AllowMultiple = True)

internal class CustomMarkerAttribute(string Tag) : Attribute
{
  public string Tag { get; } = Tag;
}
</pre>

Setting this attribute on a sample base class
<pre>
[CustomMarker("Base Tag")]
class BaseClass { }
</pre>

Setting this attribute on a sample sub class
<pre>
[CustomMarker("Sub Tag")]
class SubClass { }
</pre>

Reading the attributes of the sub class with 'Attribute.GetCustomAttributes(...)'<br>
returns both the attribute set on the sub class and the attribute set on the base class.
<pre>
Sub Tag
Base Tag
</pre>
