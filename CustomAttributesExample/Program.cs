using CustomAttributesExample.Attributes;
using CustomAttributesExample.KeyHandler;
using CustomAttributesExample.MarkedClasses;

var IsDefined = Attribute.IsDefined(typeof(SubClass), typeof(CustomMarkerAttribute));
var attributes = Attribute.GetCustomAttributes(typeof(SubClass), typeof(CustomMarkerAttribute));

Console.WriteLine($"\nCustomMarkerAttribute is defined: {IsDefined}\n"); // prints "True"

foreach (var attribute in attributes)
{
    Console.WriteLine($"* {((CustomMarkerAttribute)attribute).Tag}");
    // prints "Sub Tag" and "Base Tag" because of "AttributeUsage(Inherited = True, AllowMultiple = True)"
}

KeyHandler.WaitForAnyKey();
