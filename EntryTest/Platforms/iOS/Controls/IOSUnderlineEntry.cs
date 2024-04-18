using UIKit;

namespace EntryTest.Platforms.iOS.Controls;
public class IosCustomEntry : UITextField
{
    public IosCustomEntry()
    {
        Ended += IOSUnderlineEntry_Ended;
    }

    private void IOSUnderlineEntry_Ended(object? sender, EventArgs e)
    {
        Console.WriteLine("editing ended");
    }
}

